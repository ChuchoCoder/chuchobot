using ChuchoBot.WinFormsApp.Shared;
using Primary.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChuchoBot.WinFormsApp.Tests;

internal class InstrumentTests
{

    public static void Initialize()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        var instrumentsStream = assembly.GetManifestResourceStream("ChuchoBot.WinFormsApp.Tests.InstrumentsWithDetails.json");
        StreamReader reader = new StreamReader(instrumentsStream);
        var instruments = reader.ReadToEnd();

        Argentina.Data.AllInstruments = Newtonsoft.Json.JsonConvert.DeserializeObject<InstrumentDetail[]>(instruments);

    }
}
