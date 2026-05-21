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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.ImagesGenerationResponse> ImageGenerationAsync(

            global::SiliconFlow.OneOf<global::SiliconFlow.StableDiffusion35Large, global::SiliconFlow.Flux1Schnell, global::SiliconFlow.ProFlux1Schnell, global::SiliconFlow.Flux1Dev, global::SiliconFlow.StableDiffusion3Medium, global::SiliconFlow.StableDiffusionXlBase10, global::SiliconFlow.StableDiffusion21> request,
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Generation<br/>
        /// Creates an image response for the given prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.AutoSDKHttpResponse<global::SiliconFlow.ImagesGenerationResponse>> ImageGenerationAsResponseAsync(

            global::SiliconFlow.OneOf<global::SiliconFlow.StableDiffusion35Large, global::SiliconFlow.Flux1Schnell, global::SiliconFlow.ProFlux1Schnell, global::SiliconFlow.Flux1Dev, global::SiliconFlow.StableDiffusion3Medium, global::SiliconFlow.StableDiffusionXlBase10, global::SiliconFlow.StableDiffusion21> request,
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Generation<br/>
        /// Creates an image response for the given prompt.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.ImagesGenerationResponse> ImageGenerationAsync(
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}