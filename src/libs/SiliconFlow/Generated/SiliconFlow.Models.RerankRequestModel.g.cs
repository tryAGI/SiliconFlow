
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// Specifies the model to be used.<br/>
    /// Example: BAAI/bge-reranker-v2-m3
    /// </summary>
    public enum RerankRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        BaaiBgeRerankerV2M3,
        /// <summary>
        /// 
        /// </summary>
        NeteaseYoudaoBceRerankerBaseV1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RerankRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RerankRequestModel value)
        {
            return value switch
            {
                RerankRequestModel.BaaiBgeRerankerV2M3 => "BAAI/bge-reranker-v2-m3",
                RerankRequestModel.NeteaseYoudaoBceRerankerBaseV1 => "netease-youdao/bce-reranker-base_v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RerankRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "BAAI/bge-reranker-v2-m3" => RerankRequestModel.BaaiBgeRerankerV2M3,
                "netease-youdao/bce-reranker-base_v1" => RerankRequestModel.NeteaseYoudaoBceRerankerBaseV1,
                _ => null,
            };
        }
    }
}