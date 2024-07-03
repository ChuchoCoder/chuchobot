using ChuchoBot.WinFormsApp.Properties;
using Primary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ChuchoBot.WinFormsApp.Shared;

public partial class InstrumentSearchList : UserControl
{
    public bool _settlementsVisible = false;
    public bool SettlementsVisible
    {
        get => _settlementsVisible;
        set
        {
            _settlementsVisible = value;
            LoadInstruments();
        }
    }
    public string[] _instruments;

    public string SelectedInstrument => listInstrumentos.SelectedItem as string;
    public string SelectedTicker => SelectedInstrument.RemoveSettlement();

    public InstrumentSearchList()
    {
        InitializeComponent();
    }

    private void InstrumentSearchList_Load(object sender, EventArgs e)
    {
        if (DesignMode == false)
        {
            LoadInstruments();

            _ = txtSearch.Focus();
        }
    }

    private void LoadInstruments()
    {
        if (DesignMode == false)
        {
            if (Argentina.Data.HasPositions() == false)
            {
                chkOnlyCurrentPositions.Enabled = false;
                chkOnlyCurrentPositions.Text += " (No existen posiciones)";
            }

            string selector(InstrumentDetail x)
            {
                return SettlementsVisible ? x.InstrumentId.SymbolWithoutPrefix() : x.InstrumentId.Ticker();
            }

            _instruments = Argentina.Data.AllInstruments.Where(x => x.IsPesos()).Select(selector).Distinct().OrderBy(x => x).ToArray();

            foreach (var item in _instruments)
            {
                _ = listInstrumentos.Items.Add(item);
            }
        }
    }

    private void FilterInstruments()
    {
        IEnumerable<string> instruments = _instruments;

        Func<string, bool> onlyShowCurrentPositionFilter = x => true;

        if (chkOnlyCurrentPositions.Checked)
        {
            onlyShowCurrentPositionFilter = x => Argentina.Data.TickerExistsInPositions(Instrument.MervalPrefix + x);
        }

        Func<string, bool> textSearchFilter = x => true;

        if (string.IsNullOrWhiteSpace(txtSearch.Text) == false)
        {
            textSearchFilter = x => x.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        instruments = instruments.Where(x => textSearchFilter(x) && onlyShowCurrentPositionFilter(x));

        listInstrumentos.Items.Clear();
        foreach (var item in instruments)
        {
            _ = listInstrumentos.Items.Add(item);
        }
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        FilterInstruments();
    }

    public bool ValidateSelectedInstrument()
    {
        if (listInstrumentos.SelectedItem == null)
        {
            _ = MessageBox.Show("Seleccionar el intrumento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (Settings.Default.TickersToMonitor.TickerExists(SelectedTicker) == false)
        {
            _ = MessageBox.Show($"El instrumento '{SelectedTicker}' no se encuentra en la lista de instrumentos monitoreados. Agregar dicho instrumento en la Configuracion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }

    private void chkOnlyCurrentPositions_CheckedChanged(object sender, EventArgs e)
    {
        FilterInstruments();
    }

    public event EventHandler InstrumentDoubleClick;

    private void listInstrumentos_DoubleClick(object sender, EventArgs e)
    {
        InstrumentDoubleClick?.Invoke(sender, e);
    }
}
