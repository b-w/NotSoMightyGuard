namespace NotSoMightyGuard
{
    using NotSoMightyGuard.Assertions;

    public static partial class GuardExtensions
    {
        public static AssertionExpression<T> IsNull<T>(this GuardExpression<T> source)
            where T : class
        {
            return IsNull(new AssertionExpression<T>(source));
        }

        public static AssertionExpression<T> IsNull<T>(this AssertionExpression<T> source)
            where T : class
        {
            source.Assertions.Add(new ObjectIsNullAssertion<T>());
            return source;
        }

        public static AssertionExpression<T> IsNull<T>(this AssertionNegationExpression<GuardExpression<T>> source)
            where T : class
        {
            return IsNull(new AssertionExpression<T>(source.Parent).Not);
        }

        public static AssertionExpression<T> IsNull<T>(this AssertionNegationExpression<AssertionExpression<T>> source)
            where T : class
        {
            source.Parent.Assertions.Add(new NegationAssertion<T>(new ObjectIsNullAssertion<T>()));
            return source.Parent;
        }

        public static AssertionExpression<T?> IsNull<T>(this GuardExpression<T?> source)
            where T : struct
        {
            return IsNull(new AssertionExpression<T?>(source));
        }

        public static AssertionExpression<T?> IsNull<T>(this AssertionExpression<T?> source)
            where T : struct
        {
            source.Assertions.Add(new NullableIsNullAssertion<T>());
            return source;
        }

        public static AssertionExpression<T?> IsNull<T>(this AssertionNegationExpression<GuardExpression<T?>> source)
            where T : struct
        {
            return IsNull(new AssertionExpression<T?>(source.Parent).Not);
        }

        public static AssertionExpression<T?> IsNull<T>(this AssertionNegationExpression<AssertionExpression<T?>> source)
            where T : struct
        {
            source.Parent.Assertions.Add(new NegationAssertion<T?>(new NullableIsNullAssertion<T>()));
            return source.Parent;
        }
    }
}
