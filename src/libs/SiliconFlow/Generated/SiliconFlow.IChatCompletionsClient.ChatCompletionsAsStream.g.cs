#nullable enable

namespace SiliconFlow
{
    public partial interface IChatCompletionsClient
    {
        /// <summary>
        /// Chat Completions<br/>
        /// Creates a model response for the given chat conversation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::SiliconFlow.ChatCompletionStream> ChatCompletionsAsStreamAsync(

            global::SiliconFlow.ChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat Completions<br/>
        /// Creates a model response for the given chat conversation.
        /// </summary>
        /// <param name="model">
        /// The name of the model to query.<br/>
        /// Default Value: deepseek-ai/DeepSeek-V2.5<br/>
        /// Example: deepseek-ai/DeepSeek-V2.5
        /// </param>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate.<br/>
        /// Default Value: 512<br/>
        /// Example: 512
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="temperature">
        /// Determines the degree of randomness in the response.<br/>
        /// Default Value: 0.7<br/>
        /// Example: 0.7
        /// </param>
        /// <param name="topP">
        /// The `top_p` (nucleus) parameter is used to dynamically adjust the number of choices for each predicted token based on the cumulative probabilities.<br/>
        /// Default Value: 0.7<br/>
        /// Example: 0.7
        /// </param>
        /// <param name="topK">
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="frequencyPenalty">
        /// Default Value: 0.5<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="n">
        /// Number of generations to return<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="responseFormat">
        /// An object specifying the format that the model must output.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::SiliconFlow.ChatCompletionStream> ChatCompletionsAsStreamAsync(
            global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionRequestMessage> messages,
            global::SiliconFlow.ChatCompletionRequestModel model = global::SiliconFlow.ChatCompletionRequestModel.DeepseekAiDeepSeekV25,
            int? maxTokens = default,
            global::SiliconFlow.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            float? temperature = default,
            float? topP = default,
            float? topK = default,
            float? frequencyPenalty = default,
            int? n = default,
            global::SiliconFlow.ChatCompletionRequestResponseFormat? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}