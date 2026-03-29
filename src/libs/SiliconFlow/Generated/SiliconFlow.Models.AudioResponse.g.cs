
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// Represents a transcription response returned by model, based on the provided input.
    /// </summary>
    public sealed partial class AudioResponse
    {
        /// <summary>
        /// The transcribed text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioResponse" /> class.
        /// </summary>
        /// <param name="text">
        /// The transcribed text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioResponse(
            string text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioResponse" /> class.
        /// </summary>
        public AudioResponse()
        {
        }
    }
}