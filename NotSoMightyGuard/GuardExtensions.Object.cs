namespace NotSoMightyGuard
{
    using NotSoMightyGuard.Assertions;

    public static partial class GuardExtensions
    {
        public static AssertionExpression<T> IsNotNull<T>(this GuardExpression<T> source)
            where T : class
        {
            return IsNotNull(new AssertionExpression<T>(source));
        }

        public static AssertionExpression<T> IsNotNull<T>(this AssertionExpression<T> source)
            where T : class
        {
            source.Assertions.Add(new ObjectIsNotNullAssertion<T>());
            return source;
        }

        public static AssertionExpression<T?> IsNotNull<T>(this GuardExpression<T?> source)
            where T : struct
        {
            return IsNotNull(new AssertionExpression<T?>(source));
        }

        public static AssertionExpression<T?> IsNotNull<T>(this AssertionExpression<T?> source)
            where T : struct
        {
            source.Assertions.Add(new NullableHasValueAssertion<T>());
            return source;
        }
    }
}
