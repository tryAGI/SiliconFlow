
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::SiliconFlow.JsonConverters.EmbeddingsRequestModelJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.EmbeddingsRequestModelNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.EmbeddingsRequestEncodingFormatJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.EmbeddingsRequestEncodingFormatNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.EmbeddingsResponseObjectJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.EmbeddingsResponseObjectNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.EmbeddingsResponseDataItemObjectJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.EmbeddingsResponseDataItemObjectNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.RerankRequestModelJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.RerankRequestModelNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.CreateSpeechRequestModelJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.CreateSpeechRequestModelNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.CreateSpeechRequestVoiceJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.CreateSpeechRequestVoiceNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.AudioRequestModelJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.AudioRequestModelNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.FinishReasonJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.FinishReasonNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.CompletionResponseObjectJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.CompletionResponseObjectNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ChatCompletionRequestModelJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ChatCompletionRequestModelNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageRoleJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageRoleNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ChatCompletionResponseObjectJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ChatCompletionResponseObjectNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ChatCompletionStreamObjectJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ChatCompletionStreamObjectNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ChatCompletionChunkObjectJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ChatCompletionChunkObjectNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.StableDiffusion35LargeModelJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.StableDiffusion35LargeModelNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.StableDiffusion35LargeImageSizeJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.StableDiffusion35LargeImageSizeNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.Flux1SchnellModelJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.Flux1SchnellModelNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.Flux1SchnellImageSizeJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.Flux1SchnellImageSizeNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ProFlux1SchnellModelJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ProFlux1SchnellModelNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ProFlux1SchnellImageSizeJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ProFlux1SchnellImageSizeNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.Flux1DevModelJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.Flux1DevModelNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.Flux1DevImageSizeJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.Flux1DevImageSizeNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.StableDiffusion3MediumModelJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.StableDiffusion3MediumModelNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.StableDiffusion3MediumImageSizeJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.StableDiffusion3MediumImageSizeNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.StableDiffusionXlBase10ModelJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.StableDiffusionXlBase10ModelNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.StableDiffusionXlBase10ImageSizeJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.StableDiffusionXlBase10ImageSizeNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.StableDiffusion21ModelJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.StableDiffusion21ModelNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.StableDiffusion21ImageSizeJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.StableDiffusion21ImageSizeNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.UploadAudioVoiceRequestModelJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.UploadAudioVoiceRequestModelNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.RetrieveAListOfModelsTypeJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.RetrieveAListOfModelsTypeNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.RetrieveAListOfModelsSubTypeJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.RetrieveAListOfModelsSubTypeNullableJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.CompletionStreamJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.ChatCompletionRequestUserMessageContentPartJsonConverter),

            typeof(global::SiliconFlow.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.LogprobsPart, object>),

            typeof(global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.UsageData, object>),

            typeof(global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.FinishReason?, object>),

            typeof(global::SiliconFlow.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionRequestUserMessageContentPart>>),

            typeof(global::SiliconFlow.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.UsageData, object>),

            typeof(global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.FinishReason?, object>),

            typeof(global::SiliconFlow.JsonConverters.OneOfJsonConverter<global::SiliconFlow.StableDiffusion35Large, global::SiliconFlow.Flux1Schnell, global::SiliconFlow.ProFlux1Schnell, global::SiliconFlow.Flux1Dev, global::SiliconFlow.StableDiffusion3Medium, global::SiliconFlow.StableDiffusionXlBase10, global::SiliconFlow.StableDiffusion21>),

            typeof(global::SiliconFlow.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsRequestModel), TypeInfoPropertyName = "EmbeddingsRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsRequestEncodingFormat), TypeInfoPropertyName = "EmbeddingsRequestEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsResponseObject), TypeInfoPropertyName = "EmbeddingsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SiliconFlow.EmbeddingsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsResponseDataItemObject), TypeInfoPropertyName = "EmbeddingsResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.RerankRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.RerankRequestModel), TypeInfoPropertyName = "RerankRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.RerankResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SiliconFlow.RerankResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.RerankResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.RerankResponseResultDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.RerankResponseTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.CreateSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.CreateSpeechRequestModel), TypeInfoPropertyName = "CreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.CreateSpeechRequestVoice), TypeInfoPropertyName = "CreateSpeechRequestVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.CreateSpeechRequestResponseFormat), TypeInfoPropertyName = "CreateSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.AudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.AudioRequestModel), TypeInfoPropertyName = "AudioRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.AudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ErrorDataError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.FinishReason), TypeInfoPropertyName = "FinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.LogprobsPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SiliconFlow.PromptPartItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.PromptPartItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.UsageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SiliconFlow.CompletionChoicesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.CompletionChoicesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.AllOf<global::SiliconFlow.LogprobsPart, object>), TypeInfoPropertyName = "AllOfLogprobsPartObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.CompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.CompletionResponseObject), TypeInfoPropertyName = "CompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.CompletionStream), TypeInfoPropertyName = "CompletionStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.CompletionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.CompletionChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.CompletionToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SiliconFlow.CompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.CompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.AllOf<global::SiliconFlow.UsageData, object>), TypeInfoPropertyName = "AllOfUsageDataObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.AllOf<global::SiliconFlow.FinishReason?, object>), TypeInfoPropertyName = "AllOfFinishReasonObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionChoicesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionChoicesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionChoicesDataItemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartTextType), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageType), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrlDetail), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartImageImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestUserMessageContentPart), TypeInfoPropertyName = "ChatCompletionRequestUserMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestModel), TypeInfoPropertyName = "ChatCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageRole), TypeInfoPropertyName = "ChatCompletionRequestMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.OneOf<string, global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionRequestUserMessageContentPart>>), TypeInfoPropertyName = "OneOfStringIListChatCompletionRequestUserMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionRequestUserMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionResponseObject), TypeInfoPropertyName = "ChatCompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionStreamObject), TypeInfoPropertyName = "ChatCompletionStreamObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionChunkObject), TypeInfoPropertyName = "ChatCompletionChunkObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionChoiceDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion35Large))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion35LargeModel), TypeInfoPropertyName = "StableDiffusion35LargeModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion35LargeImageSize), TypeInfoPropertyName = "StableDiffusion35LargeImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.Flux1Schnell))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.Flux1SchnellModel), TypeInfoPropertyName = "Flux1SchnellModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.Flux1SchnellImageSize), TypeInfoPropertyName = "Flux1SchnellImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ProFlux1Schnell))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ProFlux1SchnellModel), TypeInfoPropertyName = "ProFlux1SchnellModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ProFlux1SchnellImageSize), TypeInfoPropertyName = "ProFlux1SchnellImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.Flux1Dev))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.Flux1DevModel), TypeInfoPropertyName = "Flux1DevModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.Flux1DevImageSize), TypeInfoPropertyName = "Flux1DevImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion3Medium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion3MediumModel), TypeInfoPropertyName = "StableDiffusion3MediumModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion3MediumImageSize), TypeInfoPropertyName = "StableDiffusion3MediumImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusionXlBase10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusionXlBase10Model), TypeInfoPropertyName = "StableDiffusionXlBase10Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusionXlBase10ImageSize), TypeInfoPropertyName = "StableDiffusionXlBase10ImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion21))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion21Model), TypeInfoPropertyName = "StableDiffusion21Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion21ImageSize), TypeInfoPropertyName = "StableDiffusion21ImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ImagesGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SiliconFlow.ImagesGenerationResponseImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ImagesGenerationResponseImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ImagesGenerationResponseTimings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.UploadAudioVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.UploadAudioVoiceRequestModel), TypeInfoPropertyName = "UploadAudioVoiceRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.UploadAudioVoiceRequestEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.UploadAudioVoiceRequestEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.OneOf<global::SiliconFlow.StableDiffusion35Large, global::SiliconFlow.Flux1Schnell, global::SiliconFlow.ProFlux1Schnell, global::SiliconFlow.Flux1Dev, global::SiliconFlow.StableDiffusion3Medium, global::SiliconFlow.StableDiffusionXlBase10, global::SiliconFlow.StableDiffusion21>), TypeInfoPropertyName = "StableDiffusion21_db7eb062649e1b8c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.RetrieveAListOfModelsType), TypeInfoPropertyName = "RetrieveAListOfModelsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.RetrieveAListOfModelsSubType), TypeInfoPropertyName = "RetrieveAListOfModelsSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.UserInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.UserInfoResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.RetrieveAListOfModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SiliconFlow.RetrieveAListOfModelsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.RetrieveAListOfModelsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.UploadAudioVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SiliconFlow.EmbeddingsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SiliconFlow.RerankResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SiliconFlow.PromptPartItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SiliconFlow.CompletionChoicesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SiliconFlow.CompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SiliconFlow.ChatCompletionChoicesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SiliconFlow.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.OneOf<string, global::System.Collections.Generic.List<global::SiliconFlow.ChatCompletionRequestUserMessageContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SiliconFlow.ChatCompletionRequestUserMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SiliconFlow.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SiliconFlow.ImagesGenerationResponseImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SiliconFlow.RetrieveAListOfModelsResponseDataItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}