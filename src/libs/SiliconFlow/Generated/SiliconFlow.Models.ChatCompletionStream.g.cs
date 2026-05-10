
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionStream
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionChoicesDataItem>? Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.ChatCompletionStreamObjectJsonConverter))]
        public global::SiliconFlow.ChatCompletionStreamObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStream" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="choices"></param>
        /// <param name="created"></param>
        /// <param name="model"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionStream(
            string? id,
            global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionChoicesDataItem>? choices,
            int? created,
            string? model,
            global::SiliconFlow.ChatCompletionStreamObject? @object)
        {
            this.Id = id;
            this.Choices = choices;
            this.Created = created;
            this.Model = model;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStream" /> class.
        /// </summary>
        public ChatCompletionStream()
        {
        }

    }
}