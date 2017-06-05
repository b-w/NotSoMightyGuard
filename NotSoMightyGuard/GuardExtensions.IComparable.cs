namespace NotSoMightyGuard
{
    using System;

    using NotSoMightyGuard.Assertions;

    public static partial class GuardExtensions
    {
        public static AssertionExpression<T> IsLessThan<T>(this GuardExpression<T> source, T value)
            where T : IComparable<T>
        {
            return IsLessThan(new AssertionExpression<T>(source), value);
        }

        public static AssertionExpression<T> IsLessThan<T>(this AssertionExpression<T> source, T value)
            where T : IComparable<T>
        {
            source.Assertions.Add(new IComparableIsLessThanAssertion<T>(value));
            return source;
        }

        public static AssertionExpression<T> IsLessThan<T>(this AssertionNegationExpression<GuardExpression<T>> source, T value)
            where T : IComparable<T>
        {
            return IsLessThan(new AssertionExpression<T>(source.Parent).Not, value);
        }

        public static AssertionExpression<T> IsLessThan<T>(this AssertionNegationExpression<AssertionExpression<T>> source, T value)
            where T : IComparable<T>
        {
            source.Parent.Assertions.Add(new NegationAssertion<T>(new IComparableIsLessThanAssertion<T>(value)));
            return source.Parent;
        }

        public static AssertionExpression<T> IsGreaterThan<T>(this GuardExpression<T> source, T value)
            where T : IComparable<T>
        {
            return IsGreaterThan(new AssertionExpression<T>(source), value);
        }

        public static AssertionExpression<T> IsGreaterThan<T>(this AssertionExpression<T> source, T value)
            where T : IComparable<T>
        {
            source.Assertions.Add(new IComparableIsGreaterThanAssertion<T>(value));
            return source;
        }

        public static AssertionExpression<T> IsGreaterThan<T>(this AssertionNegationExpression<GuardExpression<T>> source, T value)
            where T : IComparable<T>
        {
            return IsGreaterThan(new AssertionExpression<T>(source.Parent).Not, value);
        }

        public static AssertionExpression<T> IsGreaterThan<T>(this AssertionNegationExpression<AssertionExpression<T>> source, T value)
            where T : IComparable<T>
        {
            source.Parent.Assertions.Add(new NegationAssertion<T>(new IComparableIsGreaterThanAssertion<T>(value)));
            return source.Parent;
        }

        public static AssertionExpression<T> IsLessThanOrEqualTo<T>(this GuardExpression<T> source, T value)
            where T : IComparable<T>
        {
            return IsLessThanOrEqualTo(new AssertionExpression<T>(source), value);
        }

        public static AssertionExpression<T> IsLessThanOrEqualTo<T>(this AssertionExpression<T> source, T value)
            where T : IComparable<T>
        {
            source.Assertions.Add(new IComparableIsLessThanOrEqualToAssertion<T>(value));
            return source;
        }

        public static AssertionExpression<T> IsLessThanOrEqualTo<T>(this AssertionNegationExpression<GuardExpression<T>> source, T value)
            where T : IComparable<T>
        {
            return IsLessThanOrEqualTo(new AssertionExpression<T>(source.Parent).Not, value);
        }

        public static AssertionExpression<T> IsLessThanOrEqualTo<T>(this AssertionNegationExpression<AssertionExpression<T>> source, T value)
            where T : IComparable<T>
        {
            source.Parent.Assertions.Add(new NegationAssertion<T>(new IComparableIsLessThanOrEqualToAssertion<T>(value)));
            return source.Parent;
        }

        public static AssertionExpression<T> IsGreaterThanOrEqualTo<T>(this GuardExpression<T> source, T value)
            where T : IComparable<T>
        {
            return IsGreaterThanOrEqualTo(new AssertionExpression<T>(source), value);
        }

        public static AssertionExpression<T> IsGreaterThanOrEqualTo<T>(this AssertionExpression<T> source, T value)
            where T : IComparable<T>
        {
            source.Assertions.Add(new IComparableIsGreaterThanOrEqualToAssertion<T>(value));
            return source;
        }

        public static AssertionExpression<T> IsGreaterThanOrEqualTo<T>(this AssertionNegationExpression<GuardExpression<T>> source, T value)
            where T : IComparable<T>
        {
            return IsGreaterThanOrEqualTo(new AssertionExpression<T>(source.Parent).Not, value);
        }

        public static AssertionExpression<T> IsGreaterThanOrEqualTo<T>(this AssertionNegationExpression<AssertionExpression<T>> source, T value)
            where T : IComparable<T>
        {
            source.Parent.Assertions.Add(new NegationAssertion<T>(new IComparableIsGreaterThanOrEqualToAssertion<T>(value)));
            return source.Parent;
        }
    }
}
