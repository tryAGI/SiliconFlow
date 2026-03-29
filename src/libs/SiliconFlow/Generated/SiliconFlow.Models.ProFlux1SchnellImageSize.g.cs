
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// Default Value: 1024x1024
    /// </summary>
    public enum ProFlux1SchnellImageSize
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
    public static class ProFlux1SchnellImageSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProFlux1SchnellImageSize value)
        {
            return value switch
            {
                ProFlux1SchnellImageSize.x1024x1024 => "1024x1024",
                ProFlux1SchnellImageSize.x720x1280 => "720x1280",
                ProFlux1SchnellImageSize.x720x1440 => "720x1440",
                ProFlux1SchnellImageSize.x768x1024 => "768x1024",
                ProFlux1SchnellImageSize.x960x1280 => "960x1280",
                ProFlux1SchnellImageSize.Others => "others",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProFlux1SchnellImageSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => ProFlux1SchnellImageSize.x1024x1024,
                "720x1280" => ProFlux1SchnellImageSize.x720x1280,
                "720x1440" => ProFlux1SchnellImageSize.x720x1440,
                "768x1024" => ProFlux1SchnellImageSize.x768x1024,
                "960x1280" => ProFlux1SchnellImageSize.x960x1280,
                "others" => ProFlux1SchnellImageSize.Others,
                _ => null,
            };
        }
    }
}