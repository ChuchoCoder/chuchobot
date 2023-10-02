using System;
using Newtonsoft.Json;

namespace Primary.Serialization
{
    internal abstract class EnumJsonSerializer<T> : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var valueToWrite = ToString((T)value);
            writer.WriteValue(valueToWrite);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var stringValue = reader.Value.ToString();
            return FromString(stringValue);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
        
        protected abstract string ToString(T enumValue);
        protected abstract T FromString(string enumString);
    }
}
