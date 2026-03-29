
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// Default Value: stabilityai/stable-diffusion-3-5-large
    /// </summary>
    public enum StableDiffusion35LargeModel
    {
        /// <summary>
        /// 
        /// </summary>
        StabilityaiStableDiffusion35Large,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StableDiffusion35LargeModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StableDiffusion35LargeModel value)
        {
            return value switch
            {
                StableDiffusion35LargeModel.StabilityaiStableDiffusion35Large => "stabilityai/stable-diffusion-3-5-large",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StableDiffusion35LargeModel? ToEnum(string value)
        {
            return value switch
            {
                "stabilityai/stable-diffusion-3-5-large" => StableDiffusion35LargeModel.StabilityaiStableDiffusion35Large,
                _ => null,
            };
        }
    }
}