
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadAudioVoiceResponse
    {
        /// <summary>
        /// Example: speech:your-voice-name:cm04pf7az00061413w7kz5qxs:mjtkgbyuunvtybnsvbxd
        /// </summary>
        /// <example>speech:your-voice-name:cm04pf7az00061413w7kz5qxs:mjtkgbyuunvtybnsvbxd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAudioVoiceResponse" /> class.
        /// </summary>
        /// <param name="uri">
        /// Example: speech:your-voice-name:cm04pf7az00061413w7kz5qxs:mjtkgbyuunvtybnsvbxd
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadAudioVoiceResponse(
            string? uri)
        {
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAudioVoiceResponse" /> class.
        /// </summary>
        public UploadAudioVoiceResponse()
        {
        }
    }
}