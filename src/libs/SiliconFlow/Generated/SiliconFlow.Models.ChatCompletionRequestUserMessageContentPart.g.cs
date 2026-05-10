#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestUserMessageContentPart : global::System.IEquatable<ChatCompletionRequestUserMessageContentPart>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::SiliconFlow.ChatCompletionRequestMessageContentPartText? TextContentPart { get; init; }
#else
        public global::SiliconFlow.ChatCompletionRequestMessageContentPartText? TextContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextContentPart))]
#endif
        public bool IsTextContentPart => TextContentPart != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextContentPart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::SiliconFlow.ChatCompletionRequestMessageContentPartText? value)
        {
            value = TextContentPart;
            return IsTextContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::SiliconFlow.ChatCompletionRequestMessageContentPartImage? ImageContentPart { get; init; }
#else
        public global::SiliconFlow.ChatCompletionRequestMessageContentPartImage? ImageContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageContentPart))]
#endif
        public bool IsImageContentPart => ImageContentPart != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageContentPart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::SiliconFlow.ChatCompletionRequestMessageContentPartImage? value)
        {
            value = ImageContentPart;
            return IsImageContentPart;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::SiliconFlow.ChatCompletionRequestMessageContentPartText value) => new ChatCompletionRequestUserMessageContentPart((global::SiliconFlow.ChatCompletionRequestMessageContentPartText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::SiliconFlow.ChatCompletionRequestMessageContentPartText?(ChatCompletionRequestUserMessageContentPart @this) => @this.TextContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::SiliconFlow.ChatCompletionRequestMessageContentPartText? value)
        {
            TextContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatCompletionRequestUserMessageContentPart FromTextContentPart(global::SiliconFlow.ChatCompletionRequestMessageContentPartText? value) => new ChatCompletionRequestUserMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::SiliconFlow.ChatCompletionRequestMessageContentPartImage value) => new ChatCompletionRequestUserMessageContentPart((global::SiliconFlow.ChatCompletionRequestMessageContentPartImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::SiliconFlow.ChatCompletionRequestMessageContentPartImage?(ChatCompletionRequestUserMessageContentPart @this) => @this.ImageContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::SiliconFlow.ChatCompletionRequestMessageContentPartImage? value)
        {
            ImageContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatCompletionRequestUserMessageContentPart FromImageContentPart(global::SiliconFlow.ChatCompletionRequestMessageContentPartImage? value) => new ChatCompletionRequestUserMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(
            global::SiliconFlow.ChatCompletionRequestMessageContentPartText? textContentPart,
            global::SiliconFlow.ChatCompletionRequestMessageContentPartImage? imageContentPart
            )
        {
            TextContentPart = textContentPart;
            ImageContentPart = imageContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageContentPart as object ??
            TextContentPart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextContentPart?.ToString() ??
            ImageContentPart?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextContentPart && !IsImageContentPart || !IsTextContentPart && IsImageContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::SiliconFlow.ChatCompletionRequestMessageContentPartText, TResult>? textContentPart = null,
            global::System.Func<global::SiliconFlow.ChatCompletionRequestMessageContentPartImage, TResult>? imageContentPart = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextContentPart && textContentPart != null)
            {
                return textContentPart(TextContentPart!);
            }
            else if (IsImageContentPart && imageContentPart != null)
            {
                return imageContentPart(ImageContentPart!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::SiliconFlow.ChatCompletionRequestMessageContentPartText>? textContentPart = null,

            global::System.Action<global::SiliconFlow.ChatCompletionRequestMessageContentPartImage>? imageContentPart = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextContentPart)
            {
                textContentPart?.Invoke(TextContentPart!);
            }
            else if (IsImageContentPart)
            {
                imageContentPart?.Invoke(ImageContentPart!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::SiliconFlow.ChatCompletionRequestMessageContentPartText>? textContentPart = null,
            global::System.Action<global::SiliconFlow.ChatCompletionRequestMessageContentPartImage>? imageContentPart = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextContentPart)
            {
                textContentPart?.Invoke(TextContentPart!);
            }
            else if (IsImageContentPart)
            {
                imageContentPart?.Invoke(ImageContentPart!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextContentPart,
                typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartText),
                ImageContentPart,
                typeof(global::SiliconFlow.ChatCompletionRequestMessageContentPartImage),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ChatCompletionRequestUserMessageContentPart other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::SiliconFlow.ChatCompletionRequestMessageContentPartText?>.Default.Equals(TextContentPart, other.TextContentPart) &&
                global::System.Collections.Generic.EqualityComparer<global::SiliconFlow.ChatCompletionRequestMessageContentPartImage?>.Default.Equals(ImageContentPart, other.ImageContentPart) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestUserMessageContentPart obj1, ChatCompletionRequestUserMessageContentPart obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestUserMessageContentPart>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestUserMessageContentPart obj1, ChatCompletionRequestUserMessageContentPart obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestUserMessageContentPart o && Equals(o);
        }
    }
}
