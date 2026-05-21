
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StableDiffusionXlBase10
    {
        /// <summary>
        /// Default Value: stabilityai/stable-diffusion-xl-base-1.0
        /// </summary>
        /// <default>global::SiliconFlow.StableDiffusionXlBase10Model.StabilityaiStableDiffusionXlBase10</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.StableDiffusionXlBase10ModelJsonConverter))]
        public global::SiliconFlow.StableDiffusionXlBase10Model Model { get; set; } = global::SiliconFlow.StableDiffusionXlBase10Model.StabilityaiStableDiffusionXlBase10;

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
        /// <default>global::SiliconFlow.StableDiffusionXlBase10ImageSize.x1024x1024</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.StableDiffusionXlBase10ImageSizeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SiliconFlow.StableDiffusionXlBase10ImageSize ImageSize { get; set; } = global::SiliconFlow.StableDiffusionXlBase10ImageSize.x1024x1024;

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
        /// Default Value: data:image/webp;base64, XXX
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StableDiffusionXlBase10" /> class.
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
        /// <param name="image">
        /// Default Value: data:image/webp;base64, XXX
        /// </param>
        /// <param name="model">
        /// Default Value: stabilityai/stable-diffusion-xl-base-1.0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StableDiffusionXlBase10(
            string prompt,
            global::SiliconFlow.StableDiffusionXlBase10ImageSize imageSize,
            int batchSize,
            int numInferenceSteps,
            double guidanceScale,
            string? negativePrompt,
            long? seed,
            string? image,
            global::SiliconFlow.StableDiffusionXlBase10Model model = global::SiliconFlow.StableDiffusionXlBase10Model.StabilityaiStableDiffusionXlBase10)
        {
            this.Model = model;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativePrompt = negativePrompt;
            this.ImageSize = imageSize;
            this.BatchSize = batchSize;
            this.Seed = seed;
            this.NumInferenceSteps = numInferenceSteps;
            this.GuidanceScale = guidanceScale;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StableDiffusionXlBase10" /> class.
        /// </summary>
        public StableDiffusionXlBase10()
        {
        }

    }
}