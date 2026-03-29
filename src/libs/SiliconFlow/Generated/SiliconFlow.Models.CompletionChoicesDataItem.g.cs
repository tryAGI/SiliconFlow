
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionChoicesDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.FinishReasonJsonConverter))]
        public global::SiliconFlow.FinishReason? FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.LogprobsPart, object>))]
        public global::SiliconFlow.AllOf<global::SiliconFlow.LogprobsPart, object>? Logprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionChoicesDataItem" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="finishReason"></param>
        /// <param name="logprobs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionChoicesDataItem(
            string? text,
            global::SiliconFlow.FinishReason? finishReason,
            global::SiliconFlow.AllOf<global::SiliconFlow.LogprobsPart, object>? logprobs)
        {
            this.Text = text;
            this.FinishReason = finishReason;
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionChoicesDataItem" /> class.
        /// </summary>
        public CompletionChoicesDataItem()
        {
        }
    }
}