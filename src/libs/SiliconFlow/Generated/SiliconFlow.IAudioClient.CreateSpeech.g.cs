#nullable enable

namespace SiliconFlow
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Create Speech<br/>
        /// 从输入文本生成音频。根据输入的文本生成音频。接口生成的数据为音频的二进制数据，需要使用者自行处理。参考：https://docs.siliconflow.cn/capabilities/text-to-speech#5
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(

            global::SiliconFlow.CreateSpeechRequest request,
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Speech<br/>
        /// 从输入文本生成音频。根据输入的文本生成音频。接口生成的数据为音频的二进制数据，需要使用者自行处理。参考：https://docs.siliconflow.cn/capabilities/text-to-speech#5
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.AutoSDKHttpResponse<byte[]>> CreateSpeechAsResponseAsync(

            global::SiliconFlow.CreateSpeechRequest request,
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Speech<br/>
        /// 从输入文本生成音频。根据输入的文本生成音频。接口生成的数据为音频的二进制数据，需要使用者自行处理。参考：https://docs.siliconflow.cn/capabilities/text-to-speech#5
        /// </summary>
        /// <param name="model">
        /// Current available TTS models: `fishaudio/fish-speech-1.4`<br/>
        /// Example: fishaudio/fish-speech-1.4
        /// </param>
        /// <param name="input">
        /// The text to generate audio for.
        /// </param>
        /// <param name="voice">
        /// The voice to use when generating the audio. Supported voices are `fishaudio/fish-speech-1.4:alex`, `fishaudio/fish-speech-1.4:anna`, `fishaudio/fish-speech-1.4:bella`, `fishaudio/fish-speech-1.4:benjamin`, `fishaudio/fish-speech-1.4:charles`, `fishaudio/fish-speech-1.4:claire`, `fishaudio/fish-speech-1.4:david`, `fishaudio/fish-speech-1.4:diana`. Previews of the voices are available in the [Text to speech guide](/capabilities/text-to-speech).
        /// </param>
        /// <param name="responseFormat">
        /// The format to audio in. Supported formats are `mp3`, `opus`, `wav`, `pcm`<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(
            string input,
            global::SiliconFlow.CreateSpeechRequestVoice voice,
            global::SiliconFlow.CreateSpeechRequestModel model = default,
            global::SiliconFlow.CreateSpeechRequestResponseFormat? responseFormat = default,
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}