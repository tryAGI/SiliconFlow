
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// Default Value: 1024x1024
    /// </summary>
    public enum Flux1SchnellImageSize
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
    public static class Flux1SchnellImageSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Flux1SchnellImageSize value)
        {
            return value switch
            {
                Flux1SchnellImageSize.x1024x1024 => "1024x1024",
                Flux1SchnellImageSize.x1024x576 => "1024x576",
                Flux1SchnellImageSize.x512x1024 => "512x1024",
                Flux1SchnellImageSize.x576x1024 => "576x1024",
                Flux1SchnellImageSize.x768x1024 => "768x1024",
                Flux1SchnellImageSize.x768x512 => "768x512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Flux1SchnellImageSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => Flux1SchnellImageSize.x1024x1024,
                "1024x576" => Flux1SchnellImageSize.x1024x576,
                "512x1024" => Flux1SchnellImageSize.x512x1024,
                "576x1024" => Flux1SchnellImageSize.x576x1024,
                "768x1024" => Flux1SchnellImageSize.x768x1024,
                "768x512" => Flux1SchnellImageSize.x768x512,
                _ => null,
            };
        }
    }
}