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

        public static AssertionExpression<T> IsNot<T>(this GuardExpression<T> source, T value)
            where T : IEquatable<T>
        {
            return IsNot(new AssertionExpression<T>(source), value);
        }

        public static AssertionExpression<T> IsNot<T>(this AssertionExpression<T> source, T value)
            where T : IEquatable<T>
        {
            source.Assertions.Add(new IEquatableIsNotAssertion<T>(value));
            return source;
        }
    }
}
