
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsRequest
    {
        /// <summary>
        /// The name of the embedding model to use.要使用的 embedding 模型名称。<br/>
        /// Example: BAAI/bge-large-zh-v1.5
        /// </summary>
        /// <example>BAAI/bge-large-zh-v1.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.EmbeddingsRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SiliconFlow.EmbeddingsRequestModel Model { get; set; }

        /// <summary>
        /// Input text to embed, encoded as a string or array of tokens. To embed multiple inputs in a single request, pass an array of strings or array of token arrays. The input must not exceed the max input tokens for the model (512 tokens for all models except BAAI/bge-m3 which is 8192), cannot be an empty string.<br/>
        /// 输入的文本将被编码为字符串或 tokens 数组。要在单个请求中嵌入多个输入，请传递字符串数组或字符串数组。每个字符串不得超过模型的最大 tokens 限制（BAAI/bge-m3模型为8192tokens，其余模型为512tokens），且不能为空字符串。<br/>
        /// Default Value: 硅基流动embedding上线，多快好省的 embedding 服务，快来试试吧
        /// </summary>
        /// <default>"硅基流动embedding上线，多快好省的 embedding 服务，快来试试吧"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SiliconFlow.OneOf<string, global::System.Collections.Generic.IList<string>> Input { get; set; } = "硅基流动embedding上线，多快好省的 embedding 服务，快来试试吧";

        /// <summary>
        /// "The format to return the embeddings in. Can be either `float` or [`base64`](https://pypi.org/project/pybase64/). 返回嵌入的格式。可以是 float 或 [`base64`](https://pypi.org/project/pybase64/)."<br/>
        /// Default Value: float<br/>
        /// Example: float
        /// </summary>
        /// <example>float</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.EmbeddingsRequestEncodingFormatJsonConverter))]
        public global::SiliconFlow.EmbeddingsRequestEncodingFormat? EncodingFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The name of the embedding model to use.要使用的 embedding 模型名称。<br/>
        /// Example: BAAI/bge-large-zh-v1.5
        /// </param>
        /// <param name="input">
        /// Input text to embed, encoded as a string or array of tokens. To embed multiple inputs in a single request, pass an array of strings or array of token arrays. The input must not exceed the max input tokens for the model (512 tokens for all models except BAAI/bge-m3 which is 8192), cannot be an empty string.<br/>
        /// 输入的文本将被编码为字符串或 tokens 数组。要在单个请求中嵌入多个输入，请传递字符串数组或字符串数组。每个字符串不得超过模型的最大 tokens 限制（BAAI/bge-m3模型为8192tokens，其余模型为512tokens），且不能为空字符串。<br/>
        /// Default Value: 硅基流动embedding上线，多快好省的 embedding 服务，快来试试吧
        /// </param>
        /// <param name="encodingFormat">
        /// "The format to return the embeddings in. Can be either `float` or [`base64`](https://pypi.org/project/pybase64/). 返回嵌入的格式。可以是 float 或 [`base64`](https://pypi.org/project/pybase64/)."<br/>
        /// Default Value: float<br/>
        /// Example: float
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsRequest(
            global::SiliconFlow.EmbeddingsRequestModel model,
            global::SiliconFlow.OneOf<string, global::System.Collections.Generic.IList<string>> input,
            global::SiliconFlow.EmbeddingsRequestEncodingFormat? encodingFormat)
        {
            this.Model = model;
            this.Input = input;
            this.EncodingFormat = encodingFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsRequest" /> class.
        /// </summary>
        public EmbeddingsRequest()
        {
        }
    }
}