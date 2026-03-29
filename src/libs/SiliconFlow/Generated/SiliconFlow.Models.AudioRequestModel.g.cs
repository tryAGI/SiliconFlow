
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// The name of the audio model to use.<br/>
    /// Example: FunAudioLLM/SenseVoiceSmall
    /// </summary>
    public enum AudioRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        FunAudioLLMSenseVoiceSmall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioRequestModel value)
        {
            return value switch
            {
                AudioRequestModel.FunAudioLLMSenseVoiceSmall => "FunAudioLLM/SenseVoiceSmall",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "FunAudioLLM/SenseVoiceSmall" => AudioRequestModel.FunAudioLLMSenseVoiceSmall,
                _ => null,
            };
        }
    }
}