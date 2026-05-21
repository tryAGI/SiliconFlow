
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Flux1Schnell
    {
        /// <summary>
        /// Default Value: black-forest-labs/FLUX.1-schnell
        /// </summary>
        /// <default>global::SiliconFlow.Flux1SchnellModel.BlackForestLabsFlux1Schnell</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.Flux1SchnellModelJsonConverter))]
        public global::SiliconFlow.Flux1SchnellModel Model { get; set; } = global::SiliconFlow.Flux1SchnellModel.BlackForestLabsFlux1Schnell;

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
        /// <default>global::SiliconFlow.Flux1SchnellImageSize.x1024x1024</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.Flux1SchnellImageSizeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SiliconFlow.Flux1SchnellImageSize ImageSize { get; set; } = global::SiliconFlow.Flux1SchnellImageSize.x1024x1024;

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
        /// Initializes a new instance of the <see cref="Flux1Schnell" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Default Value: an island near sea, with seagulls, moon shining over the sea, light house, boats int he background, fish flying over the sea
        /// </param>
        /// <param name="imageSize">
        /// Default Value: 1024x1024
        /// </param>
        /// <param name="seed"></param>
        /// <param name="model">
        /// Default Value: black-forest-labs/FLUX.1-schnell
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Flux1Schnell(
            string prompt,
            global::SiliconFlow.Flux1SchnellImageSize imageSize,
            long? seed,
            global::SiliconFlow.Flux1SchnellModel model = global::SiliconFlow.Flux1SchnellModel.BlackForestLabsFlux1Schnell)
        {
            this.Model = model;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ImageSize = imageSize;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux1Schnell" /> class.
        /// </summary>
        public Flux1Schnell()
        {
        }

    }
}