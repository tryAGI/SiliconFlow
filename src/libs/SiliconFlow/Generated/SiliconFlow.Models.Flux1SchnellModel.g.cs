
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// Default Value: black-forest-labs/FLUX.1-schnell
    /// </summary>
    public enum Flux1SchnellModel
    {
        /// <summary>
        /// 
        /// </summary>
        BlackForestLabsFlux1Schnell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Flux1SchnellModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Flux1SchnellModel value)
        {
            return value switch
            {
                Flux1SchnellModel.BlackForestLabsFlux1Schnell => "black-forest-labs/FLUX.1-schnell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Flux1SchnellModel? ToEnum(string value)
        {
            return value switch
            {
                "black-forest-labs/FLUX.1-schnell" => Flux1SchnellModel.BlackForestLabsFlux1Schnell,
                _ => null,
            };
        }
    }
}