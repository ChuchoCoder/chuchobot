using ChuchoBot.WinFormsApp.Shared;
using System;
using System.Windows.Forms;

namespace ChuchoBot.WinFormsApp.SettlementTerms;

public partial class SettlementTermSettings : UserControl
{
    public SettlementTermSettings()
    {
        InitializeComponent();
    }

    public int DiasLiq24H => (int)numDiasLiq24H.Value;
    public decimal CaucionTNA => numTasa.Value;
    public decimal Comision => numComision.Value;
    public decimal ArancelCaucionTomadora => numComisionTomadora.Value;
    public decimal ArancelCaucionColocadora => numComisionColocadora.Value;

    private void numDiasLiq24H_ValueChanged(object sender, EventArgs e)
    {
            
    }


    private void numTasa_ValueChanged(object sender, EventArgs e)
    {
        Properties.Settings.Default.TasaCaucion = numTasa.Value;
        Properties.Settings.Default.Save();
    }

    private void numComision_ValueChanged(object sender, EventArgs e)
    {
        Properties.Settings.Default.Comision = numComision.Value;
        Properties.Settings.Default.Save();
    }

    private void numComisionTomadora_ValueChanged(object sender, EventArgs e)
    {
        Properties.Settings.Default.ArancelCaucionTomadora = numComisionTomadora.Value;
        Properties.Settings.Default.Save();
    }

    private void numComisionColocadora_ValueChanged(object sender, EventArgs e)
    {
        Properties.Settings.Default.ArancelCaucionColocadora = numComisionColocadora.Value;
        Properties.Settings.Default.Save();

    }

    private void SettlementTermSettings_Load(object sender, EventArgs e)
    {
        if (DesignMode == false)
        {
            LoadValues();
        }
    }

    public void LoadValues()
    {
        numComision.Value = Properties.Settings.Default.Comision;
        numTasa.Value = Properties.Settings.Default.TasaCaucion;
        numComisionColocadora.Value = Properties.Settings.Default.ArancelCaucionColocadora;
        numComisionTomadora.Value = Properties.Settings.Default.ArancelCaucionTomadora;

        var diasLiq24H = Settlement.GetDiasLiquidacion24H();
        numDiasLiq24H.Value = diasLiq24H;

    }

    public void RefreshValues()
    {
        var caucion24HTicker = Settlement.GetCaucionPesosTicker(DiasLiq24H);
        var caucion24HInstrument = Argentina.Data.GetInstrumentDetailOrNull(caucion24HTicker);

        if (caucion24HInstrument != null)
        {
            var entries = Argentina.Data.GetLatestOrNull(caucion24HTicker);
            if (entries != null && entries.HasLastPrice())
            {
                numTasa.Value = entries.Last.Price.Value;
                numTasa.Enabled = false;
            }
            else
            {
                numTasa.Enabled = true;
            }
        }
    }
}
