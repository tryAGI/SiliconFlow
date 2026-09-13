
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsRequestModel), TypeInfoPropertyName = "EmbeddingsRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsRequestEncodingFormat), TypeInfoPropertyName = "EmbeddingsRequestEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsResponseObject), TypeInfoPropertyName = "EmbeddingsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SiliconFlow.EmbeddingsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsResponseDataItemObject), TypeInfoPropertyName = "EmbeddingsResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsRequestModel?), TypeInfoPropertyName = "NullableEmbeddingsRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsRequestEncodingFormat?), TypeInfoPropertyName = "NullableEmbeddingsRequestEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsResponseObject?), TypeInfoPropertyName = "NullableEmbeddingsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.EmbeddingsResponseDataItemObject?), TypeInfoPropertyName = "NullableEmbeddingsResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SiliconFlow.EmbeddingsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    internal sealed partial class EmbeddingsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmbeddingsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EmbeddingsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::SiliconFlow.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::SiliconFlow.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
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
                    typeToConvert == typeof(global::SiliconFlow.EmbeddingsRequestModel)

                    || typeToConvert == typeof(global::SiliconFlow.EmbeddingsRequestModel?)

                    || typeToConvert == typeof(global::SiliconFlow.EmbeddingsRequestEncodingFormat)

                    || typeToConvert == typeof(global::SiliconFlow.EmbeddingsRequestEncodingFormat?)

                    || typeToConvert == typeof(global::SiliconFlow.EmbeddingsResponseObject)

                    || typeToConvert == typeof(global::SiliconFlow.EmbeddingsResponseObject?)

                    || typeToConvert == typeof(global::SiliconFlow.EmbeddingsResponseDataItemObject)

                    || typeToConvert == typeof(global::SiliconFlow.EmbeddingsResponseDataItemObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::SiliconFlow.EmbeddingsRequestModel))
                {
                    return new global::SiliconFlow.JsonConverters.EmbeddingsRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.EmbeddingsRequestModel?))
                {
                    return new global::SiliconFlow.JsonConverters.EmbeddingsRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.EmbeddingsRequestEncodingFormat))
                {
                    return new global::SiliconFlow.JsonConverters.EmbeddingsRequestEncodingFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.EmbeddingsRequestEncodingFormat?))
                {
                    return new global::SiliconFlow.JsonConverters.EmbeddingsRequestEncodingFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.EmbeddingsResponseObject))
                {
                    return new global::SiliconFlow.JsonConverters.EmbeddingsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.EmbeddingsResponseObject?))
                {
                    return new global::SiliconFlow.JsonConverters.EmbeddingsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.EmbeddingsResponseDataItemObject))
                {
                    return new global::SiliconFlow.JsonConverters.EmbeddingsResponseDataItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.EmbeddingsResponseDataItemObject?))
                {
                    return new global::SiliconFlow.JsonConverters.EmbeddingsResponseDataItemObjectNullableJsonConverter();
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
                    0 => new EmbeddingsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}