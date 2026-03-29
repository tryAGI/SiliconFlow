
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// Default Value: 512x512
    /// </summary>
    public enum StableDiffusion21ImageSize
    {
        /// <summary>
        /// 
        /// </summary>
        x1024x576,
        /// <summary>
        /// 
        /// </summary>
        x512x1024,
        /// <summary>
        /// 
        /// </summary>
        x512x512,
        /// <summary>
        /// 
        /// </summary>
        x576x1024,
        /// <summary>
        /// 
        /// </summary>
        x768x1024,
        /// <summary>
        /// 
        /// </summary>
        x768x512,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StableDiffusion21ImageSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StableDiffusion21ImageSize value)
        {
            return value switch
            {
                StableDiffusion21ImageSize.x1024x576 => "1024x576",
                StableDiffusion21ImageSize.x512x1024 => "512x1024",
                StableDiffusion21ImageSize.x512x512 => "512x512",
                StableDiffusion21ImageSize.x576x1024 => "576x1024",
                StableDiffusion21ImageSize.x768x1024 => "768x1024",
                StableDiffusion21ImageSize.x768x512 => "768x512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StableDiffusion21ImageSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x576" => StableDiffusion21ImageSize.x1024x576,
                "512x1024" => StableDiffusion21ImageSize.x512x1024,
                "512x512" => StableDiffusion21ImageSize.x512x512,
                "576x1024" => StableDiffusion21ImageSize.x576x1024,
                "768x1024" => StableDiffusion21ImageSize.x768x1024,
                "768x512" => StableDiffusion21ImageSize.x768x512,
                _ => null,
            };
        }
    }
}