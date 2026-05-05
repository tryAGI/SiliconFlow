
#nullable enable

namespace SiliconFlow
{
    public partial class ChatCompletionsClient
    {


        private static readonly global::SiliconFlow.EndPointSecurityRequirement s_ChatCompletionsAsStreamSecurityRequirement0 =
            new global::SiliconFlow.EndPointSecurityRequirement
            {
                Authorizations = new global::SiliconFlow.EndPointAuthorizationRequirement[]
                {                    new global::SiliconFlow.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::SiliconFlow.EndPointSecurityRequirement[] s_ChatCompletionsAsStreamSecurityRequirements =
            new global::SiliconFlow.EndPointSecurityRequirement[]
            {                s_ChatCompletionsAsStreamSecurityRequirement0,
            };
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::SiliconFlow.ChatCompletionStream> ChatCompletionsAsStreamAsync(

            global::SiliconFlow.ChatCompletionRequest request,
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
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


            var __authorizations = global::SiliconFlow.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ChatCompletionsAsStreamSecurityRequirements,
                operationName: "ChatCompletionsAsStreamAsync");

            using var __timeoutCancellationTokenSource = global::SiliconFlow.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::SiliconFlow.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::SiliconFlow.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::SiliconFlow.PathBuilder(
                                path: "/chat/completions",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::SiliconFlow.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::SiliconFlow.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareChatCompletionsAsStreamRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::SiliconFlow.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::SiliconFlow.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatCompletionsAsStream",
                                methodName: "ChatCompletionsAsStreamAsync",
                                pathTemplate: "\"/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::SiliconFlow.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::SiliconFlow.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::SiliconFlow.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatCompletionsAsStream",
                                methodName: "ChatCompletionsAsStreamAsync",
                                pathTemplate: "\"/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::SiliconFlow.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::SiliconFlow.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::SiliconFlow.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::SiliconFlow.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::SiliconFlow.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatCompletionsAsStream",
                                methodName: "ChatCompletionsAsStreamAsync",
                                pathTemplate: "\"/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::SiliconFlow.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessChatCompletionsAsStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::SiliconFlow.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::SiliconFlow.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatCompletionsAsStream",
                                methodName: "ChatCompletionsAsStreamAsync",
                                pathTemplate: "\"/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::SiliconFlow.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::SiliconFlow.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatCompletionsAsStream",
                                methodName: "ChatCompletionsAsStreamAsync",
                                pathTemplate: "\"/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

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
                                        __effectiveCancellationToken
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
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                                .Create(__stream).EnumerateAsync(__effectiveCancellationToken))
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
            }
            finally
            {
                __httpRequest?.Dispose();
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
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
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
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
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}