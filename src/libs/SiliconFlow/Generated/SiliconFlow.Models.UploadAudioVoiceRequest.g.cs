
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadAudioVoiceRequest
    {
        /// <summary>
        /// 预置音色的模型名称<br/>
        /// Example: fishaudio/fish-speech-1.4
        /// </summary>
        /// <example>fishaudio/fish-speech-1.4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.UploadAudioVoiceRequestModelJsonConverter))]
        public global::SiliconFlow.UploadAudioVoiceRequestModel Model { get; set; }

        /// <summary>
        /// 用户自定义的音色名称<br/>
        /// Default Value: 硅基流动音色模型<br/>
        /// Example: your-voice-name
        /// </summary>
        /// <default>"硅基流动音色模型"</default>
        /// <example>your-voice-name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("customName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomName { get; set; } = "硅基流动音色模型";

        /// <summary>
        /// 音频对应的文字内容<br/>
        /// Default Value: 在一无所知中, 梦里的一天结束了，一个新的轮回便会开始<br/>
        /// Example: 在一无所知中, 梦里的一天结束了，一个新的轮回便会开始
        /// </summary>
        /// <default>"在一无所知中, 梦里的一天结束了，一个新的轮回便会开始"</default>
        /// <example>在一无所知中, 梦里的一天结束了，一个新的轮回便会开始</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; } = "在一无所知中, 梦里的一天结束了，一个新的轮回便会开始";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAudioVoiceRequest" /> class.
        /// </summary>
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
        /// <param name="model">
        /// 预置音色的模型名称<br/>
        /// Example: fishaudio/fish-speech-1.4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadAudioVoiceRequest(
            string customName,
            string text,
            global::SiliconFlow.UploadAudioVoiceRequestModel model)
        {
            this.Model = model;
            this.CustomName = customName ?? throw new global::System.ArgumentNullException(nameof(customName));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAudioVoiceRequest" /> class.
        /// </summary>
        public UploadAudioVoiceRequest()
        {
        }

    }
}