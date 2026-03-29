#nullable enable

namespace SiliconFlow
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Image Generation<br/>
        /// Creates an image response for the given prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.ImagesGenerationResponse> ImageGenerationAsync(

            global::SiliconFlow.OneOf<global::SiliconFlow.StableDiffusion35Large, global::SiliconFlow.Flux1Schnell, global::SiliconFlow.ProFlux1Schnell, global::SiliconFlow.Flux1Dev, global::SiliconFlow.StableDiffusion3Medium, global::SiliconFlow.StableDiffusionXlBase10, global::SiliconFlow.StableDiffusion21> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Generation<br/>
        /// Creates an image response for the given prompt.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.ImagesGenerationResponse> ImageGenerationAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}