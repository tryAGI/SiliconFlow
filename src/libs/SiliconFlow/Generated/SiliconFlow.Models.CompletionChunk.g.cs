
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SiliconFlow.CompletionToken Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::SiliconFlow.CompletionChoice> Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.UsageData, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SiliconFlow.AllOf<global::SiliconFlow.UsageData, object> Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.FinishReason?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SiliconFlow.AllOf<global::SiliconFlow.FinishReason?, object> FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionChunk" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="token"></param>
        /// <param name="choices"></param>
        /// <param name="usage"></param>
        /// <param name="finishReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionChunk(
            string id,
            global::SiliconFlow.CompletionToken token,
            global::System.Collections.Generic.IList<global::SiliconFlow.CompletionChoice> choices,
            global::SiliconFlow.AllOf<global::SiliconFlow.UsageData, object> usage,
            global::SiliconFlow.AllOf<global::SiliconFlow.FinishReason?, object> finishReason)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Usage = usage;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionChunk" /> class.
        /// </summary>
        public CompletionChunk()
        {
        }

    }
}