
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// The voice to use when generating the audio. Supported voices are `fishaudio/fish-speech-1.4:alex`, `fishaudio/fish-speech-1.4:anna`, `fishaudio/fish-speech-1.4:bella`, `fishaudio/fish-speech-1.4:benjamin`, `fishaudio/fish-speech-1.4:charles`, `fishaudio/fish-speech-1.4:claire`, `fishaudio/fish-speech-1.4:david`, `fishaudio/fish-speech-1.4:diana`. Previews of the voices are available in the [Text to speech guide](/capabilities/text-to-speech).
    /// </summary>
    public enum CreateSpeechRequestVoice
    {
        /// <summary>
        /// alex`, `fishaudio/fish-speech-1.4:anna`, `fishaudio/fish-speech-1.4:bella`, `fishaudio/fish-speech-1.4:benjamin`, `fishaudio/fish-speech-1.4:charles`, `fishaudio/fish-speech-1.4:claire`, `fishaudio/fish-speech-1.4:david`, `fishaudio/fish-speech-1.4:diana`. Previews of the voices are available in the [Text to speech guide](/capabilities/text-to-speech).
        /// </summary>
        FishaudioFishSpeech14_alex,
        /// <summary>
        /// alex`, `fishaudio/fish-speech-1.4:anna`, `fishaudio/fish-speech-1.4:bella`, `fishaudio/fish-speech-1.4:benjamin`, `fishaudio/fish-speech-1.4:charles`, `fishaudio/fish-speech-1.4:claire`, `fishaudio/fish-speech-1.4:david`, `fishaudio/fish-speech-1.4:diana`. Previews of the voices are available in the [Text to speech guide](/capabilities/text-to-speech).
        /// </summary>
        FishaudioFishSpeech14_anna,
        /// <summary>
        /// alex`, `fishaudio/fish-speech-1.4:anna`, `fishaudio/fish-speech-1.4:bella`, `fishaudio/fish-speech-1.4:benjamin`, `fishaudio/fish-speech-1.4:charles`, `fishaudio/fish-speech-1.4:claire`, `fishaudio/fish-speech-1.4:david`, `fishaudio/fish-speech-1.4:diana`. Previews of the voices are available in the [Text to speech guide](/capabilities/text-to-speech).
        /// </summary>
        FishaudioFishSpeech14_bella,
        /// <summary>
        /// alex`, `fishaudio/fish-speech-1.4:anna`, `fishaudio/fish-speech-1.4:bella`, `fishaudio/fish-speech-1.4:benjamin`, `fishaudio/fish-speech-1.4:charles`, `fishaudio/fish-speech-1.4:claire`, `fishaudio/fish-speech-1.4:david`, `fishaudio/fish-speech-1.4:diana`. Previews of the voices are available in the [Text to speech guide](/capabilities/text-to-speech).
        /// </summary>
        FishaudioFishSpeech14_benjamin,
        /// <summary>
        /// alex`, `fishaudio/fish-speech-1.4:anna`, `fishaudio/fish-speech-1.4:bella`, `fishaudio/fish-speech-1.4:benjamin`, `fishaudio/fish-speech-1.4:charles`, `fishaudio/fish-speech-1.4:claire`, `fishaudio/fish-speech-1.4:david`, `fishaudio/fish-speech-1.4:diana`. Previews of the voices are available in the [Text to speech guide](/capabilities/text-to-speech).
        /// </summary>
        FishaudioFishSpeech14_charles,
        /// <summary>
        /// alex`, `fishaudio/fish-speech-1.4:anna`, `fishaudio/fish-speech-1.4:bella`, `fishaudio/fish-speech-1.4:benjamin`, `fishaudio/fish-speech-1.4:charles`, `fishaudio/fish-speech-1.4:claire`, `fishaudio/fish-speech-1.4:david`, `fishaudio/fish-speech-1.4:diana`. Previews of the voices are available in the [Text to speech guide](/capabilities/text-to-speech).
        /// </summary>
        FishaudioFishSpeech14_claire,
        /// <summary>
        /// alex`, `fishaudio/fish-speech-1.4:anna`, `fishaudio/fish-speech-1.4:bella`, `fishaudio/fish-speech-1.4:benjamin`, `fishaudio/fish-speech-1.4:charles`, `fishaudio/fish-speech-1.4:claire`, `fishaudio/fish-speech-1.4:david`, `fishaudio/fish-speech-1.4:diana`. Previews of the voices are available in the [Text to speech guide](/capabilities/text-to-speech).
        /// </summary>
        FishaudioFishSpeech14_david,
        /// <summary>
        /// alex`, `fishaudio/fish-speech-1.4:anna`, `fishaudio/fish-speech-1.4:bella`, `fishaudio/fish-speech-1.4:benjamin`, `fishaudio/fish-speech-1.4:charles`, `fishaudio/fish-speech-1.4:claire`, `fishaudio/fish-speech-1.4:david`, `fishaudio/fish-speech-1.4:diana`. Previews of the voices are available in the [Text to speech guide](/capabilities/text-to-speech).
        /// </summary>
        FishaudioFishSpeech14_diana,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechRequestVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechRequestVoice value)
        {
            return value switch
            {
                CreateSpeechRequestVoice.FishaudioFishSpeech14_alex => "fishaudio/fish-speech-1.4:alex",
                CreateSpeechRequestVoice.FishaudioFishSpeech14_anna => "fishaudio/fish-speech-1.4:anna",
                CreateSpeechRequestVoice.FishaudioFishSpeech14_bella => "fishaudio/fish-speech-1.4:bella",
                CreateSpeechRequestVoice.FishaudioFishSpeech14_benjamin => "fishaudio/fish-speech-1.4:benjamin",
                CreateSpeechRequestVoice.FishaudioFishSpeech14_charles => "fishaudio/fish-speech-1.4:charles",
                CreateSpeechRequestVoice.FishaudioFishSpeech14_claire => "fishaudio/fish-speech-1.4:claire",
                CreateSpeechRequestVoice.FishaudioFishSpeech14_david => "fishaudio/fish-speech-1.4:david",
                CreateSpeechRequestVoice.FishaudioFishSpeech14_diana => "fishaudio/fish-speech-1.4:diana",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechRequestVoice? ToEnum(string value)
        {
            return value switch
            {
                "fishaudio/fish-speech-1.4:alex" => CreateSpeechRequestVoice.FishaudioFishSpeech14_alex,
                "fishaudio/fish-speech-1.4:anna" => CreateSpeechRequestVoice.FishaudioFishSpeech14_anna,
                "fishaudio/fish-speech-1.4:bella" => CreateSpeechRequestVoice.FishaudioFishSpeech14_bella,
                "fishaudio/fish-speech-1.4:benjamin" => CreateSpeechRequestVoice.FishaudioFishSpeech14_benjamin,
                "fishaudio/fish-speech-1.4:charles" => CreateSpeechRequestVoice.FishaudioFishSpeech14_charles,
                "fishaudio/fish-speech-1.4:claire" => CreateSpeechRequestVoice.FishaudioFishSpeech14_claire,
                "fishaudio/fish-speech-1.4:david" => CreateSpeechRequestVoice.FishaudioFishSpeech14_david,
                "fishaudio/fish-speech-1.4:diana" => CreateSpeechRequestVoice.FishaudioFishSpeech14_diana,
                _ => null,
            };
        }
    }
}