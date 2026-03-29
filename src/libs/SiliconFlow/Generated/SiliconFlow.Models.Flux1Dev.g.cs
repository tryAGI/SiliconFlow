
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Flux1Dev
    {
        /// <summary>
        /// The name of the model to query.<br/>
        /// Default Value: black-forest-labs/FLUX.1-dev
        /// </summary>
        /// <default>global::SiliconFlow.Flux1DevModel.BlackForestLabsFlux1Dev</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.Flux1DevModelJsonConverter))]
        public global::SiliconFlow.Flux1DevModel Model { get; set; } = global::SiliconFlow.Flux1DevModel.BlackForestLabsFlux1Dev;

        /// <summary>
        /// Default Value: a man
        /// </summary>
        /// <default>"a man"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; } = "a man";

        /// <summary>
        /// Default Value: 1024x1024
        /// </summary>
        /// <default>global::SiliconFlow.Flux1DevImageSize.x1024x1024</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.Flux1DevImageSizeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SiliconFlow.Flux1DevImageSize ImageSize { get; set; } = global::SiliconFlow.Flux1DevImageSize.x1024x1024;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_inference_steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumInferenceSteps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux1Dev" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Default Value: a man
        /// </param>
        /// <param name="imageSize">
        /// Default Value: 1024x1024
        /// </param>
        /// <param name="numInferenceSteps">
        /// Default Value: 20
        /// </param>
        /// <param name="seed"></param>
        /// <param name="model">
        /// The name of the model to query.<br/>
        /// Default Value: black-forest-labs/FLUX.1-dev
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Flux1Dev(
            string prompt,
            global::SiliconFlow.Flux1DevImageSize imageSize,
            int numInferenceSteps,
            long? seed,
            global::SiliconFlow.Flux1DevModel model = global::SiliconFlow.Flux1DevModel.BlackForestLabsFlux1Dev)
        {
            this.Model = model;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ImageSize = imageSize;
            this.Seed = seed;
            this.NumInferenceSteps = numInferenceSteps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux1Dev" /> class.
        /// </summary>
        public Flux1Dev()
        {
        }
    }
}