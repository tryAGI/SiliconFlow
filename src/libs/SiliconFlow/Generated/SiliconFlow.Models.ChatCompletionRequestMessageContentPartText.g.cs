
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartText
    {
        /// <summary>
        /// The type of the content part.<br/>
        /// Default Value: text
        /// </summary>
        /// <default>global::SiliconFlow.ChatCompletionRequestMessageContentPartTextType.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter))]
        public global::SiliconFlow.ChatCompletionRequestMessageContentPartTextType Type { get; set; } = global::SiliconFlow.ChatCompletionRequestMessageContentPartTextType.Text;

        /// <summary>
        /// The text content.<br/>
        /// Default Value: 描述这张图片
        /// </summary>
        /// <default>"描述这张图片"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; } = "描述这张图片";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartText" /> class.
        /// </summary>
        /// <param name="text">
        /// The text content.<br/>
        /// Default Value: 描述这张图片
        /// </param>
        /// <param name="type">
        /// The type of the content part.<br/>
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestMessageContentPartText(
            string text,
            global::SiliconFlow.ChatCompletionRequestMessageContentPartTextType type = global::SiliconFlow.ChatCompletionRequestMessageContentPartTextType.Text)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartText" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartText()
        {
        }

    }
}