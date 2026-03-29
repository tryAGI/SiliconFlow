
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionChoicesDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::SiliconFlow.ChatCompletionChoicesDataItemMessage? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.FinishReasonJsonConverter))]
        public global::SiliconFlow.FinishReason? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChoicesDataItem" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="finishReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionChoicesDataItem(
            global::SiliconFlow.ChatCompletionChoicesDataItemMessage? message,
            global::SiliconFlow.FinishReason? finishReason)
        {
            this.Message = message;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChoicesDataItem" /> class.
        /// </summary>
        public ChatCompletionChoicesDataItem()
        {
        }
    }
}