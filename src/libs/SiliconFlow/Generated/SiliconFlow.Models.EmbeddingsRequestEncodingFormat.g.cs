
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// "The format to return the embeddings in. Can be either `float` or [`base64`](https://pypi.org/project/pybase64/). 返回嵌入的格式。可以是 float 或 [`base64`](https://pypi.org/project/pybase64/)."<br/>
    /// Default Value: float<br/>
    /// Example: float
    /// </summary>
    public enum EmbeddingsRequestEncodingFormat
    {
        /// <summary>
        /// //pypi.org/project/pybase64/). 返回嵌入的格式。可以是 float 或 [`base64`](https://pypi.org/project/pybase64/)."
        /// </summary>
        Base64,
        /// <summary>
        /// //pypi.org/project/pybase64/). 返回嵌入的格式。可以是 float 或 [`base64`](https://pypi.org/project/pybase64/)."
        /// </summary>
        Float,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsRequestEncodingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsRequestEncodingFormat value)
        {
            return value switch
            {
                EmbeddingsRequestEncodingFormat.Base64 => "base64",
                EmbeddingsRequestEncodingFormat.Float => "float",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsRequestEncodingFormat? ToEnum(string value)
        {
            return value switch
            {
                "base64" => EmbeddingsRequestEncodingFormat.Base64,
                "float" => EmbeddingsRequestEncodingFormat.Float,
                _ => null,
            };
        }
    }
}