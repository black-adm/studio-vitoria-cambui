using Newtonsoft.Json;
using StudioVitoriaCambui.ValueObjects;

namespace StudioVitoriaCambui.Converters;

public class PhoneConverter : JsonConverter<Phone>
{
    public override Phone ReadJson(JsonReader reader, Type objectType, Phone existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.String)
        {
            return new Phone((string)reader.Value);
        }
        throw new JsonSerializationException($"Unexpected token {reader.TokenType} when parsing Phone.");
    }

    public override void WriteJson(JsonWriter writer, Phone value, JsonSerializer serializer)
    {
        writer.WriteValue(value.Contact);
    }
}