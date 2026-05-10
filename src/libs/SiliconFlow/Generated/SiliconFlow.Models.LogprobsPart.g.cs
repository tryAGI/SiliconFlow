
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogprobsPart
    {
        /// <summary>
        /// List of token strings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public global::System.Collections.Generic.IList<string>? Tokens { get; set; }

        /// <summary>
        /// List of token log probabilities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_logprobs")]
        public global::System.Collections.Generic.IList<float>? TokenLogprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogprobsPart" /> class.
        /// </summary>
        /// <param name="tokens">
        /// List of token strings
        /// </param>
        /// <param name="tokenLogprobs">
        /// List of token log probabilities
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogprobsPart(
            global::System.Collections.Generic.IList<string>? tokens,
            global::System.Collections.Generic.IList<float>? tokenLogprobs)
        {
            this.Tokens = tokens;
            this.TokenLogprobs = tokenLogprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogprobsPart" /> class.
        /// </summary>
        public LogprobsPart()
        {
        }

    }
}