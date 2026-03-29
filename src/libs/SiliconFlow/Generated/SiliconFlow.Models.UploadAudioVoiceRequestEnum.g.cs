
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadAudioVoiceRequestEnum
    {
        /// <summary>
        /// 使用 base64 编码的音频文件，头部为：`data:audio/mpeg;base64,`格式<br/>
        /// Example: data:audio/mpeg;base64,aGVsbG93b3JsZA==
        /// </summary>
        /// <example>data:audio/mpeg;base64,aGVsbG93b3JsZA==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAudioVoiceRequestEnum" /> class.
        /// </summary>
        /// <param name="audio">
        /// 使用 base64 编码的音频文件，头部为：`data:audio/mpeg;base64,`格式<br/>
        /// Example: data:audio/mpeg;base64,aGVsbG93b3JsZA==
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadAudioVoiceRequestEnum(
            string? audio)
        {
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAudioVoiceRequestEnum" /> class.
        /// </summary>
        public UploadAudioVoiceRequestEnum()
        {
        }
    }
}