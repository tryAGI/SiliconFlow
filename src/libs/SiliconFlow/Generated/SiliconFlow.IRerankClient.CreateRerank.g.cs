#nullable enable

namespace SiliconFlow
{
    public partial interface IRerankClient
    {
        /// <summary>
        /// Create Rerank<br/>
        /// Creates a rerank request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.RerankResponse> CreateRerankAsync(

            global::SiliconFlow.RerankRequest request,
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Rerank<br/>
        /// Creates a rerank request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.AutoSDKHttpResponse<global::SiliconFlow.RerankResponse>> CreateRerankAsResponseAsync(

            global::SiliconFlow.RerankRequest request,
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Rerank<br/>
        /// Creates a rerank request.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.RerankResponse> CreateRerankAsync(
            global::SiliconFlow.RerankRequestModel model,
            global::System.Collections.Generic.IList<string> documents,
            string query = "Apple",
            int? topN = default,
            bool? returnDocuments = default,
            int? maxChunksPerDoc = default,
            int? overlapTokens = default,
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}