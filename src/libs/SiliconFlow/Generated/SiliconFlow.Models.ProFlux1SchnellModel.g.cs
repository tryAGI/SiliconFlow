
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// Default Value: Pro/black-forest-labs/FLUX.1-schnell
    /// </summary>
    public enum ProFlux1SchnellModel
    {
        /// <summary>
        /// 
        /// </summary>
        ProBlackForestLabsFlux1Schnell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProFlux1SchnellModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProFlux1SchnellModel value)
        {
            return value switch
            {
                ProFlux1SchnellModel.ProBlackForestLabsFlux1Schnell => "Pro/black-forest-labs/FLUX.1-schnell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProFlux1SchnellModel? ToEnum(string value)
        {
            return value switch
            {
                "Pro/black-forest-labs/FLUX.1-schnell" => ProFlux1SchnellModel.ProBlackForestLabsFlux1Schnell,
                _ => null,
            };
        }
    }
}