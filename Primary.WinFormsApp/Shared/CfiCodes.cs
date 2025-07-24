using System.Collections.Generic;

namespace ChuchoBot.WinFormsApp.Shared;
internal static class CfiCodes
{
    public static readonly KeyValuePair<string, string> Todos = new("", "Todos");
    public static readonly KeyValuePair<string, string> Futuros = new("FXXXSX", "Futuros");
    public static readonly KeyValuePair<string, string> Pases = new("FXXXXX", "Pases");
    public static readonly KeyValuePair<string, string> PutsOpcionesMatbaRofex = new("OPAFXS", "Puts - Opciones Matba/Rofex");
    public static readonly KeyValuePair<string, string> CallsOpcionesMatbaRofex = new("OCAFXS", "Calls - Opciones Matba/Rofex");
    public static readonly KeyValuePair<string, string> Indices = new("MRIXXX", "Indices");
    public static readonly KeyValuePair<string, string> CallsOpciones = new("OCASPS", "Calls - Opciones");
    public static readonly KeyValuePair<string, string> PutsOpciones = new("OPASPS", "Puts - Opciones");
    public static readonly KeyValuePair<string, string> RentaFija = new("DBXXXX", "Renta Fija");
    public static readonly KeyValuePair<string, string> CEDEARs = new("EMXXXX", "CEDEARs");
    public static readonly KeyValuePair<string, string> ObligacionesNegociables = new("DBXXFR", "Obligaciones Negociables");
    public static readonly KeyValuePair<string, string> Acciones = new("ESXXXX", "Acciones");
    public static readonly KeyValuePair<string, string> Letras = new("DYXTXR", "Letras");
    public static readonly KeyValuePair<string, string> Cauciones = new("RPXXXX", "Cauciones");

    public static readonly Dictionary<string, string> AllCfiCodes = new()
           {
               { Todos.Key, Todos.Value },
               { Futuros.Key, Futuros.Value },
               { Pases.Key, Pases.Value },
               { PutsOpcionesMatbaRofex.Key, PutsOpcionesMatbaRofex.Value },
               { CallsOpcionesMatbaRofex.Key, CallsOpcionesMatbaRofex.Value },
               { Indices.Key, Indices.Value },
               { CallsOpciones.Key, CallsOpciones.Value },
               { PutsOpciones.Key, PutsOpciones.Value },
               { RentaFija.Key, RentaFija.Value },
               { CEDEARs.Key, CEDEARs.Value },
               { ObligacionesNegociables.Key, ObligacionesNegociables.Value },
               { Acciones.Key, Acciones.Value },
               { Letras.Key, Letras.Value },
               { Cauciones.Key, Cauciones.Value }
           };

    public static bool IsOption(string cfiCode)
    {
        return cfiCode == CallsOpciones.Key || cfiCode == PutsOpciones.Key || cfiCode == CallsOpcionesMatbaRofex.Key || cfiCode == PutsOpcionesMatbaRofex.Key;
    }

    public static bool IsFuture(string cfiCode)
    {
        return cfiCode == Futuros.Key;
    }
}
