﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChuchoBot.WinFormsApp.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UserName {
            get {
                return ((string)(this["UserName"]));
            }
            set {
                this["UserName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Password {
            get {
                return ((string)(this["Password"]));
            }
            set {
                this["Password"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("850")]
        public decimal USDARS {
            get {
                return ((decimal)(this["USDARS"]));
            }
            set {
                this["USDARS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal Comision {
            get {
                return ((decimal)(this["Comision"]));
            }
            set {
                this["Comision"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.01")]
        public decimal DerechoMercado {
            get {
                return ((decimal)(this["DerechoMercado"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.08")]
        public decimal DerechoMercadoAccionCEDEAR {
            get {
                return ((decimal)(this["DerechoMercadoAccionCEDEAR"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <string>AL30</string>
  <string>AL29</string>
  <string>AE38</string>
  <string>GD30</string>
  <string>GD35</string>
  <string>AL35</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection OwnedTickers {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["OwnedTickers"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://api.cocos.xoms.com.ar")]
        public string ApiBaseUrl {
            get {
                return ((string)(this["ApiBaseUrl"]));
            }
            set {
                this["ApiBaseUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("70")]
        public decimal TasaCaucion {
            get {
                return ((decimal)(this["TasaCaucion"]));
            }
            set {
                this["TasaCaucion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.5")]
        public decimal ArancelCaucionColocadora {
            get {
                return ((decimal)(this["ArancelCaucionColocadora"]));
            }
            set {
                this["ArancelCaucionColocadora"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public decimal ArancelCaucionTomadora {
            get {
                return ((decimal)(this["ArancelCaucionTomadora"]));
            }
            set {
                this["ArancelCaucionTomadora"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.001")]
        public decimal DerechoMercadoLetra {
            get {
                return ((decimal)(this["DerechoMercadoLetra"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("InstrumentationKey=fad780b5-9d86-41bf-9b39-8a0cbe73b9f7;IngestionEndpoint=https:/" +
            "/eastus-8.in.applicationinsights.azure.com/;LiveEndpoint=https://eastus.livediag" +
            "nostics.monitor.azure.com/")]
        public string AppInsightsConnectionString {
            get {
                return ((string)(this["AppInsightsConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsd=\"http://www.w3." +
            "org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n  <s" +
            "tring>S14J4;SJ4D;SJ4C</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection TickersDC {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["TickersDC"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsd=\"http://www.w3." +
            "org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n  <s" +
            "tring>AAL</string>\r\n  <string>AAPL</string>\r\n  <string>ABBV</string>\r\n  <string>" +
            "ABT</string>\r\n  <string>ADBE</string>\r\n  <string>ADGO</string>\r\n  <string>AE38</" +
            "string>\r\n  <string>AL29</string>\r\n  <string>AL30</string>\r\n  <string>AL35</strin" +
            "g>\r\n  <string>AL41</string>\r\n  <string>AMD</string>\r\n  <string>AMZN</string>\r\n  " +
            "<string>ARCO</string>\r\n  <string>ARKK</string>\r\n  <string>AVGO</string>\r\n  <stri" +
            "ng>AXP</string>\r\n  <string>BA</string>\r\n  <string>BA.C</string>\r\n  <string>BABA<" +
            "/string>\r\n  <string>BBD</string>\r\n  <string>BBV</string>\r\n  <string>BIDU</string" +
            ">\r\n  <string>BIDU</string>\r\n  <string>BIOX</string>\r\n  <string>BITF</string>\r\n  " +
            "<string>BNG</string>\r\n  <string>BRFS</string>\r\n  <string>BRKB</string>\r\n  <strin" +
            "g>C</string>\r\n  <string>CAT</string>\r\n  <string>COIN</string>\r\n  <string>CRM</st" +
            "ring>\r\n  <string>CSCO</string>\r\n  <string>CVX</string>\r\n  <string>CX</string>\r\n " +
            " <string>DE</string>\r\n  <string>DEO</string>\r\n  <string>DESP</string>\r\n  <string" +
            ">DIA</string>\r\n  <string>DISN</string>\r\n  <string>DOW</string>\r\n  <string>EEM</s" +
            "tring>\r\n  <string>ETSY</string>\r\n  <string>EWZ</string>\r\n  <string>F</string>\r\n " +
            " <string>FCX</string>\r\n  <string>GD29</string>\r\n  <string>GD30</string>\r\n  <stri" +
            "ng>GD35</string>\r\n  <string>GD38</string>\r\n  <string>GD41</string>\r\n  <string>GD" +
            "46</string>\r\n  <string>GE</string>\r\n  <string>GLOB</string>\r\n  <string>GM</strin" +
            "g>\r\n  <string>GOLD</string>\r\n  <string>GOOGL</string>\r\n  <string>HMY</string>\r\n " +
            " <string>HSY</string>\r\n  <string>HUT</string>\r\n  <string>IBM</string>\r\n  <string" +
            ">INTC</string>\r\n  <string>IWM</string>\r\n  <string>JD</string>\r\n  <string>JMIA</s" +
            "tring>\r\n  <string>JNJ</string>\r\n  <string>JPM</string>\r\n  <string>KO</string>\r\n " +
            " <string>MCD</string>\r\n  <string>MELI</string>\r\n  <string>META</string>\r\n  <stri" +
            "ng>MMM</string>\r\n  <string>MO</string>\r\n  <string>MRK</string>\r\n  <string>MSFT</" +
            "string>\r\n  <string>MTR</string>\r\n  <string>NFLX</string>\r\n  <string>NIO</string>" +
            "\r\n  <string>NKE</string>\r\n  <string>NVDA</string>\r\n  <string>OXY</string>\r\n  <st" +
            "ring>PAAS</string>\r\n  <string>PBR</string>\r\n  <string>PEP</string>\r\n  <string>PF" +
            "E</string>\r\n  <string>PG</string>\r\n  <string>PYPL</string>\r\n  <string>QCOM</stri" +
            "ng>\r\n  <string>QCOM</string>\r\n  <string>QQQ</string>\r\n  <string>RIO</string>\r\n  " +
            "<string>S14J4</string>\r\n  <string>SJ4D</string>\r\n  <string>SATL</string>\r\n  <str" +
            "ing>SHOP</string>\r\n  <string>SID</string>\r\n  <string>SPY</string>\r\n  <string>SQ<" +
            "/string>\r\n  <string>T</string>\r\n  <string>TEN</string>\r\n  <string>TGT</string>\r\n" +
            "  <string>TSLA</string>\r\n  <string>TSM</string>\r\n  <string>UPST</string>\r\n  <str" +
            "ing>V</string>\r\n  <string>VALE</string>\r\n  <string>VIST</string>\r\n  <string>VZ</" +
            "string>\r\n  <string>WBA</string>\r\n  <string>WFC</string>\r\n  <string>WMT</string>\r" +
            "\n  <string>XLE</string>\r\n  <string>XLF</string>\r\n  <string>XOM</string>\r\n  <stri" +
            "ng>ZM</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection ArbitrationTickers {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ArbitrationTickers"]));
            }
            set {
                this["ArbitrationTickers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <string>GD29/AL29</string>
  <string>GD30/AL30</string>
  <string>GD35/AL35</string>
  <string>GD38/AE38</string>
  <string>GD41/AL41</string>
  <string>AL30/GD35</string>
  <string>GD30/GD35</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection RatioTickers {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["RatioTickers"]));
            }
            set {
                this["RatioTickers"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("11:00:00")]
        public global::System.TimeSpan MarketOpenTime {
            get {
                return ((global::System.TimeSpan)(this["MarketOpenTime"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("17:00:00")]
        public global::System.TimeSpan MarketCloseTime {
            get {
                return ((global::System.TimeSpan)(this["MarketCloseTime"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("16:30:00")]
        public global::System.TimeSpan MarketCloseCITime {
            get {
                return ((global::System.TimeSpan)(this["MarketCloseCITime"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:03:00")]
        public global::System.TimeSpan MarketAuctionTimePeriod {
            get {
                return ((global::System.TimeSpan)(this["MarketAuctionTimePeriod"]));
            }
        }
    }
}
