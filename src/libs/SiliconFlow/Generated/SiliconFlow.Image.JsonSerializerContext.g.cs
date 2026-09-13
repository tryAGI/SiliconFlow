
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.OneOf<global::SiliconFlow.StableDiffusion35Large, global::SiliconFlow.Flux1Schnell, global::SiliconFlow.ProFlux1Schnell, global::SiliconFlow.Flux1Dev, global::SiliconFlow.StableDiffusion3Medium, global::SiliconFlow.StableDiffusionXlBase10, global::SiliconFlow.StableDiffusion21>), TypeInfoPropertyName = "StableDiffusion21_db7eb062649e1b8c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.OneOf<global::SiliconFlow.StableDiffusion35Large, global::SiliconFlow.Flux1Schnell, global::SiliconFlow.ProFlux1Schnell, global::SiliconFlow.Flux1Dev, global::SiliconFlow.StableDiffusion3Medium, global::SiliconFlow.StableDiffusionXlBase10, global::SiliconFlow.StableDiffusion21>?), TypeInfoPropertyName = "StableDiffusion21_d7a998d303d7ed06")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion35Large))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion35LargeModel), TypeInfoPropertyName = "StableDiffusion35LargeModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion35LargeImageSize), TypeInfoPropertyName = "StableDiffusion35LargeImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.Flux1Schnell))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.Flux1SchnellModel), TypeInfoPropertyName = "Flux1SchnellModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.Flux1SchnellImageSize), TypeInfoPropertyName = "Flux1SchnellImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ProFlux1Schnell))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ProFlux1SchnellModel), TypeInfoPropertyName = "ProFlux1SchnellModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ProFlux1SchnellImageSize), TypeInfoPropertyName = "ProFlux1SchnellImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.Flux1Dev))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.Flux1DevModel), TypeInfoPropertyName = "Flux1DevModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.Flux1DevImageSize), TypeInfoPropertyName = "Flux1DevImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion3Medium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion3MediumModel), TypeInfoPropertyName = "StableDiffusion3MediumModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion3MediumImageSize), TypeInfoPropertyName = "StableDiffusion3MediumImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusionXlBase10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusionXlBase10Model), TypeInfoPropertyName = "StableDiffusionXlBase10Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusionXlBase10ImageSize), TypeInfoPropertyName = "StableDiffusionXlBase10ImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion21))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion21Model), TypeInfoPropertyName = "StableDiffusion21Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion21ImageSize), TypeInfoPropertyName = "StableDiffusion21ImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ImagesGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SiliconFlow.ImagesGenerationResponseImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ImagesGenerationResponseImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ImagesGenerationResponseTimings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion35LargeModel?), TypeInfoPropertyName = "NullableStableDiffusion35LargeModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion35LargeImageSize?), TypeInfoPropertyName = "NullableStableDiffusion35LargeImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.Flux1SchnellModel?), TypeInfoPropertyName = "NullableFlux1SchnellModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.Flux1SchnellImageSize?), TypeInfoPropertyName = "NullableFlux1SchnellImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ProFlux1SchnellModel?), TypeInfoPropertyName = "NullableProFlux1SchnellModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.ProFlux1SchnellImageSize?), TypeInfoPropertyName = "NullableProFlux1SchnellImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.Flux1DevModel?), TypeInfoPropertyName = "NullableFlux1DevModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.Flux1DevImageSize?), TypeInfoPropertyName = "NullableFlux1DevImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion3MediumModel?), TypeInfoPropertyName = "NullableStableDiffusion3MediumModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion3MediumImageSize?), TypeInfoPropertyName = "NullableStableDiffusion3MediumImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusionXlBase10Model?), TypeInfoPropertyName = "NullableStableDiffusionXlBase10Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusionXlBase10ImageSize?), TypeInfoPropertyName = "NullableStableDiffusionXlBase10ImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion21Model?), TypeInfoPropertyName = "NullableStableDiffusion21Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SiliconFlow.StableDiffusion21ImageSize?), TypeInfoPropertyName = "NullableStableDiffusion21ImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SiliconFlow.ImagesGenerationResponseImage>))]
    internal sealed partial class ImageSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ImageSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ImageSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::SiliconFlow.JsonConverters.OneOfJsonConverter<global::SiliconFlow.StableDiffusion35Large, global::SiliconFlow.Flux1Schnell, global::SiliconFlow.ProFlux1Schnell, global::SiliconFlow.Flux1Dev, global::SiliconFlow.StableDiffusion3Medium, global::SiliconFlow.StableDiffusionXlBase10, global::SiliconFlow.StableDiffusion21>());
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
                    typeToConvert == typeof(global::SiliconFlow.StableDiffusion35LargeModel)

                    || typeToConvert == typeof(global::SiliconFlow.StableDiffusion35LargeModel?)

                    || typeToConvert == typeof(global::SiliconFlow.StableDiffusion35LargeImageSize)

                    || typeToConvert == typeof(global::SiliconFlow.StableDiffusion35LargeImageSize?)

                    || typeToConvert == typeof(global::SiliconFlow.Flux1SchnellModel)

                    || typeToConvert == typeof(global::SiliconFlow.Flux1SchnellModel?)

                    || typeToConvert == typeof(global::SiliconFlow.Flux1SchnellImageSize)

                    || typeToConvert == typeof(global::SiliconFlow.Flux1SchnellImageSize?)

                    || typeToConvert == typeof(global::SiliconFlow.ProFlux1SchnellModel)

                    || typeToConvert == typeof(global::SiliconFlow.ProFlux1SchnellModel?)

                    || typeToConvert == typeof(global::SiliconFlow.ProFlux1SchnellImageSize)

                    || typeToConvert == typeof(global::SiliconFlow.ProFlux1SchnellImageSize?)

                    || typeToConvert == typeof(global::SiliconFlow.Flux1DevModel)

                    || typeToConvert == typeof(global::SiliconFlow.Flux1DevModel?)

                    || typeToConvert == typeof(global::SiliconFlow.Flux1DevImageSize)

                    || typeToConvert == typeof(global::SiliconFlow.Flux1DevImageSize?)

                    || typeToConvert == typeof(global::SiliconFlow.StableDiffusion3MediumModel)

                    || typeToConvert == typeof(global::SiliconFlow.StableDiffusion3MediumModel?)

                    || typeToConvert == typeof(global::SiliconFlow.StableDiffusion3MediumImageSize)

                    || typeToConvert == typeof(global::SiliconFlow.StableDiffusion3MediumImageSize?)

                    || typeToConvert == typeof(global::SiliconFlow.StableDiffusionXlBase10Model)

                    || typeToConvert == typeof(global::SiliconFlow.StableDiffusionXlBase10Model?)

                    || typeToConvert == typeof(global::SiliconFlow.StableDiffusionXlBase10ImageSize)

                    || typeToConvert == typeof(global::SiliconFlow.StableDiffusionXlBase10ImageSize?)

                    || typeToConvert == typeof(global::SiliconFlow.StableDiffusion21Model)

                    || typeToConvert == typeof(global::SiliconFlow.StableDiffusion21Model?)

                    || typeToConvert == typeof(global::SiliconFlow.StableDiffusion21ImageSize)

                    || typeToConvert == typeof(global::SiliconFlow.StableDiffusion21ImageSize?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::SiliconFlow.StableDiffusion35LargeModel))
                {
                    return new global::SiliconFlow.JsonConverters.StableDiffusion35LargeModelJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.StableDiffusion35LargeModel?))
                {
                    return new global::SiliconFlow.JsonConverters.StableDiffusion35LargeModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.StableDiffusion35LargeImageSize))
                {
                    return new global::SiliconFlow.JsonConverters.StableDiffusion35LargeImageSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.StableDiffusion35LargeImageSize?))
                {
                    return new global::SiliconFlow.JsonConverters.StableDiffusion35LargeImageSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.Flux1SchnellModel))
                {
                    return new global::SiliconFlow.JsonConverters.Flux1SchnellModelJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.Flux1SchnellModel?))
                {
                    return new global::SiliconFlow.JsonConverters.Flux1SchnellModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.Flux1SchnellImageSize))
                {
                    return new global::SiliconFlow.JsonConverters.Flux1SchnellImageSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.Flux1SchnellImageSize?))
                {
                    return new global::SiliconFlow.JsonConverters.Flux1SchnellImageSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ProFlux1SchnellModel))
                {
                    return new global::SiliconFlow.JsonConverters.ProFlux1SchnellModelJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ProFlux1SchnellModel?))
                {
                    return new global::SiliconFlow.JsonConverters.ProFlux1SchnellModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ProFlux1SchnellImageSize))
                {
                    return new global::SiliconFlow.JsonConverters.ProFlux1SchnellImageSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.ProFlux1SchnellImageSize?))
                {
                    return new global::SiliconFlow.JsonConverters.ProFlux1SchnellImageSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.Flux1DevModel))
                {
                    return new global::SiliconFlow.JsonConverters.Flux1DevModelJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.Flux1DevModel?))
                {
                    return new global::SiliconFlow.JsonConverters.Flux1DevModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.Flux1DevImageSize))
                {
                    return new global::SiliconFlow.JsonConverters.Flux1DevImageSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.Flux1DevImageSize?))
                {
                    return new global::SiliconFlow.JsonConverters.Flux1DevImageSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.StableDiffusion3MediumModel))
                {
                    return new global::SiliconFlow.JsonConverters.StableDiffusion3MediumModelJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.StableDiffusion3MediumModel?))
                {
                    return new global::SiliconFlow.JsonConverters.StableDiffusion3MediumModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.StableDiffusion3MediumImageSize))
                {
                    return new global::SiliconFlow.JsonConverters.StableDiffusion3MediumImageSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.StableDiffusion3MediumImageSize?))
                {
                    return new global::SiliconFlow.JsonConverters.StableDiffusion3MediumImageSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.StableDiffusionXlBase10Model))
                {
                    return new global::SiliconFlow.JsonConverters.StableDiffusionXlBase10ModelJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.StableDiffusionXlBase10Model?))
                {
                    return new global::SiliconFlow.JsonConverters.StableDiffusionXlBase10ModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.StableDiffusionXlBase10ImageSize))
                {
                    return new global::SiliconFlow.JsonConverters.StableDiffusionXlBase10ImageSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.StableDiffusionXlBase10ImageSize?))
                {
                    return new global::SiliconFlow.JsonConverters.StableDiffusionXlBase10ImageSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.StableDiffusion21Model))
                {
                    return new global::SiliconFlow.JsonConverters.StableDiffusion21ModelJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.StableDiffusion21Model?))
                {
                    return new global::SiliconFlow.JsonConverters.StableDiffusion21ModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.StableDiffusion21ImageSize))
                {
                    return new global::SiliconFlow.JsonConverters.StableDiffusion21ImageSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::SiliconFlow.StableDiffusion21ImageSize?))
                {
                    return new global::SiliconFlow.JsonConverters.StableDiffusion21ImageSizeNullableJsonConverter();
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
                    0 => new ImageSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}