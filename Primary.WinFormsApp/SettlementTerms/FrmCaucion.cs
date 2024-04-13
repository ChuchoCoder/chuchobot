using ChuchoBot.WinFormsApp.Shared;
using System;
using System.Windows.Forms;

namespace ChuchoBot.WinFormsApp.SettlementTerms;

public partial class FrmCaucion : Form
{
    public FrmCaucion()
    {
        InitializeComponent();
    }

    private void numImporteBruto_ValueChanged(object sender, EventArgs e)
    {
        CalculateCaucion();
    }

    private void numTNA_ValueChanged(object sender, EventArgs e)
    {
        CalculateCaucion();
    }

    private void numDias_ValueChanged(object sender, EventArgs e)
    {
        CalculateCaucion();
    }

    private void CalculateCaucion()
    {
        if (numDias.Value == 0 || numTNA.Value == 0 || numImporteBruto.Value == 0)
        {
            return;
        }

        var dias = Convert.ToInt32(numDias.Value);

        if (rdoCaucionColocadora.Checked)
        {
            dias *= -1;
        }

        var caucion = new Caucion(dias, numTNA.Value, numImporteBruto.Value);

        var tipoCaucion = numDias.Value > 0 ? "Colocadora" : "Tomadora";
        grpCaucion.Text = "Caución " + tipoCaucion;
        lblDiasCaucion.Text = "Días Caución: " + caucion.Dias.ToString();

        lblMontoCaucion.Text = "Importe a caucionar: " + caucion.ImporteBruto.ToCurrency();
        lblImporteNeto.Text = "Importe Neto: " + caucion.ImporteNeto.ToCurrency();
        lblInteresBruto.Text = "Interés Bruto: " + caucion.Interes.ToCurrency();
        lblInteresNeto.Text = "Interés Neto (con gastos): " + caucion.InteresNeto.ToCurrency();

        lblIva.Text = "IVA: " + caucion.IVAGastos.ToCurrency();

        lblDerMerCaucion.Text = $"Der. Mer.: " + caucion.DerechosMercado.ToCurrency();
        lblGtoGtiaCaucion.Text = "Gtos. Gtias.: " + caucion.GastosGarantia.ToCurrency();
        lblArancelCaucion.Text = "Arancel: " + caucion.Arancel.ToCurrency();
        lblGastosCaucion.Text = "Total Gastos: " + caucion.TotalGastos.ToCurrency();

    }

    private void FrmCaucion_Load(object sender, EventArgs e)
    {

        numComisionColocadora.Value = Properties.Settings.Default.ArancelCaucionColocadora;
        numComisionTomadora.Value = Properties.Settings.Default.ArancelCaucionTomadora;
    }

    private void numComisionTomadora_ValueChanged(object sender, EventArgs e)
    {
        CalculateCaucion();
    }

    private void numComisionColocadora_ValueChanged(object sender, EventArgs e)
    {
        CalculateCaucion();
    }

    private void rdoCaucionColocadora_CheckedChanged(object sender, EventArgs e)
    {
        CalculateCaucion();
    }

    private void rdoTomadora_CheckedChanged(object sender, EventArgs e)
    {
        CalculateCaucion();
    }
}
