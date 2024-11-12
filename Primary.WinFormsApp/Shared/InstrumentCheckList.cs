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

    public string[] SelectedItems => lstSelected.Items.Cast<string>().ToArray();

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
            cmbCfiCodes.DisplayMember = "Value";
            cmbCfiCodes.ValueMember = "Key";
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
                    _ = lstAvailable.Items.Add(item);
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
        var selected = lstAvailable.SelectedItems.Cast<string>().ToArray();
        lstSelected.Items.AddRange(selected);
        foreach (var item in selected)
        {
            lstAvailable.Items.Remove(item);
        }

    }

    private void cmbCfiCodes_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedCfiCode = cmbCfiCodes.SelectedValue != string.Empty ? cmbCfiCodes.SelectedValue.ToString() : null;

        _instruments = Argentina.Data.AllInstruments.Where(x => x.IsPesos()
            && (selectedCfiCode == null || string.Equals(x.CfiCode, selectedCfiCode, StringComparison.InvariantCultureIgnoreCase))
        ).Select(selector).Distinct().OrderBy(x => x).ToArray();

        lstAvailable.Items.Clear();

        foreach (var item in _instruments)
        {
            if (!lstSelected.Items.Contains(item))
            {
                _ = lstAvailable.Items.Add(item);
            }
        }
    }

    private void btnAddAll_Click(object sender, EventArgs e)
    {
        var selected = lstAvailable.Items.Cast<string>().ToArray();
        lstSelected.Items.AddRange(selected);
        foreach (var item in selected)
        {
            lstAvailable.Items.Remove(item);
        }

    }

    private void btnRemoveAll_Click(object sender, EventArgs e)
    {
        var selected = lstSelected.Items.Cast<string>().ToArray();
        lstAvailable.Items.AddRange(selected);
        foreach (var item in selected)
        {
            lstSelected.Items.Remove(item);
        }
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        var selected = lstSelected.SelectedItems.Cast<string>().ToArray();
        lstAvailable.Items.AddRange(selected);
        foreach (var item in selected)
        {
            lstSelected.Items.Remove(item);
        }
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        string instrumentSearch = string.IsNullOrWhiteSpace(txtSearch.Text) ? null : txtSearch.Text;

        _instruments = Argentina.Data.AllInstruments.Where(x => x.IsPesos()
            && (instrumentSearch == null || x.InstrumentId.Symbol.Contains(instrumentSearch, StringComparison.InvariantCultureIgnoreCase))
        ).Select(selector).Distinct().OrderBy(x => x).ToArray();

        lstAvailable.Items.Clear();

        foreach (var item in _instruments)
        {
            if (!lstSelected.Items.Contains(item))
            {
                _ = lstAvailable.Items.Add(item);
            }
        }
    }
}
