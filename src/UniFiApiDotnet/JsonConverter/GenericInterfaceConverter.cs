using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace UniFiApiDotnet.JsonConverter
{
    internal abstract class GenericInterfaceConverter<TInterface, TInstance> : JsonConverter<TInterface>
        where TInstance : TInterface, new() where TInterface : class
    {

        public override TInterface? Read(ref Utf8JsonReader reader, Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.StartObject)
            {

                return JsonSerializer.Deserialize<TInstance>(ref reader, options) as TInterface;
            }

            return new TInstance();
        }

        public override void Write(Utf8JsonWriter writer, TInterface value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}