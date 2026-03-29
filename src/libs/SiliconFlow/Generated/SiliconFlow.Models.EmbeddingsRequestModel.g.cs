
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// The name of the embedding model to use.要使用的 embedding 模型名称。<br/>
    /// Example: BAAI/bge-large-zh-v1.5
    /// </summary>
    public enum EmbeddingsRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        BaaiBgeLargeEnV15,
        /// <summary>
        /// 
        /// </summary>
        BaaiBgeLargeZhV15,
        /// <summary>
        /// 
        /// </summary>
        BaaiBgeM3,
        /// <summary>
        /// 
        /// </summary>
        ProBaaiBgeM3,
        /// <summary>
        /// 
        /// </summary>
        NeteaseYoudaoBceEmbeddingBaseV1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsRequestModel value)
        {
            return value switch
            {
                EmbeddingsRequestModel.BaaiBgeLargeEnV15 => "BAAI/bge-large-en-v1.5",
                EmbeddingsRequestModel.BaaiBgeLargeZhV15 => "BAAI/bge-large-zh-v1.5",
                EmbeddingsRequestModel.BaaiBgeM3 => "BAAI/bge-m3",
                EmbeddingsRequestModel.ProBaaiBgeM3 => "Pro/BAAI/bge-m3",
                EmbeddingsRequestModel.NeteaseYoudaoBceEmbeddingBaseV1 => "netease-youdao/bce-embedding-base_v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "BAAI/bge-large-en-v1.5" => EmbeddingsRequestModel.BaaiBgeLargeEnV15,
                "BAAI/bge-large-zh-v1.5" => EmbeddingsRequestModel.BaaiBgeLargeZhV15,
                "BAAI/bge-m3" => EmbeddingsRequestModel.BaaiBgeM3,
                "Pro/BAAI/bge-m3" => EmbeddingsRequestModel.ProBaaiBgeM3,
                "netease-youdao/bce-embedding-base_v1" => EmbeddingsRequestModel.NeteaseYoudaoBceEmbeddingBaseV1,
                _ => null,
            };
        }
    }
}