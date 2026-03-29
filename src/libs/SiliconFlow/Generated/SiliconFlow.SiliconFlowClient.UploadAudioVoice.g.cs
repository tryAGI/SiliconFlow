
#nullable enable

namespace SiliconFlow
{
    public partial class SiliconFlowClient
    {
        partial void PrepareUploadAudioVoiceArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::SiliconFlow.UploadAudioVoiceRequest request);
        partial void PrepareUploadAudioVoiceRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::SiliconFlow.UploadAudioVoiceRequest request);
        partial void ProcessUploadAudioVoiceResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadAudioVoiceResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload Voice<br/>
        /// 上传用户预置音色，支持以 base64 编码或者文件形式上传，参考https://docs.siliconflow.cn/capabilities/text-to-speech#2-2)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::SiliconFlow.UploadAudioVoiceResponse> UploadAudioVoiceAsync(

            global::SiliconFlow.UploadAudioVoiceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUploadAudioVoiceArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::SiliconFlow.PathBuilder(
                path: "/uploads/audio/voice",
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
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (request.Model != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Model.ToValueString()}"),
                    name: "\"model\"");
            }
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.CustomName}"),
                name: "\"customName\"");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Text}"),
                name: "\"text\"");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUploadAudioVoiceRequest(
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
            ProcessUploadAudioVoiceResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // BadRequest
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                string? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_400, typeof(string), JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_400, typeof(string), JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::SiliconFlow.ApiException<string>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unauthorized
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                string? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_401, typeof(string), JsonSerializerContext);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_401, typeof(string), JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::SiliconFlow.ApiException<string>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // NotFound
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                string? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_404, typeof(string), JsonSerializerContext);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_404, typeof(string), JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::SiliconFlow.ApiException<string>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // RateLimit
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                string? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_429, typeof(string), JsonSerializerContext);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_429, typeof(string), JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::SiliconFlow.ApiException<string>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Overloaded
            if ((int)__response.StatusCode == 503)
            {
                string? __content_503 = null;
                global::System.Exception? __exception_503 = null;
                string? __value_503 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_503 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_503, typeof(string), JsonSerializerContext);
                    }
                    else
                    {
                        __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_503 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_503, typeof(string), JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_503 = __ex;
                }

                throw new global::SiliconFlow.ApiException<string>(
                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_503,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_503,
                    ResponseObject = __value_503,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Timeout
            if ((int)__response.StatusCode == 504)
            {
                string? __content_504 = null;
                global::System.Exception? __exception_504 = null;
                string? __value_504 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_504 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_504 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_504, typeof(string), JsonSerializerContext);
                    }
                    else
                    {
                        __content_504 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_504 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_504, typeof(string), JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_504 = __ex;
                }

                throw new global::SiliconFlow.ApiException<string>(
                    message: __content_504 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_504,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_504,
                    ResponseObject = __value_504,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessUploadAudioVoiceResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::SiliconFlow.UploadAudioVoiceResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
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
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::SiliconFlow.UploadAudioVoiceResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// Upload Voice<br/>
        /// 上传用户预置音色，支持以 base64 编码或者文件形式上传，参考https://docs.siliconflow.cn/capabilities/text-to-speech#2-2)
        /// </summary>
        /// <param name="model">
        /// 预置音色的模型名称<br/>
        /// Example: fishaudio/fish-speech-1.4
        /// </param>
        /// <param name="customName">
        /// 用户自定义的音色名称<br/>
        /// Default Value: 硅基流动音色模型<br/>
        /// Example: your-voice-name
        /// </param>
        /// <param name="text">
        /// 音频对应的文字内容<br/>
        /// Default Value: 在一无所知中, 梦里的一天结束了，一个新的轮回便会开始<br/>
        /// Example: 在一无所知中, 梦里的一天结束了，一个新的轮回便会开始
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::SiliconFlow.UploadAudioVoiceResponse> UploadAudioVoiceAsync(
            global::SiliconFlow.UploadAudioVoiceRequestModel model = default,
            string customName = "硅基流动音色模型",
            string text = "在一无所知中, 梦里的一天结束了，一个新的轮回便会开始",
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::SiliconFlow.UploadAudioVoiceRequest
            {
                Model = model,
                CustomName = customName,
                Text = text,
            };

            return await UploadAudioVoiceAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}