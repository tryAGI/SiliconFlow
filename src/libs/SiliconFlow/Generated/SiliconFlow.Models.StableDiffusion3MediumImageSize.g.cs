
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// Default Value: 1024x1024
    /// </summary>
    public enum StableDiffusion3MediumImageSize
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
    public static class StableDiffusion3MediumImageSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StableDiffusion3MediumImageSize value)
        {
            return value switch
            {
                StableDiffusion3MediumImageSize.x1024x1024 => "1024x1024",
                StableDiffusion3MediumImageSize.x720x1280 => "720x1280",
                StableDiffusion3MediumImageSize.x720x1440 => "720x1440",
                StableDiffusion3MediumImageSize.x768x1024 => "768x1024",
                StableDiffusion3MediumImageSize.x960x1280 => "960x1280",
                StableDiffusion3MediumImageSize.Others => "others",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StableDiffusion3MediumImageSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => StableDiffusion3MediumImageSize.x1024x1024,
                "720x1280" => StableDiffusion3MediumImageSize.x720x1280,
                "720x1440" => StableDiffusion3MediumImageSize.x720x1440,
                "768x1024" => StableDiffusion3MediumImageSize.x768x1024,
                "960x1280" => StableDiffusion3MediumImageSize.x960x1280,
                "others" => StableDiffusion3MediumImageSize.Others,
                _ => null,
            };
        }
    }
}