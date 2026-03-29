
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankResponseResult
    {
        /// <summary>
        /// Original document content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::SiliconFlow.RerankResponseResultDocument? Document { get; set; }

        /// <summary>
        /// The index value of the position in the input candidate doc array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Similarity score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevance_score")]
        public double? RelevanceScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResponseResult" /> class.
        /// </summary>
        /// <param name="document">
        /// Original document content.
        /// </param>
        /// <param name="index">
        /// The index value of the position in the input candidate doc array.
        /// </param>
        /// <param name="relevanceScore">
        /// Similarity score.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankResponseResult(
            global::SiliconFlow.RerankResponseResultDocument? document,
            int? index,
            double? relevanceScore)
        {
            this.Document = document;
            this.Index = index;
            this.RelevanceScore = relevanceScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResponseResult" /> class.
        /// </summary>
        public RerankResponseResult()
        {
        }
    }
}