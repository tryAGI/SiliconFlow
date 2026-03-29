
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// Default Value: 1024x1024
    /// </summary>
    public enum StableDiffusion35LargeImageSize
    {
        /// <summary>
        /// 
        /// </summary>
        x1024x1024,
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
    public static class StableDiffusion35LargeImageSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StableDiffusion35LargeImageSize value)
        {
            return value switch
            {
                StableDiffusion35LargeImageSize.x1024x1024 => "1024x1024",
                StableDiffusion35LargeImageSize.x1024x576 => "1024x576",
                StableDiffusion35LargeImageSize.x512x1024 => "512x1024",
                StableDiffusion35LargeImageSize.x576x1024 => "576x1024",
                StableDiffusion35LargeImageSize.x768x1024 => "768x1024",
                StableDiffusion35LargeImageSize.x768x512 => "768x512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StableDiffusion35LargeImageSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => StableDiffusion35LargeImageSize.x1024x1024,
                "1024x576" => StableDiffusion35LargeImageSize.x1024x576,
                "512x1024" => StableDiffusion35LargeImageSize.x512x1024,
                "576x1024" => StableDiffusion35LargeImageSize.x576x1024,
                "768x1024" => StableDiffusion35LargeImageSize.x768x1024,
                "768x512" => StableDiffusion35LargeImageSize.x768x512,
                _ => null,
            };
        }
    }
}