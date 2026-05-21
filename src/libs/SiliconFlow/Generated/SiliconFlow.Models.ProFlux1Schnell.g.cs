
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProFlux1Schnell
    {
        /// <summary>
        /// Default Value: Pro/black-forest-labs/FLUX.1-schnell
        /// </summary>
        /// <default>global::SiliconFlow.ProFlux1SchnellModel.ProBlackForestLabsFlux1Schnell</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.ProFlux1SchnellModelJsonConverter))]
        public global::SiliconFlow.ProFlux1SchnellModel Model { get; set; } = global::SiliconFlow.ProFlux1SchnellModel.ProBlackForestLabsFlux1Schnell;

        /// <summary>
        /// Default Value: an island near sea, with seagulls, moon shining over the sea, light house, boats int he background, fish flying over the sea
        /// </summary>
        /// <default>"an island near sea, with seagulls, moon shining over the sea, light house, boats int he background, fish flying over the sea"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; } = "an island near sea, with seagulls, moon shining over the sea, light house, boats int he background, fish flying over the sea";

        /// <summary>
        /// Default Value: 1024x1024
        /// </summary>
        /// <default>global::SiliconFlow.ProFlux1SchnellImageSize.x1024x1024</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.ProFlux1SchnellImageSizeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SiliconFlow.ProFlux1SchnellImageSize ImageSize { get; set; } = global::SiliconFlow.ProFlux1SchnellImageSize.x1024x1024;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProFlux1Schnell" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Default Value: an island near sea, with seagulls, moon shining over the sea, light house, boats int he background, fish flying over the sea
        /// </param>
        /// <param name="imageSize">
        /// Default Value: 1024x1024
        /// </param>
        /// <param name="seed"></param>
        /// <param name="model">
        /// Default Value: Pro/black-forest-labs/FLUX.1-schnell
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProFlux1Schnell(
            string prompt,
            global::SiliconFlow.ProFlux1SchnellImageSize imageSize,
            long? seed,
            global::SiliconFlow.ProFlux1SchnellModel model = global::SiliconFlow.ProFlux1SchnellModel.ProBlackForestLabsFlux1Schnell)
        {
            this.Model = model;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ImageSize = imageSize;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProFlux1Schnell" /> class.
        /// </summary>
        public ProFlux1Schnell()
        {
        }

    }
}