
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestMessage
    {
        /// <summary>
        /// The role of the messages author. Choice between: system, user, or assistant.<br/>
        /// Default Value: user<br/>
        /// Example: user
        /// </summary>
        /// <default>global::SiliconFlow.ChatCompletionRequestMessageRole.User</default>
        /// <example>user</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SiliconFlow.ChatCompletionRequestMessageRole Role { get; set; } = global::SiliconFlow.ChatCompletionRequestMessageRole.User;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SiliconFlow.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionRequestUserMessageContentPart>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SiliconFlow.OneOf<string, global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionRequestUserMessageContentPart>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the messages author. Choice between: system, user, or assistant.<br/>
        /// Default Value: user<br/>
        /// Example: user
        /// </param>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestMessage(
            global::SiliconFlow.ChatCompletionRequestMessageRole role,
            global::SiliconFlow.OneOf<string, global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionRequestUserMessageContentPart>> content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessage" /> class.
        /// </summary>
        public ChatCompletionRequestMessage()
        {
        }

    }
}