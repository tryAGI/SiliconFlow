
#nullable enable

namespace SiliconFlow
{
    public partial class ChatCompletionsClient
    {
        partial void PrepareChatCompletionsAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::SiliconFlow.ChatCompletionRequest request);
        partial void PrepareChatCompletionsAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::SiliconFlow.ChatCompletionRequest request);
        partial void ProcessChatCompletionsAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Chat Completions<br/>
        /// Creates a model response for the given chat conversation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::SiliconFlow.ChatCompletionStream> ChatCompletionsAsStreamAsync(

            global::SiliconFlow.ChatCompletionRequest request,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));


            request = new global::SiliconFlow.ChatCompletionRequest
            {
                Model = request.Model,
                Messages = request.Messages,
                Stream = true,
                MaxTokens = request.MaxTokens,
                Stop = request.Stop,
                Temperature = request.Temperature,
                TopP = request.TopP,
                TopK = request.TopK,
                FrequencyPenalty = request.FrequencyPenalty,
                N = request.N,
                ResponseFormat = request.ResponseFormat,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareChatCompletionsAsStreamArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::SiliconFlow.PathBuilder(
                path: "/chat/completions",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareChatCompletionsAsStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessChatCompletionsAsStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                string? __content = null;
                try
                {
                    __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);
                }
                catch (global::System.Exception)
                {
                }

                throw new global::SiliconFlow.ApiException(
                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            using var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                cancellationToken
#endif
            ).ConfigureAwait(false);

            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                .Create(__stream).EnumerateAsync(cancellationToken))
            {
                var __content = __sseEvent.Data;
                if (__content == "[DONE]")
                {
                    yield break;
                }

                var __streamedResponse = global::SiliconFlow.ChatCompletionStream.FromJson(__content, JsonSerializerContext) ??
                                       throw new global::SiliconFlow.ApiException(
                                           message: $"Response deserialization failed for \"{__content}\" ",
                                           statusCode: __response.StatusCode)
                                       {
                                           ResponseBody = __content,
                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                               __response.Headers,
                                               h => h.Key,
                                               h => h.Value),
                                       };

                yield return __streamedResponse;
            }
        }
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
        public async global::System.Collections.Generic.IAsyncEnumerable<global::SiliconFlow.ChatCompletionStream> ChatCompletionsAsStreamAsync(
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
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::SiliconFlow.ChatCompletionRequest
            {
                Model = model,
                Messages = messages,
                Stream = true,
                MaxTokens = maxTokens,
                Stop = stop,
                Temperature = temperature,
                TopP = topP,
                TopK = topK,
                FrequencyPenalty = frequencyPenalty,
                N = n,
                ResponseFormat = responseFormat,
            };

            var __enumerable = ChatCompletionsAsStreamAsync(
                request: __request,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}