
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserInfoResponse
    {
        /// <summary>
        /// Example: 20000
        /// </summary>
        /// <example>20000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public int? Code { get; set; }

        /// <summary>
        /// Example: OK
        /// </summary>
        /// <example>OK</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public bool? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::SiliconFlow.UserInfoResponseData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfoResponse" /> class.
        /// </summary>
        /// <param name="code">
        /// Example: 20000
        /// </param>
        /// <param name="message">
        /// Example: OK
        /// </param>
        /// <param name="status">
        /// Example: true
        /// </param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserInfoResponse(
            int? code,
            string? message,
            bool? status,
            global::SiliconFlow.UserInfoResponseData? data)
        {
            this.Code = code;
            this.Message = message;
            this.Status = status;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfoResponse" /> class.
        /// </summary>
        public UserInfoResponse()
        {
        }

    }
}