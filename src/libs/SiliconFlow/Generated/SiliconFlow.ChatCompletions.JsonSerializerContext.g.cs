
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace SiliconFlow
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.FinishReason), TypeInfoPropertyName = "FinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.UsageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionChoicesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionChoicesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionChoicesDataItemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartTextType), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageType), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrlDetail), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartImageImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestUserMessageContentPart), TypeInfoPropertyName = "ChatCompletionRequestUserMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestModel), TypeInfoPropertyName = "ChatCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageRole), TypeInfoPropertyName = "ChatCompletionRequestMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.OneOf<string, global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionRequestUserMessageContentPart>>), TypeInfoPropertyName = "OneOfStringIListChatCompletionRequestUserMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionRequestUserMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionResponseObject), TypeInfoPropertyName = "ChatCompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionStreamObject), TypeInfoPropertyName = "ChatCompletionStreamObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.FinishReason?), TypeInfoPropertyName = "NullableFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartTextType?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPartTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageType?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPartImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrlDetail?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPartImageImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestUserMessageContentPart?), TypeInfoPropertyName = "NullableChatCompletionRequestUserMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestModel?), TypeInfoPropertyName = "NullableChatCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionRequestMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.OneOf<string, global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionRequestUserMessageContentPart>>?), TypeInfoPropertyName = "NullableOneOfStringIListChatCompletionRequestUserMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionResponseObject?), TypeInfoPropertyName = "NullableChatCompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ChatCompletionStreamObject?), TypeInfoPropertyName = "NullableChatCompletionStreamObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SiliconFlow.ChatCompletionChoicesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SiliconFlow.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.OneOf<string, global::System.Collections.Generic.List<global::SiliconFlow.ChatCompletionRequestUserMessageContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SiliconFlow.ChatCompletionRequestUserMessageContentPart>))]
    internal sealed partial class ChatCompletionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ChatCompletionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ChatCompletionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::SiliconFlow.JsonConverters.ChatCompletionRequestUserMessageContentPartJsonConverter());
            options.Converters.Add(new global::SiliconFlow.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.UsageData, object>());
            options.Converters.Add(new global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.FinishReason?, object>());
            options.Converters.Add(new global::SiliconFlow.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::SiliconFlow.ChatCompletionRequestUserMessageContentPart>>());
            options.Converters.Add(new global::SiliconFlow.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.UsageData, object>());
            options.Converters.Add(new global::SiliconFlow.JsonConverters.AllOfJsonConverter<global::SiliconFlow.FinishReason?, object>());
            options.Converters.Add(new global::SiliconFlow.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::SiliconFlow.FinishReason)

                    || typeToConvert == typeof(global::SiliconFlow.FinishReason?)

                    || typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartTextType)

                    || typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartTextType?)

                    || typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageType)

                    || typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageType?)

                    || typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrlDetail)

                    || typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrlDetail?)

                    || typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestModel)

                    || typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestModel?)

                    || typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestMessageRole)

                    || typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestMessageRole?)

                    || typeToConvert == typeof(global::SiliconFlow.ChatCompletionResponseObject)

                    || typeToConvert == typeof(global::SiliconFlow.ChatCompletionResponseObject?)

                    || typeToConvert == typeof(global::SiliconFlow.ChatCompletionStreamObject)

                    || typeToConvert == typeof(global::SiliconFlow.ChatCompletionStreamObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::SiliconFlow.FinishReason))
                {
                    return new global::SiliconFlow.JsonConverters.FinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.FinishReason?))
                {
                    return new global::SiliconFlow.JsonConverters.FinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartTextType))
                {
                    return new global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartTextType?))
                {
                    return new global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageType))
                {
                    return new global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageType?))
                {
                    return new global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrlDetail))
                {
                    return new global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImageImageUrlDetail?))
                {
                    return new global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestModel))
                {
                    return new global::SiliconFlow.JsonConverters.ChatCompletionRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestModel?))
                {
                    return new global::SiliconFlow.JsonConverters.ChatCompletionRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestMessageRole))
                {
                    return new global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ChatCompletionRequestMessageRole?))
                {
                    return new global::SiliconFlow.JsonConverters.ChatCompletionRequestMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ChatCompletionResponseObject))
                {
                    return new global::SiliconFlow.JsonConverters.ChatCompletionResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ChatCompletionResponseObject?))
                {
                    return new global::SiliconFlow.JsonConverters.ChatCompletionResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ChatCompletionStreamObject))
                {
                    return new global::SiliconFlow.JsonConverters.ChatCompletionStreamObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ChatCompletionStreamObject?))
                {
                    return new global::SiliconFlow.JsonConverters.ChatCompletionStreamObjectNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ChatCompletionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}