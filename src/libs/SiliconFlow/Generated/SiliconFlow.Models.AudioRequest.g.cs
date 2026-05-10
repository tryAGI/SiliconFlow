
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioRequest
    {
        /// <summary>
        /// The audio file object (not file name) to transcribe<br/>
        /// Example: /path/to/audio.mp3
        /// </summary>
        /// <example>/path/to/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The audio file object (not file name) to transcribe<br/>
        /// Example: /path/to/audio.mp3
        /// </summary>
        /// <example>/path/to/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The name of the audio model to use.<br/>
        /// Example: FunAudioLLM/SenseVoiceSmall
        /// </summary>
        /// <example>FunAudioLLM/SenseVoiceSmall</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.AudioRequestModelJsonConverter))]
        public global::SiliconFlow.AudioRequestModel Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// The audio file object (not file name) to transcribe<br/>
        /// Example: /path/to/audio.mp3
        /// </param>
        /// <param name="filename">
        /// The audio file object (not file name) to transcribe<br/>
        /// Example: /path/to/audio.mp3
        /// </param>
        /// <param name="model">
        /// The name of the audio model to use.<br/>
        /// Example: FunAudioLLM/SenseVoiceSmall
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioRequest(
            byte[] file,
            string filename,
            global::SiliconFlow.AudioRequestModel model)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioRequest" /> class.
        /// </summary>
        public AudioRequest()
        {
        }

    }
}