
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetrieveAListOfModelsResponseDataItem
    {
        /// <summary>
        /// Example: stabilityai/stable-diffusion-xl-base-1.0
        /// </summary>
        /// <example>stabilityai/stable-diffusion-xl-base-1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: model
        /// </summary>
        /// <example>model</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_by")]
        public string? OwnedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveAListOfModelsResponseDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: stabilityai/stable-diffusion-xl-base-1.0
        /// </param>
        /// <param name="object">
        /// Example: model
        /// </param>
        /// <param name="created">
        /// Example: 0
        /// </param>
        /// <param name="ownedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrieveAListOfModelsResponseDataItem(
            string? id,
            string? @object,
            int? created,
            string? ownedBy)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.OwnedBy = ownedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveAListOfModelsResponseDataItem" /> class.
        /// </summary>
        public RetrieveAListOfModelsResponseDataItem()
        {
        }

    }
}