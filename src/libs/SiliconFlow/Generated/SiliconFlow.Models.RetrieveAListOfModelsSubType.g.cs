
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public enum RetrieveAListOfModelsSubType
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        ImageToImage,
        /// <summary>
        /// 
        /// </summary>
        Reranker,
        /// <summary>
        /// 
        /// </summary>
        SpeechToText,
        /// <summary>
        /// 
        /// </summary>
        TextToImage,
        /// <summary>
        /// 
        /// </summary>
        TextToVideo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetrieveAListOfModelsSubTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetrieveAListOfModelsSubType value)
        {
            return value switch
            {
                RetrieveAListOfModelsSubType.Chat => "chat",
                RetrieveAListOfModelsSubType.Embedding => "embedding",
                RetrieveAListOfModelsSubType.ImageToImage => "image-to-image",
                RetrieveAListOfModelsSubType.Reranker => "reranker",
                RetrieveAListOfModelsSubType.SpeechToText => "speech-to-text",
                RetrieveAListOfModelsSubType.TextToImage => "text-to-image",
                RetrieveAListOfModelsSubType.TextToVideo => "text-to-video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetrieveAListOfModelsSubType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => RetrieveAListOfModelsSubType.Chat,
                "embedding" => RetrieveAListOfModelsSubType.Embedding,
                "image-to-image" => RetrieveAListOfModelsSubType.ImageToImage,
                "reranker" => RetrieveAListOfModelsSubType.Reranker,
                "speech-to-text" => RetrieveAListOfModelsSubType.SpeechToText,
                "text-to-image" => RetrieveAListOfModelsSubType.TextToImage,
                "text-to-video" => RetrieveAListOfModelsSubType.TextToVideo,
                _ => null,
            };
        }
    }
}