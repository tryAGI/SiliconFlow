
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserInfoResponseData
    {
        /// <summary>
        /// Example: userid
        /// </summary>
        /// <example>userid</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: username
        /// </summary>
        /// <example>username</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: user_avatar_image_url
        /// </summary>
        /// <example>user_avatar_image_url</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Example: user_email_address
        /// </summary>
        /// <example>user_email_address</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("isAdmin")]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// Example: 0.88
        /// </summary>
        /// <example>0.88</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        public string? Balance { get; set; }

        /// <summary>
        /// Example: normal
        /// </summary>
        /// <example>normal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Example: user_introduction
        /// </summary>
        /// <example>user_introduction</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("introduction")]
        public string? Introduction { get; set; }

        /// <summary>
        /// Example: user_role
        /// </summary>
        /// <example>user_role</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Example: 88.00
        /// </summary>
        /// <example>88.00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chargeBalance")]
        public string? ChargeBalance { get; set; }

        /// <summary>
        /// Example: 88.88
        /// </summary>
        /// <example>88.88</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalBalance")]
        public string? TotalBalance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfoResponseData" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: userid
        /// </param>
        /// <param name="name">
        /// Example: username
        /// </param>
        /// <param name="image">
        /// Example: user_avatar_image_url
        /// </param>
        /// <param name="email">
        /// Example: user_email_address
        /// </param>
        /// <param name="isAdmin">
        /// Example: false
        /// </param>
        /// <param name="balance">
        /// Example: 0.88
        /// </param>
        /// <param name="status">
        /// Example: normal
        /// </param>
        /// <param name="introduction">
        /// Example: user_introduction
        /// </param>
        /// <param name="role">
        /// Example: user_role
        /// </param>
        /// <param name="chargeBalance">
        /// Example: 88.00
        /// </param>
        /// <param name="totalBalance">
        /// Example: 88.88
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserInfoResponseData(
            string? id,
            string? name,
            string? image,
            string? email,
            bool? isAdmin,
            string? balance,
            string? status,
            string? introduction,
            string? role,
            string? chargeBalance,
            string? totalBalance)
        {
            this.Id = id;
            this.Name = name;
            this.Image = image;
            this.Email = email;
            this.IsAdmin = isAdmin;
            this.Balance = balance;
            this.Status = status;
            this.Introduction = introduction;
            this.Role = role;
            this.ChargeBalance = chargeBalance;
            this.TotalBalance = totalBalance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfoResponseData" /> class.
        /// </summary>
        public UserInfoResponseData()
        {
        }

    }
}