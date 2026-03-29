# CLAUDE.md -- SiliconFlow SDK

## Overview

Auto-generated C# SDK for [SiliconFlow](https://siliconflow.cn/) -- a unified AI cloud inference platform offering text, image, audio, and video models from multiple providers (DeepSeek, Qwen, Llama, Stable Diffusion, FLUX, etc.).
OpenAPI spec from `https://raw.githubusercontent.com/siliconflow/siliconcloud/main/openapi.yaml`.

## Build & Test

```bash
dotnet build SiliconFlow.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth. Get your API key from [SiliconFlow Console](https://cloud.siliconflow.cn/).

```csharp
var client = new SiliconFlowClient(apiKey); // SILICONFLOW_API_KEY env var
```

## Key Files

- `src/libs/SiliconFlow/openapi.yaml` -- OpenAPI spec
- `src/libs/SiliconFlow/generate.sh` -- Regeneration script
- `src/libs/SiliconFlow/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/SiliconFlow/Extensions/SiliconFlowClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-client Pattern

```csharp
var client = new SiliconFlowClient(apiKey);

// Chat Completions (OpenAI-compatible)
client.ChatCompletions.ChatCompletionsAsync(request)

// Embeddings (OpenAI-compatible)
client.Embeddings.CreateEmbeddingAsync(request)

// Rerank -- reorder documents by relevance
client.Rerank.CreateRerankAsync(request)

// Image Generation -- FLUX, Stable Diffusion models
client.Image.ImageGenerationAsync(request)

// Audio -- TTS and STT
client.Audio.CreateSpeechAsync(request)
client.Audio.CreateAudioTranscriptionsAsync(request)

// Models -- list available models with type/sub_type filters
client.Models.RetrieveAListOfModelsAsync()

// User Info -- account balance and status
client.UserInfo.UserInfoAsync()

// Voice Upload -- upload custom TTS voices
client.UploadAudioVoiceAsync(request)
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsRerankTool()` -- Rerank documents by relevance to a search query
- `AsTextToImageTool()` -- Generate images from text prompts
- `AsListModelsTool()` -- List all available AI models
- `AsGetUserInfoTool()` -- Get user account info and balance

## OpenAI-Compatible Endpoints

Chat completions and embeddings are OpenAI-compatible. For those, use `CustomProviders.SiliconFlow()` from `tryAGI.OpenAI` instead of this SDK:

```csharp
using tryAGI.OpenAI;
var client = CustomProviders.SiliconFlow(apiKey);
```

Use this standalone SDK for unique endpoints: rerank, image generation, audio, models, user info.
