using ChuchoBot.WinFormsApp.Properties;
using System;

namespace ChuchoBot.WinFormsApp.SettlementTerms;

public class Caucion
{
    // https://www.byma.com.ar/que-es-byma/derechos-membresias-2/
    // https://www.byma.com.ar/wp-content/uploads/dlm_uploads/2023/10/BYMA-Derechos-Mercado-sobre-Operaciones-2023-10-11.pdf
    // Proporcional al plazo de la operación hasta 90 días, sobre mayor valor
    public const decimal DerechosMercadoTasaDiaria = 0.045m / 100 / 90;

    public const decimal GastosGarantiaTasaDiaria = 0.045m / 100 / 90;

    public const decimal IVAPorcentaje = 0.21m;

    public Caucion(int dias, decimal tna, decimal importeBruto)
    {
        Dias = dias;
        TNA = tna;
        ImporteBruto = importeBruto;

        var diasAbs = Math.Abs(dias);

        Tasa = Math.Abs(tna / 100m * diasAbs / 365m);
        EsColocadora = Dias < 0;
        ArancelTNA = EsColocadora ? Settings.Default.ArancelCaucionColocadora : Settings.Default.ArancelCaucionTomadora;
        Interes = importeBruto * Tasa;
        ImporteConInteres = ImporteBruto + Interes;
        Arancel = ImporteConInteres * (ArancelTNA / 100m * diasAbs / 365m);
        DerechosMercado = ImporteConInteres * DerechosMercadoTasaDiaria * diasAbs;
        GastosGarantia = EsColocadora ? 0 : ImporteConInteres * GastosGarantiaTasaDiaria * diasAbs;

        Gastos = Arancel + DerechosMercado + GastosGarantia;
        IVAGastos = Gastos * IVAPorcentaje;
        TotalGastos = Gastos + IVAGastos;

        if (EsColocadora)
        {
            InteresNeto = Interes - TotalGastos;
            ImporteNeto = ImporteConInteres - TotalGastos;
        }
        else
        {
            InteresNeto = Interes + TotalGastos;
            ImporteNeto = ImporteConInteres + TotalGastos;
        }
    }

    /// <summary>
    /// Días de la caución. 
    /// Cuando los Días son negativos representa una caución colocadora
    /// Cuando los Días son positivos representa una caución tomadora
    /// </summary>
    public int Dias { get; }
    public decimal TNA { get; }

    /// <summary>
    /// Total a caucionar
    /// </summary>
    public decimal ImporteBruto { get; }

    /// <summary>
    /// Tasa calculada según los días de la caución y la TNA
    /// </summary>
    public decimal Tasa { get; }
    public bool EsColocadora { get; }
    public decimal ArancelTNA { get; }
    public decimal Interes { get; }

    /// <summary>
    /// Interes calculado sobre el Interes incluyendo todos los gastos.
    /// Si es caución colocadora los gastos se restan
    /// Si es caución tomadora los gastos se suman
    /// </summary>
    public decimal InteresNeto { get; }

    /// <summary>
    /// Monto caucionado más el interés
    /// </summary>
    public decimal ImporteConInteres { get; }


    public decimal Arancel { get; }
    public decimal DerechosMercado { get; }
    public decimal GastosGarantia { get; }

    /// <summary>
    /// Importe total (sin IVA) que incluye Arancel, Derechos de Mercado y Administración de Garantías
    /// </summary>
    public decimal Gastos { get; }

    /// <summary>
    /// Importe de IVA calculado sobre el Arancel, Derechos de Mercado y Administración de Garantías
    /// </summary>
    public decimal IVAGastos { get; }

    /// <summary>
    /// Importe total de gastos que incluye Arancel, Derechos de Mercado, Administración de Garantías e incluye el IVA.
    /// </summary>
    public decimal TotalGastos { get; }

    /// <summary>
    /// Importe total de caucion + interés +/- gastos
    /// </summary>
    public decimal ImporteNeto { get; }
}
