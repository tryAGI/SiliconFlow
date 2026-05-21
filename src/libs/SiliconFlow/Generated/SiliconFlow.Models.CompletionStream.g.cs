#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace SiliconFlow
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CompletionStream : global::System.IEquatable<CompletionStream>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::SiliconFlow.CompletionEvent? Event { get; init; }
#else
        public global::SiliconFlow.CompletionEvent? Event { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Event))]
#endif
        public bool IsEvent => Event != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::SiliconFlow.CompletionEvent? value)
        {
            value = Event;
            return IsEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::SiliconFlow.CompletionEvent PickEvent() => IsEvent
            ? Event!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Event' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionStream(global::SiliconFlow.CompletionEvent value) => new CompletionStream((global::SiliconFlow.CompletionEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::SiliconFlow.CompletionEvent?(CompletionStream @this) => @this.Event;

        /// <summary>
        /// 
        /// </summary>
        public CompletionStream(global::SiliconFlow.CompletionEvent? value)
        {
            Event = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CompletionStream FromEvent(global::SiliconFlow.CompletionEvent? value) => new CompletionStream(value);

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Event as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Event?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::SiliconFlow.CompletionEvent, TResult>? @event = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvent && @event != null)
            {
                return @event(Event!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::SiliconFlow.CompletionEvent>? @event = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvent)
            {
                @event?.Invoke(Event!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::SiliconFlow.CompletionEvent>? @event = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvent)
            {
                @event?.Invoke(Event!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Event,
                typeof(global::SiliconFlow.CompletionEvent),
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
        public bool Equals(CompletionStream other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::SiliconFlow.CompletionEvent?>.Default.Equals(Event, other.Event) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CompletionStream obj1, CompletionStream obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CompletionStream>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CompletionStream obj1, CompletionStream obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CompletionStream o && Equals(o);
        }
    }
}
