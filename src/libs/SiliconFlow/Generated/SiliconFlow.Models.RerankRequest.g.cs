
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankRequest
    {
        /// <summary>
        /// Specifies the model to be used.<br/>
        /// Example: BAAI/bge-reranker-v2-m3
        /// </summary>
        /// <example>BAAI/bge-reranker-v2-m3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.RerankRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SiliconFlow.RerankRequestModel Model { get; set; }

        /// <summary>
        /// Required. The search query.<br/>
        /// Default Value: Apple<br/>
        /// Example: Apple
        /// </summary>
        /// <default>"Apple"</default>
        /// <example>Apple</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; } = "Apple";

        /// <summary>
        /// Required. List of documents to be reordered. If document objects are provided, the 'text' field is mandatory, and other fields will be preserved in the response.<br/>
        /// Default Value: [苹果, 香蕉, 水果, 蔬菜]<br/>
        /// Example: [苹果, 香蕉, 水果, 蔬菜]
        /// </summary>
        /// <example>[苹果, 香蕉, 水果, 蔬菜]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Documents { get; set; }

        /// <summary>
        /// Number of most relevant documents or indices to return.<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_n")]
        public int? TopN { get; set; }

        /// <summary>
        /// If false, the response does not include document text; if true, it includes the input document text.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_documents")]
        public bool? ReturnDocuments { get; set; }

        /// <summary>
        /// Maximum number of chunks generated from within a document. Long documents are divided into multiple chunks for calculation, and the highest score among the chunks is taken as the document's score.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_chunks_per_doc")]
        public int? MaxChunksPerDoc { get; set; }

        /// <summary>
        /// Number of token overlaps between adjacent chunks when documents are chunked.<br/>
        /// Default Value: 80
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlap_tokens")]
        public int? OverlapTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Specifies the model to be used.<br/>
        /// Example: BAAI/bge-reranker-v2-m3
        /// </param>
        /// <param name="query">
        /// Required. The search query.<br/>
        /// Default Value: Apple<br/>
        /// Example: Apple
        /// </param>
        /// <param name="documents">
        /// Required. List of documents to be reordered. If document objects are provided, the 'text' field is mandatory, and other fields will be preserved in the response.<br/>
        /// Default Value: [苹果, 香蕉, 水果, 蔬菜]<br/>
        /// Example: [苹果, 香蕉, 水果, 蔬菜]
        /// </param>
        /// <param name="topN">
        /// Number of most relevant documents or indices to return.<br/>
        /// Example: 4
        /// </param>
        /// <param name="returnDocuments">
        /// If false, the response does not include document text; if true, it includes the input document text.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxChunksPerDoc">
        /// Maximum number of chunks generated from within a document. Long documents are divided into multiple chunks for calculation, and the highest score among the chunks is taken as the document's score.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="overlapTokens">
        /// Number of token overlaps between adjacent chunks when documents are chunked.<br/>
        /// Default Value: 80
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankRequest(
            global::SiliconFlow.RerankRequestModel model,
            string query,
            global::System.Collections.Generic.IList<string> documents,
            int? topN,
            bool? returnDocuments,
            int? maxChunksPerDoc,
            int? overlapTokens)
        {
            this.Model = model;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.TopN = topN;
            this.ReturnDocuments = returnDocuments;
            this.MaxChunksPerDoc = maxChunksPerDoc;
            this.OverlapTokens = overlapTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRequest" /> class.
        /// </summary>
        public RerankRequest()
        {
        }
    }
}