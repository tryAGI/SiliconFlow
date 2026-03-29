
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// The name of the model to query.<br/>
    /// Default Value: black-forest-labs/FLUX.1-dev
    /// </summary>
    public enum Flux1DevModel
    {
        /// <summary>
        /// 
        /// </summary>
        BlackForestLabsFlux1Dev,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Flux1DevModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Flux1DevModel value)
        {
            return value switch
            {
                Flux1DevModel.BlackForestLabsFlux1Dev => "black-forest-labs/FLUX.1-dev",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Flux1DevModel? ToEnum(string value)
        {
            return value switch
            {
                "black-forest-labs/FLUX.1-dev" => Flux1DevModel.BlackForestLabsFlux1Dev,
                _ => null,
            };
        }
    }
}