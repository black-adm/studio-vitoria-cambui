using Newtonsoft.Json;
using StudioVitoriaCambui.ValueObjects;

namespace StudioVitoriaCambui.Converters
{
    public class PasswordConverter : JsonConverter<Password>
    {
        public override Password ReadJson(JsonReader reader, Type objectType, Password existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                string plainPassword = (string)reader.Value;
                return new Password(plainPassword);
            }
            throw new JsonSerializationException("Invalid Password format.");
        }

        public override void WriteJson(JsonWriter writer, Password value, JsonSerializer serializer)
        {
            writer.WriteValue(value.HashPassword);
        }
    }
}