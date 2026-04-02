#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace SiliconFlow.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionRequestUserMessageContentPartJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SiliconFlow.ChatCompletionRequestUserMessageContentPart>
    {
        /// <inheritdoc />
        public override global::SiliconFlow.ChatCompletionRequestUserMessageContentPart Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("image_url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::SiliconFlow.ChatCompletionRequestMessageContentPartText? textContentPart = default;
            global::SiliconFlow.ChatCompletionRequestMessageContentPartImage? imageContentPart = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        textContentPart = global::System.Text.Json.JsonSerializer.Deserialize<global::SiliconFlow.ChatCompletionRequestMessageContentPartText>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        imageContentPart = global::System.Text.Json.JsonSerializer.Deserialize<global::SiliconFlow.ChatCompletionRequestMessageContentPartImage>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (textContentPart == null && imageContentPart == null)
            {
                try
                {
                    textContentPart = global::System.Text.Json.JsonSerializer.Deserialize<global::SiliconFlow.ChatCompletionRequestMessageContentPartText>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    imageContentPart = global::System.Text.Json.JsonSerializer.Deserialize<global::SiliconFlow.ChatCompletionRequestMessageContentPartImage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::SiliconFlow.ChatCompletionRequestUserMessageContentPart(
                textContentPart,

                imageContentPart
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SiliconFlow.ChatCompletionRequestUserMessageContentPart value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTextContentPart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextContentPart, typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartText), options);
            }
            else if (value.IsImageContentPart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageContentPart, typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImage), options);
            }
        }
    }
}