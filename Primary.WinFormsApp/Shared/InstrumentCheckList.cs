using Primary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChuchoBot.WinFormsApp.Shared;
public partial class InstrumentCheckList : UserControl
{
    public bool _settlementsVisible = false;
    public bool SettlementsVisible
    {
        get => _settlementsVisible;
        set
        {
            _settlementsVisible = value;
        }
    }

    public string[] _instruments;

    public string[] SelectedItems => lstSelected.SelectedItems.Cast<string>().ToArray();

    public Dictionary<string, string> CfiCodesDictionary = new Dictionary<string, string>()
        {
            { "", "Todos"},
            { "FXXXSX", "Futuros"},
            { "FXXXXX", "Pases"},
            { "OPAFXS", "Puts - Opciones Matba/Rofex"},
            { "OCAFXS", "Calls - Opciones Matba/Rofex"},
            { "MRIXXX", "Indices"},
            { "OCASPS", "Calls - Opciones"},
            { "OPASPS", "Puts - Opciones"},
            { "DBXXXX", "Renta Fija"},
            { "EMXXXX", "CEDEARs"},
            { "DBXXFR", "Obligaciones Negociables"},
            { "ESXXXX", "Acciones"},
            { "DYXTXR", "Letras"},
            { "RPXXXX", "Cauciones"}
        };

    public InstrumentCheckList()
    {
        InitializeComponent();
    }

    private void InstrumentCheckList_Load(object sender, EventArgs e)
    {
        if (DesignMode == false)
        {
            var cfiCodes = Argentina.Data.AllInstruments.Select(x => x.CfiCode).Distinct().ToArray();

            foreach (var cfiCode in cfiCodes)
            {
                if (!CfiCodesDictionary.ContainsKey(cfiCode))
                {
                    CfiCodesDictionary.Add(cfiCode, cfiCode);
                }
            }

            cmbCfiCodes.DataSource = new BindingSource(CfiCodesDictionary, null);
            cmbCfiCodes.DisplayMember = "Key";
            cmbCfiCodes.ValueMember = "Value";
        }
    }

    public void LoadInstruments(IEnumerable<string> selectedInstruments)
    {
        if (DesignMode == false)
        {

            _instruments = Argentina.Data.AllInstruments.Where(x => x.IsPesos()).Select(selector).Distinct().OrderBy(x => x).ToArray();

            foreach (var item in _instruments)
            {
                if (!selectedInstruments.Contains(item))
                {
                    _ = lstInstrumentos.Items.Add(item);
                }
            }

            foreach (var item in selectedInstruments)
            {
                lstSelected.Items.Add(item);
            }
        }
    }

    private string selector(InstrumentDetail x)
    {
        return SettlementsVisible ? x.InstrumentId.SymbolWithoutPrefix() : x.InstrumentId.Ticker();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        var selected = lstInstrumentos.SelectedItems.Cast<string>().ToArray();
        lstSelected.Items.AddRange(selected);
        foreach (var item in selected)
        {
            lstInstrumentos.Items.Remove(item);
        }

    }

    private void cmbCfiCodes_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedCfiCode = cmbCfiCodes.SelectedValue != string.Empty ? cmbCfiCodes.SelectedValue.ToString() : null;

        _instruments = Argentina.Data.AllInstruments.Where(x => x.IsPesos() 
            && (selectedCfiCode == null || string.Equals(x.CfiCode, selectedCfiCode, StringComparison.InvariantCultureIgnoreCase))
        ).Select(selector).Distinct().OrderBy(x => x).ToArray();

        lstInstrumentos.Items.Clear();

        foreach (var item in _instruments)
        {
            if (!lstSelected.Items.Contains(item))
            {
                _ = lstInstrumentos.Items.Add(item);
            }
        }
    }
}
