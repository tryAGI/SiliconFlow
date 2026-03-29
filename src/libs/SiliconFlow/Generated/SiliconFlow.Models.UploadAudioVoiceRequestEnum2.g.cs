
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadAudioVoiceRequestEnum2
    {
        /// <summary>
        /// 待上传的文件<br/>
        /// Example: /path/to/audio.mp3
        /// </summary>
        /// <example>/path/to/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// 待上传的文件<br/>
        /// Example: /path/to/audio.mp3
        /// </summary>
        /// <example>/path/to/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAudioVoiceRequestEnum2" /> class.
        /// </summary>
        /// <param name="file">
        /// 待上传的文件<br/>
        /// Example: /path/to/audio.mp3
        /// </param>
        /// <param name="filename">
        /// 待上传的文件<br/>
        /// Example: /path/to/audio.mp3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadAudioVoiceRequestEnum2(
            byte[]? file,
            string? filename)
        {
            this.File = file;
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAudioVoiceRequestEnum2" /> class.
        /// </summary>
        public UploadAudioVoiceRequestEnum2()
        {
        }
    }
}