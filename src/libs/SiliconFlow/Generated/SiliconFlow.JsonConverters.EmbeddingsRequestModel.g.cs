#nullable enable

namespace SiliconFlow.JsonConverters
{
    /// <inheritdoc />
    public sealed class EmbeddingsRequestModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SiliconFlow.EmbeddingsRequestModel>
    {
        /// <inheritdoc />
        public override global::SiliconFlow.EmbeddingsRequestModel Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::SiliconFlow.EmbeddingsRequestModelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::SiliconFlow.EmbeddingsRequestModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::SiliconFlow.EmbeddingsRequestModel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SiliconFlow.EmbeddingsRequestModel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::SiliconFlow.EmbeddingsRequestModelExtensions.ToValueString(value));
        }
    }
}
