
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// The SiliconFlow REST API<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class SiliconFlowClient : global::SiliconFlow.ISiliconFlowClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.siliconflow.cn/v1";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::SiliconFlow.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::SiliconFlow.JsonConverters.EmbeddingsRequestModelJsonConverter(),
                    new global::SiliconFlow.JsonConverters.EmbeddingsRequestModelNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.EmbeddingsRequestEncodingFormatJsonConverter(),
                    new global::SiliconFlow.JsonConverters.EmbeddingsRequestEncodingFormatNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.EmbeddingsResponseObjectJsonConverter(),
                    new global::SiliconFlow.JsonConverters.EmbeddingsResponseObjectNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.EmbeddingsResponseDataItemObjectJsonConverter(),
                    new global::SiliconFlow.JsonConverters.EmbeddingsResponseDataItemObjectNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.RerankRequestModelJsonConverter(),
                    new global::SiliconFlow.JsonConverters.RerankRequestModelNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.CreateSpeechRequestModelJsonConverter(),
                    new global::SiliconFlow.JsonConverters.CreateSpeechRequestModelNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.CreateSpeechRequestVoiceJsonConverter(),
                    new global::SiliconFlow.JsonConverters.CreateSpeechRequestVoiceNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter(),
                    new global::SiliconFlow.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.AudioRequestModelJsonConverter(),
                    new global::SiliconFlow.JsonConverters.AudioRequestModelNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.FinishReasonJsonConverter(),
                    new global::SiliconFlow.JsonConverters.FinishReasonNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.CompletionResponseObjectJsonConverter(),
                    new global::SiliconFlow.JsonConverters.CompletionResponseObjectNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ChatCompletionRequestModelJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ChatCompletionRequestModelNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageRoleJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageRoleNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ChatCompletionResponseObjectJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ChatCompletionResponseObjectNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ChatCompletionStreamObjectJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ChatCompletionStreamObjectNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ChatCompletionChunkObjectJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ChatCompletionChunkObjectNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.StableDiffusion35LargeModelJsonConverter(),
                    new global::SiliconFlow.JsonConverters.StableDiffusion35LargeModelNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.StableDiffusion35LargeImageSizeJsonConverter(),
                    new global::SiliconFlow.JsonConverters.StableDiffusion35LargeImageSizeNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.Flux1SchnellModelJsonConverter(),
                    new global::SiliconFlow.JsonConverters.Flux1SchnellModelNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.Flux1SchnellImageSizeJsonConverter(),
                    new global::SiliconFlow.JsonConverters.Flux1SchnellImageSizeNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ProFlux1SchnellModelJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ProFlux1SchnellModelNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ProFlux1SchnellImageSizeJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ProFlux1SchnellImageSizeNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.Flux1DevModelJsonConverter(),
                    new global::SiliconFlow.JsonConverters.Flux1DevModelNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.Flux1DevImageSizeJsonConverter(),
                    new global::SiliconFlow.JsonConverters.Flux1DevImageSizeNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.StableDiffusion3MediumModelJsonConverter(),
                    new global::SiliconFlow.JsonConverters.StableDiffusion3MediumModelNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.StableDiffusion3MediumImageSizeJsonConverter(),
                    new global::SiliconFlow.JsonConverters.StableDiffusion3MediumImageSizeNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.StableDiffusionXlBase10ModelJsonConverter(),
                    new global::SiliconFlow.JsonConverters.StableDiffusionXlBase10ModelNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.StableDiffusionXlBase10ImageSizeJsonConverter(),
                    new global::SiliconFlow.JsonConverters.StableDiffusionXlBase10ImageSizeNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.StableDiffusion21ModelJsonConverter(),
                    new global::SiliconFlow.JsonConverters.StableDiffusion21ModelNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.StableDiffusion21ImageSizeJsonConverter(),
                    new global::SiliconFlow.JsonConverters.StableDiffusion21ImageSizeNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.UploadAudioVoiceRequestModelJsonConverter(),
                    new global::SiliconFlow.JsonConverters.UploadAudioVoiceRequestModelNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.RetrieveAListOfModelsTypeJsonConverter(),
                    new global::SiliconFlow.JsonConverters.RetrieveAListOfModelsTypeNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.RetrieveAListOfModelsSubTypeJsonConverter(),
                    new global::SiliconFlow.JsonConverters.RetrieveAListOfModelsSubTypeNullableJsonConverter(),
                    new global::SiliconFlow.JsonConverters.CompletionStreamJsonConverter(),
                    new global::SiliconFlow.JsonConverters.ChatCompletionRequestUserMessageContentPartJsonConverter(),
                    new global::SiliconFlow.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.LogprobsPart, object>(),
                    new global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.UsageData, object>(),
                    new global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.FinishReason?, object>(),
                    new global::SiliconFlow.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionRequestUserMessageContentPart>>(),
                    new global::SiliconFlow.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.UsageData, object>(),
                    new global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.FinishReason?, object>(),
                    new global::SiliconFlow.JsonConverters.OneOfJsonConverter<global::SiliconFlow.StableDiffusion35Large, global::SiliconFlow.Flux1Schnell, global::SiliconFlow.ProFlux1Schnell, global::SiliconFlow.Flux1Dev, global::SiliconFlow.StableDiffusion3Medium, global::SiliconFlow.StableDiffusionXlBase10, global::SiliconFlow.StableDiffusion21>(),
                    new global::SiliconFlow.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AudioClient Audio => new AudioClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionsClient ChatCompletions => new ChatCompletionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ImageClient Image => new ImageClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RerankClient Rerank => new RerankClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UserInfoClient UserInfo => new UserInfoClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the SiliconFlowClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public SiliconFlowClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::SiliconFlow.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::SiliconFlow.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}