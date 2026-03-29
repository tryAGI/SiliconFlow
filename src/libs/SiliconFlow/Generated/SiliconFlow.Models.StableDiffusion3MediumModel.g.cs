
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// Default Value: stabilityai/stable-diffusion-3-medium
    /// </summary>
    public enum StableDiffusion3MediumModel
    {
        /// <summary>
        /// 
        /// </summary>
        StabilityaiStableDiffusion3Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StableDiffusion3MediumModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StableDiffusion3MediumModel value)
        {
            return value switch
            {
                StableDiffusion3MediumModel.StabilityaiStableDiffusion3Medium => "stabilityai/stable-diffusion-3-medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StableDiffusion3MediumModel? ToEnum(string value)
        {
            return value switch
            {
                "stabilityai/stable-diffusion-3-medium" => StableDiffusion3MediumModel.StabilityaiStableDiffusion3Medium,
                _ => null,
            };
        }
    }
}