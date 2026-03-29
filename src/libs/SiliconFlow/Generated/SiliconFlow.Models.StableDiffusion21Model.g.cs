
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// Default Value: stabilityai/stable-diffusion-2-1
    /// </summary>
    public enum StableDiffusion21Model
    {
        /// <summary>
        /// 
        /// </summary>
        StabilityaiStableDiffusion21,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StableDiffusion21ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StableDiffusion21Model value)
        {
            return value switch
            {
                StableDiffusion21Model.StabilityaiStableDiffusion21 => "stabilityai/stable-diffusion-2-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StableDiffusion21Model? ToEnum(string value)
        {
            return value switch
            {
                "stabilityai/stable-diffusion-2-1" => StableDiffusion21Model.StabilityaiStableDiffusion21,
                _ => null,
            };
        }
    }
}