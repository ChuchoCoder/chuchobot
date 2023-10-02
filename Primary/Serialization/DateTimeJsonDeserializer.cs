using Newtonsoft.Json.Converters;

namespace Primary.Serialization
{
    internal class DateTimeJsonDeserializer : IsoDateTimeConverter
    {
        public DateTimeJsonDeserializer()
        {
            DateTimeFormat = "yyyyMMdd-HH:mm:ss.fffK";
        }
    }
}
