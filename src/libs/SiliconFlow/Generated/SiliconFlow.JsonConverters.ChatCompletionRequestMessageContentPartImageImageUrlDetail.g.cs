#nullable enable

namespace SiliconFlow.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrlDetail>
    {
        /// <inheritdoc />
        public override global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrlDetail Read(
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
                        return global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrlDetailExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrlDetail)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrlDetail);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrlDetail value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrlDetailExtensions.ToValueString(value));
        }
    }
}
