
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// Current available TTS models: `fishaudio/fish-speech-1.4`<br/>
    /// Example: fishaudio/fish-speech-1.4
    /// </summary>
    public enum CreateSpeechRequestModel
    {
        /// <summary>
        /// `fishaudio/fish-speech-1.4`
        /// </summary>
        FishaudioFishSpeech14,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechRequestModel value)
        {
            return value switch
            {
                CreateSpeechRequestModel.FishaudioFishSpeech14 => "fishaudio/fish-speech-1.4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "fishaudio/fish-speech-1.4" => CreateSpeechRequestModel.FishaudioFishSpeech14,
                _ => null,
            };
        }
    }
}