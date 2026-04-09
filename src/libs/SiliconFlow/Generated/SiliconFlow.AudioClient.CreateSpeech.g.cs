
#nullable enable

namespace SiliconFlow
{
    public partial class AudioClient
    {


        private static readonly global::SiliconFlow.EndPointSecurityRequirement s_CreateSpeechSecurityRequirement0 =
            new global::SiliconFlow.EndPointSecurityRequirement
            {
                Authorizations = new global::SiliconFlow.EndPointAuthorizationRequirement[]
                {                    new global::SiliconFlow.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::SiliconFlow.EndPointSecurityRequirement[] s_CreateSpeechSecurityRequirements =
            new global::SiliconFlow.EndPointSecurityRequirement[]
            {                s_CreateSpeechSecurityRequirement0,
            };
        partial void PrepareCreateSpeechArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::SiliconFlow.CreateSpeechRequest request);
        partial void PrepareCreateSpeechRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::SiliconFlow.CreateSpeechRequest request);
        partial void ProcessCreateSpeechResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateSpeechResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Create Speech<br/>
        /// 从输入文本生成音频。根据输入的文本生成音频。接口生成的数据为音频的二进制数据，需要使用者自行处理。参考：https://docs.siliconflow.cn/capabilities/text-to-speech#5
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(

            global::SiliconFlow.CreateSpeechRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateSpeechAsResponseAsync(

                request: request,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Create Speech<br/>
        /// 从输入文本生成音频。根据输入的文本生成音频。接口生成的数据为音频的二进制数据，需要使用者自行处理。参考：https://docs.siliconflow.cn/capabilities/text-to-speech#5
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::SiliconFlow.AutoSDKHttpResponse<byte[]>> CreateSpeechAsResponseAsync(

            global::SiliconFlow.CreateSpeechRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateSpeechArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::SiliconFlow.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateSpeechSecurityRequirements,
                operationName: "CreateSpeechAsync");

            var __pathBuilder = new global::SiliconFlow.PathBuilder(
                path: "/audio/speech",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            PrepareCreateSpeechRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateSpeechResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessCreateSpeechResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return new global::SiliconFlow.AutoSDKHttpResponse<byte[]>(
                        statusCode: __response.StatusCode,
                        headers: global::SiliconFlow.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __content);
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::SiliconFlow.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return new global::SiliconFlow.AutoSDKHttpResponse<byte[]>(
                        statusCode: __response.StatusCode,
                        headers: global::SiliconFlow.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __content);
                }
                catch (global::System.Exception __ex)
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
            }
        }
        /// <summary>
        /// Create Speech<br/>
        /// 从输入文本生成音频。根据输入的文本生成音频。接口生成的数据为音频的二进制数据，需要使用者自行处理。参考：https://docs.siliconflow.cn/capabilities/text-to-speech#5
        /// </summary>
        /// <param name="model">
        /// Current available TTS models: `fishaudio/fish-speech-1.4`<br/>
        /// Example: fishaudio/fish-speech-1.4
        /// </param>
        /// <param name="input">
        /// The text to generate audio for.
        /// </param>
        /// <param name="voice">
        /// The voice to use when generating the audio. Supported voices are `fishaudio/fish-speech-1.4:alex`, `fishaudio/fish-speech-1.4:anna`, `fishaudio/fish-speech-1.4:bella`, `fishaudio/fish-speech-1.4:benjamin`, `fishaudio/fish-speech-1.4:charles`, `fishaudio/fish-speech-1.4:claire`, `fishaudio/fish-speech-1.4:david`, `fishaudio/fish-speech-1.4:diana`. Previews of the voices are available in the [Text to speech guide](/capabilities/text-to-speech).
        /// </param>
        /// <param name="responseFormat">
        /// The format to audio in. Supported formats are `mp3`, `opus`, `wav`, `pcm`<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(
            string input,
            global::SiliconFlow.CreateSpeechRequestVoice voice,
            global::SiliconFlow.CreateSpeechRequestModel model = default,
            global::SiliconFlow.CreateSpeechRequestResponseFormat? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::SiliconFlow.CreateSpeechRequest
            {
                Model = model,
                Input = input,
                Voice = voice,
                ResponseFormat = responseFormat,
            };

            return await CreateSpeechAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}