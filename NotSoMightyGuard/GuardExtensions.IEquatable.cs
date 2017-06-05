namespace NotSoMightyGuard
{
    using System;

    using NotSoMightyGuard.Assertions;

    public static partial class GuardExtensions
    {
        public static AssertionExpression<T> Is<T>(this GuardExpression<T> source, T value)
            where T : IEquatable<T>
        {
            return Is(new AssertionExpression<T>(source), value);
        }

        public static AssertionExpression<T> Is<T>(this AssertionExpression<T> source, T value)
            where T : IEquatable<T>
        {
            source.Assertions.Add(new IEquatableIsAssertion<T>(value));
            return source;
        }

        public static AssertionExpression<T> Is<T>(this AssertionNegationExpression<GuardExpression<T>> source, T value)
            where T : IEquatable<T>
        {
            return Is(new AssertionExpression<T>(source.Parent).Not, value);
        }

        public static AssertionExpression<T> Is<T>(this AssertionNegationExpression<AssertionExpression<T>> source, T value)
            where T : IEquatable<T>
        {
            source.Parent.Assertions.Add(new NegationAssertion<T>(new IEquatableIsAssertion<T>(value)));
            return source.Parent;
        }
    }
}
