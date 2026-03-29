
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequest
    {
        /// <summary>
        /// The name of the model to query.<br/>
        /// Default Value: deepseek-ai/DeepSeek-V2.5<br/>
        /// Example: deepseek-ai/DeepSeek-V2.5
        /// </summary>
        /// <default>global::SiliconFlow.ChatCompletionRequestModel.DeepseekAiDeepSeekV25</default>
        /// <example>deepseek-ai/DeepSeek-V2.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.ChatCompletionRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SiliconFlow.ChatCompletionRequestModel Model { get; set; } = global::SiliconFlow.ChatCompletionRequestModel.DeepseekAiDeepSeekV25;

        /// <summary>
        /// A list of messages comprising the conversation so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionRequestMessage> Messages { get; set; }

        /// <summary>
        /// If set, tokens are returned as Server-Sent Events as they are made available. Stream terminates with `data: [DONE]`<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate.<br/>
        /// Default Value: 512<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::SiliconFlow.OneOf<string, global::System.Collections.Generic.IList<string>>? Stop { get; set; }

        /// <summary>
        /// Determines the degree of randomness in the response.<br/>
        /// Default Value: 0.7<br/>
        /// Example: 0.7
        /// </summary>
        /// <example>0.7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// The `top_p` (nucleus) parameter is used to dynamically adjust the number of choices for each predicted token based on the cumulative probabilities.<br/>
        /// Default Value: 0.7<br/>
        /// Example: 0.7
        /// </summary>
        /// <example>0.7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public float? TopK { get; set; }

        /// <summary>
        /// Default Value: 0.5<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// Number of generations to return<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// An object specifying the format that the model must output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::SiliconFlow.ChatCompletionRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The name of the model to query.<br/>
        /// Default Value: deepseek-ai/DeepSeek-V2.5<br/>
        /// Example: deepseek-ai/DeepSeek-V2.5
        /// </param>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="stream">
        /// If set, tokens are returned as Server-Sent Events as they are made available. Stream terminates with `data: [DONE]`<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate.<br/>
        /// Default Value: 512<br/>
        /// Example: 512
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="temperature">
        /// Determines the degree of randomness in the response.<br/>
        /// Default Value: 0.7<br/>
        /// Example: 0.7
        /// </param>
        /// <param name="topP">
        /// The `top_p` (nucleus) parameter is used to dynamically adjust the number of choices for each predicted token based on the cumulative probabilities.<br/>
        /// Default Value: 0.7<br/>
        /// Example: 0.7
        /// </param>
        /// <param name="topK">
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="frequencyPenalty">
        /// Default Value: 0.5<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="n">
        /// Number of generations to return<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="responseFormat">
        /// An object specifying the format that the model must output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequest(
            global::SiliconFlow.ChatCompletionRequestModel model,
            global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionRequestMessage> messages,
            bool? stream,
            int? maxTokens,
            global::SiliconFlow.OneOf<string, global::System.Collections.Generic.IList<string>>? stop,
            float? temperature,
            float? topP,
            float? topK,
            float? frequencyPenalty,
            int? n,
            global::SiliconFlow.ChatCompletionRequestResponseFormat? responseFormat)
        {
            this.Model = model;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Stream = stream;
            this.MaxTokens = maxTokens;
            this.Stop = stop;
            this.Temperature = temperature;
            this.TopP = topP;
            this.TopK = topK;
            this.FrequencyPenalty = frequencyPenalty;
            this.N = n;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        public ChatCompletionRequest()
        {
        }
    }
}