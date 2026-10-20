using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NUnit.Framework;
using Primary.Data;

namespace Primary.Tests.Serialization
{
    [TestFixture]
    public class InstrumentCatalogNullPriceFactorTests
    {
        // Both index entries in the broker catalog have an unavailable price conversion factor.
        private static string IndexJson(string symbol, string factor = "null") => @"
            {
                ""segment"": {""marketSegmentId"":""MERV"",""marketId"":""ROFX""},
                ""instrumentId"": {""marketId"":""ROFX"",""symbol"":""<symbol>""},
                ""lowLimitPrice"": 0.0,
                ""highLimitPrice"": 1000000.0,
                ""minPriceIncrement"": 0.001,
                ""minTradeVol"": 0,
                ""maxTradeVol"": 1000000000,
                ""tickSize"": 1,
                ""contractMultiplier"": 1.0,
                ""roundLot"": 1.0,
                ""priceConvertionFactor"": <factor>,
                ""maturityDate"": null,
                ""currency"": ""ARS"",
                ""instrumentPricePrecision"": 3,
                ""instrumentSizePrecision"": 2,
                ""cficode"": ""MRIXXX""
            }".Replace("<symbol>", symbol).Replace("<factor>", factor);

        [Test]
        public async Task Startup_catalog_load_survives_null_index_factors_and_preserves_the_bond_factor()
        {
            var json = "{\"instruments\":[" + IndexJson("MMSCI") + @",
                {""instrumentId"":{""marketId"":""ROFX"",""symbol"":""MERV - XMEV - AL30 - CI""},
                 ""priceConvertionFactor"":0.01}," + IndexJson("GMSCI") + "]}";
            var handler = new CatalogHandler(json);
            using var client = new HttpClient(handler);
            var api = new Api(new Uri("http://test.local/"), client);

            var instruments = (await api.GetAllInstrumentsWithDetails()).ToArray();

            Assert.That(instruments.Select(i => i.InstrumentId.Symbol),
                Is.EqualTo(new[] { "MMSCI", "MERV - XMEV - AL30 - CI", "GMSCI" }));
            Assert.That(instruments[0].PriceConvertionFactor, Is.Zero);
            Assert.That(instruments[2].PriceConvertionFactor, Is.Zero);
            Assert.That(instruments[1].PriceConvertionFactor, Is.EqualTo(0.01m));
            Assert.That(instruments[0].MinPriceIncrement, Is.EqualTo(0.001m));
            Assert.That(instruments[2].CfiCode, Is.EqualTo("MRIXXX"));
            Assert.That(handler.CallCount, Is.EqualTo(1));
        }

        [TestCase("MMSCI")]
        [TestCase("GMSCI")]
        public void Null_index_factor_survives_the_instrument_cache_round_trip(string symbol)
        {
            var detail = JsonConvert.DeserializeObject<InstrumentDetail>(IndexJson(symbol));

            Assert.That(detail.PriceConvertionFactor, Is.Zero);
            var cached = JsonConvert.SerializeObject(new[] { detail }, Formatting.Indented);
            Assert.That(cached, Does.Contain("\"PriceConvertionFactor\": 0"));
            var restored = JsonConvert.DeserializeObject<IEnumerable<InstrumentDetail>>(cached).Single();
            Assert.That(restored.PriceConvertionFactor, Is.Zero);
            Assert.That(restored.InstrumentId.Symbol, Is.EqualTo(symbol));
        }

        [TestCase("0.01", 0.01)]
        [TestCase("\"0.01\"", 0.01)]
        [TestCase("1e-2", 0.01)]
        [TestCase("1", 1)]
        public void Valid_price_factors_keep_the_existing_number_and_string_contract(string token, double expected)
        {
            var detail = JsonConvert.DeserializeObject<InstrumentDetail>(IndexJson("MMSCI", token));

            Assert.That(detail.PriceConvertionFactor, Is.EqualTo((decimal)expected));
        }

        [TestCase("\"invalid\"")]
        [TestCase("{}")]
        [TestCase("true")]
        public void Malformed_non_null_factors_still_fail(string token)
        {
            Assert.Throws<JsonReaderException>(() =>
                JsonConvert.DeserializeObject<InstrumentDetail>(IndexJson("MMSCI", token)));
        }

        [Test]
        public void Omitted_factor_keeps_the_existing_zero_sentinel()
        {
            var json = IndexJson("MMSCI").Replace("\"priceConvertionFactor\": null,", string.Empty);

            Assert.That(JsonConvert.DeserializeObject<InstrumentDetail>(json).PriceConvertionFactor, Is.Zero);
        }

        [Test]
        public void Null_tolerance_does_not_extend_to_other_numeric_fields()
        {
            var json = IndexJson("MMSCI", "1").Replace("\"roundLot\": 1.0", "\"roundLot\": null");

            Assert.Throws<JsonSerializationException>(() => JsonConvert.DeserializeObject<InstrumentDetail>(json));
        }

        private sealed class CatalogHandler : HttpMessageHandler
        {
            private readonly string _json;
            public int CallCount { get; private set; }

            public CatalogHandler(string json) => _json = json;

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken ct)
            {
                CallCount++;
                Assert.That(request.Method, Is.EqualTo(HttpMethod.Get));
                Assert.That(request.RequestUri.AbsolutePath, Is.EqualTo("/rest/instruments/details"));
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(_json)
                });
            }
        }
    }
}
