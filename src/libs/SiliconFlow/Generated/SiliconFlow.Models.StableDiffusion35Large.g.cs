
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StableDiffusion35Large
    {
        /// <summary>
        /// Default Value: stabilityai/stable-diffusion-3-5-large
        /// </summary>
        /// <default>global::SiliconFlow.StableDiffusion35LargeModel.StabilityaiStableDiffusion35Large</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.StableDiffusion35LargeModelJsonConverter))]
        public global::SiliconFlow.StableDiffusion35LargeModel Model { get; set; } = global::SiliconFlow.StableDiffusion35LargeModel.StabilityaiStableDiffusion35Large;

        /// <summary>
        /// Default Value: an island near sea, with seagulls, moon shining over the sea, light house, boats int he background, fish flying over the sea
        /// </summary>
        /// <default>"an island near sea, with seagulls, moon shining over the sea, light house, boats int he background, fish flying over the sea"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; } = "an island near sea, with seagulls, moon shining over the sea, light house, boats int he background, fish flying over the sea";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Default Value: 1024x1024
        /// </summary>
        /// <default>global::SiliconFlow.StableDiffusion35LargeImageSize.x1024x1024</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.StableDiffusion35LargeImageSizeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SiliconFlow.StableDiffusion35LargeImageSize ImageSize { get; set; } = global::SiliconFlow.StableDiffusion35LargeImageSize.x1024x1024;

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BatchSize { get; set; }

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
        /// Default Value: 7.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double GuidanceScale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StableDiffusion35Large" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Default Value: an island near sea, with seagulls, moon shining over the sea, light house, boats int he background, fish flying over the sea
        /// </param>
        /// <param name="imageSize">
        /// Default Value: 1024x1024
        /// </param>
        /// <param name="batchSize">
        /// Default Value: 1
        /// </param>
        /// <param name="numInferenceSteps">
        /// Default Value: 20
        /// </param>
        /// <param name="guidanceScale">
        /// Default Value: 7.5
        /// </param>
        /// <param name="negativePrompt"></param>
        /// <param name="seed"></param>
        /// <param name="model">
        /// Default Value: stabilityai/stable-diffusion-3-5-large
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StableDiffusion35Large(
            string prompt,
            global::SiliconFlow.StableDiffusion35LargeImageSize imageSize,
            int batchSize,
            int numInferenceSteps,
            double guidanceScale,
            string? negativePrompt,
            long? seed,
            global::SiliconFlow.StableDiffusion35LargeModel model = global::SiliconFlow.StableDiffusion35LargeModel.StabilityaiStableDiffusion35Large)
        {
            this.Model = model;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativePrompt = negativePrompt;
            this.ImageSize = imageSize;
            this.BatchSize = batchSize;
            this.Seed = seed;
            this.NumInferenceSteps = numInferenceSteps;
            this.GuidanceScale = guidanceScale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StableDiffusion35Large" /> class.
        /// </summary>
        public StableDiffusion35Large()
        {
        }
    }
}