
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public enum RetrieveAListOfModelsType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetrieveAListOfModelsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetrieveAListOfModelsType value)
        {
            return value switch
            {
                RetrieveAListOfModelsType.Audio => "audio",
                RetrieveAListOfModelsType.Image => "image",
                RetrieveAListOfModelsType.Text => "text",
                RetrieveAListOfModelsType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetrieveAListOfModelsType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => RetrieveAListOfModelsType.Audio,
                "image" => RetrieveAListOfModelsType.Image,
                "text" => RetrieveAListOfModelsType.Text,
                "video" => RetrieveAListOfModelsType.Video,
                _ => null,
            };
        }
    }
}