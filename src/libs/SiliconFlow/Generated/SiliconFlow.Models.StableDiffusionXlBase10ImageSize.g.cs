
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// Default Value: 1024x1024
    /// </summary>
    public enum StableDiffusionXlBase10ImageSize
    {
        /// <summary>
        /// 
        /// </summary>
        x1024x1024,
        /// <summary>
        /// 
        /// </summary>
        x720x1280,
        /// <summary>
        /// 
        /// </summary>
        x720x1440,
        /// <summary>
        /// 
        /// </summary>
        x768x1024,
        /// <summary>
        /// 
        /// </summary>
        x960x1280,
        /// <summary>
        /// 
        /// </summary>
        Others,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StableDiffusionXlBase10ImageSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StableDiffusionXlBase10ImageSize value)
        {
            return value switch
            {
                StableDiffusionXlBase10ImageSize.x1024x1024 => "1024x1024",
                StableDiffusionXlBase10ImageSize.x720x1280 => "720x1280",
                StableDiffusionXlBase10ImageSize.x720x1440 => "720x1440",
                StableDiffusionXlBase10ImageSize.x768x1024 => "768x1024",
                StableDiffusionXlBase10ImageSize.x960x1280 => "960x1280",
                StableDiffusionXlBase10ImageSize.Others => "others",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StableDiffusionXlBase10ImageSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => StableDiffusionXlBase10ImageSize.x1024x1024,
                "720x1280" => StableDiffusionXlBase10ImageSize.x720x1280,
                "720x1440" => StableDiffusionXlBase10ImageSize.x720x1440,
                "768x1024" => StableDiffusionXlBase10ImageSize.x768x1024,
                "960x1280" => StableDiffusionXlBase10ImageSize.x960x1280,
                "others" => StableDiffusionXlBase10ImageSize.Others,
                _ => null,
            };
        }
    }
}