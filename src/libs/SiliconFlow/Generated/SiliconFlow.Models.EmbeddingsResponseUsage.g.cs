
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// The usage information for the request.
    /// </summary>
    public sealed partial class EmbeddingsResponseUsage
    {
        /// <summary>
        /// The number of tokens used by the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// The number of tokens used by the completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; }

        /// <summary>
        /// The total number of tokens used by the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsResponseUsage" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// The number of tokens used by the prompt.
        /// </param>
        /// <param name="completionTokens">
        /// The number of tokens used by the completion.
        /// </param>
        /// <param name="totalTokens">
        /// The total number of tokens used by the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsResponseUsage(
            int promptTokens,
            int completionTokens,
            int totalTokens)
        {
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsResponseUsage" /> class.
        /// </summary>
        public EmbeddingsResponseUsage()
        {
        }
    }
}