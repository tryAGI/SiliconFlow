#nullable enable

namespace SiliconFlow
{
    public partial interface ISiliconFlowClient
    {
        /// <summary>
        /// Upload Voice<br/>
        /// 上传用户预置音色，支持以 base64 编码或者文件形式上传，参考https://docs.siliconflow.cn/capabilities/text-to-speech#2-2)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.UploadAudioVoiceResponse> UploadAudioVoiceAsync(

            global::SiliconFlow.UploadAudioVoiceRequest request,
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Voice<br/>
        /// 上传用户预置音色，支持以 base64 编码或者文件形式上传，参考https://docs.siliconflow.cn/capabilities/text-to-speech#2-2)
        /// </summary>
        /// <param name="model">
        /// 预置音色的模型名称<br/>
        /// Example: fishaudio/fish-speech-1.4
        /// </param>
        /// <param name="customName">
        /// 用户自定义的音色名称<br/>
        /// Default Value: 硅基流动音色模型<br/>
        /// Example: your-voice-name
        /// </param>
        /// <param name="text">
        /// 音频对应的文字内容<br/>
        /// Default Value: 在一无所知中, 梦里的一天结束了，一个新的轮回便会开始<br/>
        /// Example: 在一无所知中, 梦里的一天结束了，一个新的轮回便会开始
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.UploadAudioVoiceResponse> UploadAudioVoiceAsync(
            global::SiliconFlow.UploadAudioVoiceRequestModel model = default,
            string customName = "硅基流动音色模型",
            string text = "在一无所知中, 梦里的一天结束了，一个新的轮回便会开始",
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}