using Newtonsoft.Json;
using Primary.Serialization;
using System;
using System.Linq;

namespace Primary.Data
{
    [JsonConverter(typeof(SettlementTypeJsonSerializer))]
    public enum SettlementType
    {
        CI,
        T24H,
        T48H,
        Otro
    }

    [JsonConverter(typeof(EntryJsonSerializer))]
    public enum Entry
    {
        /// <summary>Best buy offer in the Market Book.</summary>
        Bids, 
        
        /// <summary>Best sell offer in the Market Book.</summary>
        Offers,

        /// <summary>Last price traded in the Market Book.</summary>
        Last,

        /// <summary>Opening price in the Market Book.</summary>
        Open,

        /// <summary>Closing price in the Market Book.</summary>
        Close,

        /// <summary>Settlement price (only for futures).</summary>
        SettlementPrice,
        
        /// <summary>Highest price traded.</summary>
        SessionHighPrice,
        
        /// <summary>Lowest price traded.</summary>
        SessionLowPrice,
        
        /// <summary>Traded volume in contracts/nominal.</summary>
        Volume,
        
        /// <summary>Open interest in contracts (only for futures).</summary>
        OpenInterest,
        
        /// <summary>Calculated index value (only for indices).</summary>
        IndexValue,
        
        /// <summary>Effective traded volume.</summary>
        EffectiveVolume,
        
        /// <summary>Nominal traded volume.</summary>
        NominalVolume
    } 

    #region String serialization

    internal static class EnumsToApiStrings
    {
        #region SettlementType

        public static string ToApiString(this SettlementType value)
        {
            return value switch
            {
                SettlementType.CI => "0",
                SettlementType.T24H => "1",
                SettlementType.T48H => "2",
                _ => value.ToString(),
            };
        }

        public static SettlementType SettlementTypeFromApiString(string value)
        {
            return (value.ToUpper()) switch
            {
                "0" => SettlementType.CI,
                "1" => SettlementType.T24H,
                "2" => SettlementType.T24H,
                _ => SettlementType.Otro
            };
        }

        #endregion

        #region Entry

        public static string ToApiString(this Entry[] entries)
        {
            var entryList = entries.Select(x => ToApiString(x));
            var querystring = string.Join(",", entryList);
            return querystring;
        }


        public static string ToApiString(this Entry value)
        {
            return value switch
            {
                Entry.Bids => "BI",
                Entry.Offers => "OF",
                Entry.Last => "LA",
                Entry.Open => "OP",
                Entry.Close => "CL",
                Entry.SettlementPrice => "SE",
                Entry.SessionHighPrice => "HI",
                Entry.SessionLowPrice => "LO",
                Entry.Volume => "TV",
                Entry.OpenInterest => "OI",
                Entry.IndexValue => "IV",
                Entry.EffectiveVolume => "EV",
                Entry.NominalVolume => "NV",
                _ => throw new InvalidEnumStringException(value.ToString())
            };
        }

        public static Entry EntryFromApiString(string value)
        {
            return value switch
            {
                "BI" => Entry.Bids,
                "OF" => Entry.Offers,
                "LA" => Entry.Last,
                "OP" => Entry.Open,
                "CL" => Entry.Close,
                "SE" => Entry.SettlementPrice,
                "HI" => Entry.SessionHighPrice,
                "LO" => Entry.SessionLowPrice,
                "TV" => Entry.Volume,
                "OI" => Entry.OpenInterest,
                "IV" => Entry.IndexValue,
                "EV" => Entry.EffectiveVolume,
                "NV" => Entry.NominalVolume,
                _ => throw new InvalidEnumStringException(value)
            };
        }

        #endregion
    }

    #endregion

    #region JSON Serialization

    internal class SettlementTypeJsonSerializer : EnumJsonSerializer<SettlementType>
    {
        protected override string ToString(SettlementType enumValue)
        {
            return enumValue.ToApiString();
        }

        protected override SettlementType FromString(string enumString)
        {
            return EnumsToApiStrings.SettlementTypeFromApiString(enumString);
        }
    }

    internal class EntryJsonSerializer : EnumJsonSerializer<Entry>
    {
        protected override string ToString(Entry enumValue)
        {
            return enumValue.ToApiString();
        }

        protected override Entry FromString(string enumString)
        {
            return EnumsToApiStrings.EntryFromApiString(enumString);
        }
    }

    #endregion
}
