namespace NotSoMightyGuard
{
    using System;

    using NotSoMightyGuard.Assertions;

    public static partial class GuardExtensions
    {
        public static AssertionExpression<T> IsValidEnum<T>(this GuardExpression<T> source)
            where T : struct, IComparable, IConvertible, IFormattable
        {
            return IsValidEnum(new AssertionExpression<T>(source));
        }

        public static AssertionExpression<T> IsValidEnum<T>(this AssertionExpression<T> source)
            where T : struct, IComparable, IConvertible, IFormattable
        {
            source.Assertions.Add(new EnumIsDefinedAssertion<T>());
            return source;
        }

        public static AssertionExpression<T> HasFlag<T>(this GuardExpression<T> source, T flag)
            where T : struct, IComparable, IConvertible, IFormattable
        {
            return HasFlag(new AssertionExpression<T>(source), flag);
        }

        public static AssertionExpression<T> HasFlag<T>(this AssertionExpression<T> source, T flag)
            where T : struct, IComparable, IConvertible, IFormattable
        {
            source.Assertions.Add(new EnumHasFlagAssertion<T>(flag));
            return source;
        }
    }
}
