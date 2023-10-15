using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StudioVitoriaCambui.ValueObjects;

namespace StudioVitoriaCambui.Converters;

public class EmailConverter : JsonConverter<Email>
{

    public override Email ReadJson(JsonReader reader, Type objectType, Email existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.String)
        {
            return new Email((string)reader.Value);
        }
        throw new JsonSerializationException($"Unexpected token {reader.TokenType} when parsing Email.");
    }

    public override void WriteJson(JsonWriter writer, Email value, JsonSerializer serializer)
    {
        writer.WriteValue(value.Address);
    }
}