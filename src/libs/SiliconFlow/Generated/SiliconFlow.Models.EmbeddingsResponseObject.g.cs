
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// The object type, which is always "list".
    /// </summary>
    public enum EmbeddingsResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        list,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsResponseObject value)
        {
            return value switch
            {
                EmbeddingsResponseObject.list => "[list]",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "[list]" => EmbeddingsResponseObject.list,
                _ => null,
            };
        }
    }
}