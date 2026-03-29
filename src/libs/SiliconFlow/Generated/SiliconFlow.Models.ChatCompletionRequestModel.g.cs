
#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// The name of the model to query.<br/>
    /// Default Value: deepseek-ai/DeepSeek-V2.5<br/>
    /// Example: deepseek-ai/DeepSeek-V2.5
    /// </summary>
    public enum ChatCompletionRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        x01AiYi1534bChat16k,
        /// <summary>
        /// 
        /// </summary>
        x01AiYi156bChat,
        /// <summary>
        /// 
        /// </summary>
        x01AiYi159bChat16k,
        /// <summary>
        /// 
        /// </summary>
        OpenGVLabInternVL226b,
        /// <summary>
        /// 
        /// </summary>
        OpenGVLabInternVL2Llama376b,
        /// <summary>
        /// 
        /// </summary>
        Pro01AiYi156bChat,
        /// <summary>
        /// 
        /// </summary>
        Pro01AiYi159bChat16k,
        /// <summary>
        /// 
        /// </summary>
        ProOpenGVLabInternVL28b,
        /// <summary>
        /// 
        /// </summary>
        ProQwenQwen215bInstruct,
        /// <summary>
        /// 
        /// </summary>
        ProQwenQwen27bInstruct,
        /// <summary>
        /// 
        /// </summary>
        ProQwenQwen2Vl7bInstruct,
        /// <summary>
        /// 
        /// </summary>
        ProQwenQwen257bInstruct,
        /// <summary>
        /// 
        /// </summary>
        ProThudmChatglm36b,
        /// <summary>
        /// 
        /// </summary>
        ProThudmGlm49bChat,
        /// <summary>
        /// 
        /// </summary>
        ProGoogleGemma29bIt,
        /// <summary>
        /// 
        /// </summary>
        ProInternlmInternlm257bChat,
        /// <summary>
        /// 
        /// </summary>
        ProMetaLlamaMetaLlama38bInstruct,
        /// <summary>
        /// 
        /// </summary>
        ProMetaLlamaMetaLlama318bInstruct,
        /// <summary>
        /// 
        /// </summary>
        QwenQwen215bInstruct,
        /// <summary>
        /// 
        /// </summary>
        QwenQwen257bA14bInstruct,
        /// <summary>
        /// 
        /// </summary>
        QwenQwen272bInstruct,
        /// <summary>
        /// 
        /// </summary>
        QwenQwen27bInstruct,
        /// <summary>
        /// 
        /// </summary>
        QwenQwen2Vl72bInstruct,
        /// <summary>
        /// 
        /// </summary>
        QwenQwen2514bInstruct,
        /// <summary>
        /// 
        /// </summary>
        QwenQwen2532bInstruct,
        /// <summary>
        /// 
        /// </summary>
        QwenQwen2572bInstruct,
        /// <summary>
        /// 
        /// </summary>
        QwenQwen2572bInstruct128k,
        /// <summary>
        /// 
        /// </summary>
        QwenQwen257bInstruct,
        /// <summary>
        /// 
        /// </summary>
        QwenQwen25Coder7bInstruct,
        /// <summary>
        /// 
        /// </summary>
        QwenQwen25Math72bInstruct,
        /// <summary>
        /// 
        /// </summary>
        ThudmChatglm36b,
        /// <summary>
        /// 
        /// </summary>
        ThudmGlm49bChat,
        /// <summary>
        /// 
        /// </summary>
        TeleAITeleChat2,
        /// <summary>
        /// 
        /// </summary>
        VendorAQwenQwen272bInstruct,
        /// <summary>
        /// 
        /// </summary>
        VendorAQwenQwen2572bInstruct,
        /// <summary>
        /// 
        /// </summary>
        DeepseekAiDeepSeekCoderV2Instruct,
        /// <summary>
        /// 
        /// </summary>
        DeepseekAiDeepSeekV2Chat,
        /// <summary>
        /// 
        /// </summary>
        DeepseekAiDeepSeekV25,
        /// <summary>
        /// 
        /// </summary>
        GoogleGemma227bIt,
        /// <summary>
        /// 
        /// </summary>
        GoogleGemma29bIt,
        /// <summary>
        /// 
        /// </summary>
        InternlmInternlm2520bChat,
        /// <summary>
        /// 
        /// </summary>
        InternlmInternlm257bChat,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaMetaLlama370bInstruct,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaMetaLlama38bInstruct,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaMetaLlama31405bInstruct,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaMetaLlama3170bInstruct,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaMetaLlama318bInstruct,
        /// <summary>
        /// 
        /// </summary>
        NvidiaLlama31Nemotron70bInstruct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestModel value)
        {
            return value switch
            {
                ChatCompletionRequestModel.x01AiYi1534bChat16k => "01-ai/Yi-1.5-34B-Chat-16K",
                ChatCompletionRequestModel.x01AiYi156bChat => "01-ai/Yi-1.5-6B-Chat",
                ChatCompletionRequestModel.x01AiYi159bChat16k => "01-ai/Yi-1.5-9B-Chat-16K",
                ChatCompletionRequestModel.OpenGVLabInternVL226b => "OpenGVLab/InternVL2-26B",
                ChatCompletionRequestModel.OpenGVLabInternVL2Llama376b => "OpenGVLab/InternVL2-Llama3-76B",
                ChatCompletionRequestModel.Pro01AiYi156bChat => "Pro/01-ai/Yi-1.5-6B-Chat",
                ChatCompletionRequestModel.Pro01AiYi159bChat16k => "Pro/01-ai/Yi-1.5-9B-Chat-16K",
                ChatCompletionRequestModel.ProOpenGVLabInternVL28b => "Pro/OpenGVLab/InternVL2-8B",
                ChatCompletionRequestModel.ProQwenQwen215bInstruct => "Pro/Qwen/Qwen2-1.5B-Instruct",
                ChatCompletionRequestModel.ProQwenQwen27bInstruct => "Pro/Qwen/Qwen2-7B-Instruct",
                ChatCompletionRequestModel.ProQwenQwen2Vl7bInstruct => "Pro/Qwen/Qwen2-VL-7B-Instruct",
                ChatCompletionRequestModel.ProQwenQwen257bInstruct => "Pro/Qwen/Qwen2.5-7B-Instruct",
                ChatCompletionRequestModel.ProThudmChatglm36b => "Pro/THUDM/chatglm3-6b",
                ChatCompletionRequestModel.ProThudmGlm49bChat => "Pro/THUDM/glm-4-9b-chat",
                ChatCompletionRequestModel.ProGoogleGemma29bIt => "Pro/google/gemma-2-9b-it",
                ChatCompletionRequestModel.ProInternlmInternlm257bChat => "Pro/internlm/internlm2_5-7b-chat",
                ChatCompletionRequestModel.ProMetaLlamaMetaLlama38bInstruct => "Pro/meta-llama/Meta-Llama-3-8B-Instruct",
                ChatCompletionRequestModel.ProMetaLlamaMetaLlama318bInstruct => "Pro/meta-llama/Meta-Llama-3.1-8B-Instruct",
                ChatCompletionRequestModel.QwenQwen215bInstruct => "Qwen/Qwen2-1.5B-Instruct",
                ChatCompletionRequestModel.QwenQwen257bA14bInstruct => "Qwen/Qwen2-57B-A14B-Instruct",
                ChatCompletionRequestModel.QwenQwen272bInstruct => "Qwen/Qwen2-72B-Instruct",
                ChatCompletionRequestModel.QwenQwen27bInstruct => "Qwen/Qwen2-7B-Instruct",
                ChatCompletionRequestModel.QwenQwen2Vl72bInstruct => "Qwen/Qwen2-VL-72B-Instruct",
                ChatCompletionRequestModel.QwenQwen2514bInstruct => "Qwen/Qwen2.5-14B-Instruct",
                ChatCompletionRequestModel.QwenQwen2532bInstruct => "Qwen/Qwen2.5-32B-Instruct",
                ChatCompletionRequestModel.QwenQwen2572bInstruct => "Qwen/Qwen2.5-72B-Instruct",
                ChatCompletionRequestModel.QwenQwen2572bInstruct128k => "Qwen/Qwen2.5-72B-Instruct-128K",
                ChatCompletionRequestModel.QwenQwen257bInstruct => "Qwen/Qwen2.5-7B-Instruct",
                ChatCompletionRequestModel.QwenQwen25Coder7bInstruct => "Qwen/Qwen2.5-Coder-7B-Instruct",
                ChatCompletionRequestModel.QwenQwen25Math72bInstruct => "Qwen/Qwen2.5-Math-72B-Instruct",
                ChatCompletionRequestModel.ThudmChatglm36b => "THUDM/chatglm3-6b",
                ChatCompletionRequestModel.ThudmGlm49bChat => "THUDM/glm-4-9b-chat",
                ChatCompletionRequestModel.TeleAITeleChat2 => "TeleAI/TeleChat2",
                ChatCompletionRequestModel.VendorAQwenQwen272bInstruct => "Vendor-A/Qwen/Qwen2-72B-Instruct",
                ChatCompletionRequestModel.VendorAQwenQwen2572bInstruct => "Vendor-A/Qwen/Qwen2.5-72B-Instruct",
                ChatCompletionRequestModel.DeepseekAiDeepSeekCoderV2Instruct => "deepseek-ai/DeepSeek-Coder-V2-Instruct",
                ChatCompletionRequestModel.DeepseekAiDeepSeekV2Chat => "deepseek-ai/DeepSeek-V2-Chat",
                ChatCompletionRequestModel.DeepseekAiDeepSeekV25 => "deepseek-ai/DeepSeek-V2.5",
                ChatCompletionRequestModel.GoogleGemma227bIt => "google/gemma-2-27b-it",
                ChatCompletionRequestModel.GoogleGemma29bIt => "google/gemma-2-9b-it",
                ChatCompletionRequestModel.InternlmInternlm2520bChat => "internlm/internlm2_5-20b-chat",
                ChatCompletionRequestModel.InternlmInternlm257bChat => "internlm/internlm2_5-7b-chat",
                ChatCompletionRequestModel.MetaLlamaMetaLlama370bInstruct => "meta-llama/Meta-Llama-3-70B-Instruct",
                ChatCompletionRequestModel.MetaLlamaMetaLlama38bInstruct => "meta-llama/Meta-Llama-3-8B-Instruct",
                ChatCompletionRequestModel.MetaLlamaMetaLlama31405bInstruct => "meta-llama/Meta-Llama-3.1-405B-Instruct",
                ChatCompletionRequestModel.MetaLlamaMetaLlama3170bInstruct => "meta-llama/Meta-Llama-3.1-70B-Instruct",
                ChatCompletionRequestModel.MetaLlamaMetaLlama318bInstruct => "meta-llama/Meta-Llama-3.1-8B-Instruct",
                ChatCompletionRequestModel.NvidiaLlama31Nemotron70bInstruct => "nvidia/Llama-3.1-Nemotron-70B-Instruct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "01-ai/Yi-1.5-34B-Chat-16K" => ChatCompletionRequestModel.x01AiYi1534bChat16k,
                "01-ai/Yi-1.5-6B-Chat" => ChatCompletionRequestModel.x01AiYi156bChat,
                "01-ai/Yi-1.5-9B-Chat-16K" => ChatCompletionRequestModel.x01AiYi159bChat16k,
                "OpenGVLab/InternVL2-26B" => ChatCompletionRequestModel.OpenGVLabInternVL226b,
                "OpenGVLab/InternVL2-Llama3-76B" => ChatCompletionRequestModel.OpenGVLabInternVL2Llama376b,
                "Pro/01-ai/Yi-1.5-6B-Chat" => ChatCompletionRequestModel.Pro01AiYi156bChat,
                "Pro/01-ai/Yi-1.5-9B-Chat-16K" => ChatCompletionRequestModel.Pro01AiYi159bChat16k,
                "Pro/OpenGVLab/InternVL2-8B" => ChatCompletionRequestModel.ProOpenGVLabInternVL28b,
                "Pro/Qwen/Qwen2-1.5B-Instruct" => ChatCompletionRequestModel.ProQwenQwen215bInstruct,
                "Pro/Qwen/Qwen2-7B-Instruct" => ChatCompletionRequestModel.ProQwenQwen27bInstruct,
                "Pro/Qwen/Qwen2-VL-7B-Instruct" => ChatCompletionRequestModel.ProQwenQwen2Vl7bInstruct,
                "Pro/Qwen/Qwen2.5-7B-Instruct" => ChatCompletionRequestModel.ProQwenQwen257bInstruct,
                "Pro/THUDM/chatglm3-6b" => ChatCompletionRequestModel.ProThudmChatglm36b,
                "Pro/THUDM/glm-4-9b-chat" => ChatCompletionRequestModel.ProThudmGlm49bChat,
                "Pro/google/gemma-2-9b-it" => ChatCompletionRequestModel.ProGoogleGemma29bIt,
                "Pro/internlm/internlm2_5-7b-chat" => ChatCompletionRequestModel.ProInternlmInternlm257bChat,
                "Pro/meta-llama/Meta-Llama-3-8B-Instruct" => ChatCompletionRequestModel.ProMetaLlamaMetaLlama38bInstruct,
                "Pro/meta-llama/Meta-Llama-3.1-8B-Instruct" => ChatCompletionRequestModel.ProMetaLlamaMetaLlama318bInstruct,
                "Qwen/Qwen2-1.5B-Instruct" => ChatCompletionRequestModel.QwenQwen215bInstruct,
                "Qwen/Qwen2-57B-A14B-Instruct" => ChatCompletionRequestModel.QwenQwen257bA14bInstruct,
                "Qwen/Qwen2-72B-Instruct" => ChatCompletionRequestModel.QwenQwen272bInstruct,
                "Qwen/Qwen2-7B-Instruct" => ChatCompletionRequestModel.QwenQwen27bInstruct,
                "Qwen/Qwen2-VL-72B-Instruct" => ChatCompletionRequestModel.QwenQwen2Vl72bInstruct,
                "Qwen/Qwen2.5-14B-Instruct" => ChatCompletionRequestModel.QwenQwen2514bInstruct,
                "Qwen/Qwen2.5-32B-Instruct" => ChatCompletionRequestModel.QwenQwen2532bInstruct,
                "Qwen/Qwen2.5-72B-Instruct" => ChatCompletionRequestModel.QwenQwen2572bInstruct,
                "Qwen/Qwen2.5-72B-Instruct-128K" => ChatCompletionRequestModel.QwenQwen2572bInstruct128k,
                "Qwen/Qwen2.5-7B-Instruct" => ChatCompletionRequestModel.QwenQwen257bInstruct,
                "Qwen/Qwen2.5-Coder-7B-Instruct" => ChatCompletionRequestModel.QwenQwen25Coder7bInstruct,
                "Qwen/Qwen2.5-Math-72B-Instruct" => ChatCompletionRequestModel.QwenQwen25Math72bInstruct,
                "THUDM/chatglm3-6b" => ChatCompletionRequestModel.ThudmChatglm36b,
                "THUDM/glm-4-9b-chat" => ChatCompletionRequestModel.ThudmGlm49bChat,
                "TeleAI/TeleChat2" => ChatCompletionRequestModel.TeleAITeleChat2,
                "Vendor-A/Qwen/Qwen2-72B-Instruct" => ChatCompletionRequestModel.VendorAQwenQwen272bInstruct,
                "Vendor-A/Qwen/Qwen2.5-72B-Instruct" => ChatCompletionRequestModel.VendorAQwenQwen2572bInstruct,
                "deepseek-ai/DeepSeek-Coder-V2-Instruct" => ChatCompletionRequestModel.DeepseekAiDeepSeekCoderV2Instruct,
                "deepseek-ai/DeepSeek-V2-Chat" => ChatCompletionRequestModel.DeepseekAiDeepSeekV2Chat,
                "deepseek-ai/DeepSeek-V2.5" => ChatCompletionRequestModel.DeepseekAiDeepSeekV25,
                "google/gemma-2-27b-it" => ChatCompletionRequestModel.GoogleGemma227bIt,
                "google/gemma-2-9b-it" => ChatCompletionRequestModel.GoogleGemma29bIt,
                "internlm/internlm2_5-20b-chat" => ChatCompletionRequestModel.InternlmInternlm2520bChat,
                "internlm/internlm2_5-7b-chat" => ChatCompletionRequestModel.InternlmInternlm257bChat,
                "meta-llama/Meta-Llama-3-70B-Instruct" => ChatCompletionRequestModel.MetaLlamaMetaLlama370bInstruct,
                "meta-llama/Meta-Llama-3-8B-Instruct" => ChatCompletionRequestModel.MetaLlamaMetaLlama38bInstruct,
                "meta-llama/Meta-Llama-3.1-405B-Instruct" => ChatCompletionRequestModel.MetaLlamaMetaLlama31405bInstruct,
                "meta-llama/Meta-Llama-3.1-70B-Instruct" => ChatCompletionRequestModel.MetaLlamaMetaLlama3170bInstruct,
                "meta-llama/Meta-Llama-3.1-8B-Instruct" => ChatCompletionRequestModel.MetaLlamaMetaLlama318bInstruct,
                "nvidia/Llama-3.1-Nemotron-70B-Instruct" => ChatCompletionRequestModel.NvidiaLlama31Nemotron70bInstruct,
                _ => null,
            };
        }
    }
}