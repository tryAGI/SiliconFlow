
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionChunk
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
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.ChatCompletionChunkObjectJsonConverter))]
        public global::SiliconFlow.ChatCompletionChunkObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SiliconFlow.ChatCompletionToken Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionChoice> Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.UsageData, object>))]
        public global::SiliconFlow.AllOf<global::SiliconFlow.UsageData, object>? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.FinishReason?, object>))]
        public global::SiliconFlow.AllOf<global::SiliconFlow.FinishReason?, object>? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunk" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="created"></param>
        /// <param name="token"></param>
        /// <param name="choices"></param>
        /// <param name="object"></param>
        /// <param name="usage"></param>
        /// <param name="finishReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionChunk(
            string id,
            int created,
            global::SiliconFlow.ChatCompletionToken token,
            global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionChoice> choices,
            global::SiliconFlow.ChatCompletionChunkObject @object,
            global::SiliconFlow.AllOf<global::SiliconFlow.UsageData, object>? usage,
            global::SiliconFlow.AllOf<global::SiliconFlow.FinishReason?, object>? finishReason)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Created = created;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Usage = usage;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunk" /> class.
        /// </summary>
        public ChatCompletionChunk()
        {
        }
    }
}