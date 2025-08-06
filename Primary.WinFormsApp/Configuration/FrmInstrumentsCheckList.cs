using ChuchoBot.WinFormsApp.Shared;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuchoBot.WinFormsApp.Configuration;
public partial class FrmInstrumentsCheckList : Form
{

    public StringCollection Setting { get; set; }
    //public Func<string[], bool> Validator { get; set; }

    public FrmInstrumentsCheckList()
    {
        InitializeComponent();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var settings = instrumentCheckList1.SelectedItems.Distinct().Cast<string>().ToList();

        if (Argentina.Data.AllInstruments != null)
        {
            var tickersNotFound = new List<string>();
            foreach (var setting in settings)
            {
                var tickers = setting.Split(' ', ';', '/', '\\');
                foreach (var ticker in tickers)
                {
                    if (decimal.TryParse(ticker, out var numValue))
                    {
                        // Ignore validating numbers (e.g. Ratio Alerts)
                    }
                    else if (Argentina.Data.AllInstruments.Any(x => x.InstrumentId.Symbol.Contains(ticker)) == false)
                    {
                        tickersNotFound.Add(ticker);
                    }
                }
            }
            if (tickersNotFound.Count > 0)
            {
                var tickersText = string.Join(", ", tickersNotFound);
                var result = MessageBox.Show($"El/los instrumentos {tickersText} no existen. ¿Desea quitarlos de la lista?", "Instrumentos inexistentes", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Telemetry.LogWarning($"El instrumento {tickersNotFound} no existe.");
                if (result == DialogResult.OK)
                {
                    settings.RemoveAll(x => tickersNotFound.Contains(x));
                }
                else
                {
                    DialogResult = DialogResult.None;
                    return;
                }
            }
        }

        Setting.Clear();
        Setting.AddRange(settings.ToArray());
        Properties.Settings.Default.Save();
        Close();
    }

    private void FrmInstrumentsCheckList_Load(object sender, EventArgs e)
    {
        var instruments = Setting.Cast<string>().OrderBy(x => x);
        instrumentCheckList1.LoadInstruments(instruments);
    }
}
