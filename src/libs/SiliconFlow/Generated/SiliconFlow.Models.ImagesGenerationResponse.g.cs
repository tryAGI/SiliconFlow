
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImagesGenerationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::SiliconFlow.ImagesGenerationResponseImage>? Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timings")]
        public global::SiliconFlow.ImagesGenerationResponseTimings? Timings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesGenerationResponse" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="timings"></param>
        /// <param name="seed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagesGenerationResponse(
            global::System.Collections.Generic.IList<global::SiliconFlow.ImagesGenerationResponseImage>? images,
            global::SiliconFlow.ImagesGenerationResponseTimings? timings,
            int? seed)
        {
            this.Images = images;
            this.Timings = timings;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesGenerationResponse" /> class.
        /// </summary>
        public ImagesGenerationResponse()
        {
        }
    }
}