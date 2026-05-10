
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImagesGenerationResponseTimings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference")]
        public float? Inference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesGenerationResponseTimings" /> class.
        /// </summary>
        /// <param name="inference"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagesGenerationResponseTimings(
            float? inference)
        {
            this.Inference = inference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesGenerationResponseTimings" /> class.
        /// </summary>
        public ImagesGenerationResponseTimings()
        {
        }

    }
}