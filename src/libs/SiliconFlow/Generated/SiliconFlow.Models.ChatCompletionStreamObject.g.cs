
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionStreamObject
    {
        /// <summary>
        /// 
        /// </summary>
        ChatCompletionChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionStreamObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionStreamObject value)
        {
            return value switch
            {
                ChatCompletionStreamObject.ChatCompletionChunk => "chat.completion.chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionStreamObject? ToEnum(string value)
        {
            return value switch
            {
                "chat.completion.chunk" => ChatCompletionStreamObject.ChatCompletionChunk,
                _ => null,
            };
        }
    }
}