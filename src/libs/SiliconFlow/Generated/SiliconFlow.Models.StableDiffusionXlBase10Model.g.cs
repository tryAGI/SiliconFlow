
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// Default Value: stabilityai/stable-diffusion-xl-base-1.0
    /// </summary>
    public enum StableDiffusionXlBase10Model
    {
        /// <summary>
        /// 
        /// </summary>
        StabilityaiStableDiffusionXlBase10,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StableDiffusionXlBase10ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StableDiffusionXlBase10Model value)
        {
            return value switch
            {
                StableDiffusionXlBase10Model.StabilityaiStableDiffusionXlBase10 => "stabilityai/stable-diffusion-xl-base-1.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StableDiffusionXlBase10Model? ToEnum(string value)
        {
            return value switch
            {
                "stabilityai/stable-diffusion-xl-base-1.0" => StableDiffusionXlBase10Model.StabilityaiStableDiffusionXlBase10,
                _ => null,
            };
        }
    }
}