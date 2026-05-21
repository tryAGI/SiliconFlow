#nullable enable

namespace SiliconFlow
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Create Audio Transcriptions<br/>
        /// Creates an audio transcription.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.AudioResponse> CreateAudioTranscriptionsAsync(

            global::SiliconFlow.AudioRequest request,
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Audio Transcriptions<br/>
        /// Creates an audio transcription.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.AutoSDKHttpResponse<global::SiliconFlow.AudioResponse>> CreateAudioTranscriptionsAsResponseAsync(

            global::SiliconFlow.AudioRequest request,
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Audio Transcriptions<br/>
        /// Creates an audio transcription.
        /// </summary>
        /// <param name="file">
        /// The audio file object (not file name) to transcribe<br/>
        /// Example: /path/to/audio.mp3
        /// </param>
        /// <param name="filename">
        /// The audio file object (not file name) to transcribe<br/>
        /// Example: /path/to/audio.mp3
        /// </param>
        /// <param name="model">
        /// The name of the audio model to use.<br/>
        /// Example: FunAudioLLM/SenseVoiceSmall
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.AudioResponse> CreateAudioTranscriptionsAsync(
            byte[] file,
            string filename,
            global::SiliconFlow.AudioRequestModel model = default,
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Audio Transcriptions<br/>
        /// Creates an audio transcription.
        /// </summary>
        /// <param name="file">
        /// The audio file object (not file name) to transcribe<br/>
        /// Example: /path/to/audio.mp3
        /// </param>
        /// <param name="filename">
        /// The audio file object (not file name) to transcribe<br/>
        /// Example: /path/to/audio.mp3
        /// </param>
        /// <param name="model">
        /// The name of the audio model to use.<br/>
        /// Example: FunAudioLLM/SenseVoiceSmall
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.AudioResponse> CreateAudioTranscriptionsAsync(
            global::System.IO.Stream file,
            string filename,
            global::SiliconFlow.AudioRequestModel model = default,
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Audio Transcriptions<br/>
        /// Creates an audio transcription.
        /// </summary>
        /// <param name="file">
        /// The audio file object (not file name) to transcribe<br/>
        /// Example: /path/to/audio.mp3
        /// </param>
        /// <param name="filename">
        /// The audio file object (not file name) to transcribe<br/>
        /// Example: /path/to/audio.mp3
        /// </param>
        /// <param name="model">
        /// The name of the audio model to use.<br/>
        /// Example: FunAudioLLM/SenseVoiceSmall
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.AutoSDKHttpResponse<global::SiliconFlow.AudioResponse>> CreateAudioTranscriptionsAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::SiliconFlow.AudioRequestModel model = default,
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}