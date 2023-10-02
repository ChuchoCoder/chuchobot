using Primary.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Primary
{
    public static class Constants
    {
        public static Entry[] AllEntries = {
            Entry.Bids,
            Entry.Offers,
            Entry.Last,
            Entry.Open,
            Entry.Close,
            Entry.SettlementPrice,
            Entry.SessionHighPrice,
            Entry.SessionLowPrice,
            Entry.Volume,
            Entry.OpenInterest,
            Entry.IndexValue,
            Entry.EffectiveVolume,
            Entry.NominalVolume
        };
    }
}
