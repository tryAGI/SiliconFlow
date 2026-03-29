
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 预置音色的模型名称<br/>
    /// Example: fishaudio/fish-speech-1.4
    /// </summary>
    public enum UploadAudioVoiceRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        FishaudioFishSpeech14,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadAudioVoiceRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadAudioVoiceRequestModel value)
        {
            return value switch
            {
                UploadAudioVoiceRequestModel.FishaudioFishSpeech14 => "fishaudio/fish-speech-1.4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadAudioVoiceRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "fishaudio/fish-speech-1.4" => UploadAudioVoiceRequestModel.FishaudioFishSpeech14,
                _ => null,
            };
        }
    }
}