
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// Default Value: 1024x1024
    /// </summary>
    public enum Flux1DevImageSize
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
    public static class Flux1DevImageSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Flux1DevImageSize value)
        {
            return value switch
            {
                Flux1DevImageSize.x1024x1024 => "1024x1024",
                Flux1DevImageSize.x720x1280 => "720x1280",
                Flux1DevImageSize.x720x1440 => "720x1440",
                Flux1DevImageSize.x768x1024 => "768x1024",
                Flux1DevImageSize.x960x1280 => "960x1280",
                Flux1DevImageSize.Others => "others",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Flux1DevImageSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => Flux1DevImageSize.x1024x1024,
                "720x1280" => Flux1DevImageSize.x720x1280,
                "720x1440" => Flux1DevImageSize.x720x1440,
                "768x1024" => Flux1DevImageSize.x768x1024,
                "960x1280" => Flux1DevImageSize.x960x1280,
                "others" => Flux1DevImageSize.Others,
                _ => null,
            };
        }
    }
}