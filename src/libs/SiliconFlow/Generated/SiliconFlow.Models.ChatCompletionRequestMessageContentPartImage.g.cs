
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartImage
    {
        /// <summary>
        /// The type of the content part.<br/>
        /// Default Value: image_url
        /// </summary>
        /// <default>global::SiliconFlow.ChatCompletionRequestMessageContentPartImageType.ImageUrl</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter))]
        public global::SiliconFlow.ChatCompletionRequestMessageContentPartImageType Type { get; set; } = global::SiliconFlow.ChatCompletionRequestMessageContentPartImageType.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrl ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartImage" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type">
        /// The type of the content part.<br/>
        /// Default Value: image_url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestMessageContentPartImage(
            global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrl imageUrl,
            global::SiliconFlow.ChatCompletionRequestMessageContentPartImageType type = global::SiliconFlow.ChatCompletionRequestMessageContentPartImageType.ImageUrl)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartImage" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartImage()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChatCompletionRequestMessageContentPartImage"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatCompletionRequestMessageContentPartImage FromImageUrl(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrl imageUrl)
        {
            return new ChatCompletionRequestMessageContentPartImage
            {
                ImageUrl = imageUrl,
            };
        }

    }
}