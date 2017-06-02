namespace NotSoMightyGuard
{
    using NotSoMightyGuard.Assertions;

    public static class GuardExtensions
    {
        #region null checks

        public static AssertionExpression<T> IsNotNull<T>(this GuardExpression<T> source)
            where T : class
        {
            return IsNotNull(new AssertionExpression<T>(source));
        }

        public static AssertionExpression<T> IsNotNull<T>(this AssertionExpression<T> source)
            where T : class
        {
            source.Assertions.Add(new IsNotNullAssertion<T>());
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

        #endregion

        #region default checks

        public static AssertionExpression<T> IsNotDefault<T>(this GuardExpression<T> source)
            where T : struct
        {
            return IsNotDefault(new AssertionExpression<T>(source));
        }

        public static AssertionExpression<T> IsNotDefault<T>(this AssertionExpression<T> source)
            where T : struct
        {
            source.Assertions.Add(new IsNotDefaultAssertion<T>());
            return source;
        }

        #endregion

        #region string

        public static AssertionExpression<string> IsNotNullOrEmpty(this GuardExpression<string> source)
        {
            return IsNotNullOrEmpty(new AssertionExpression<string>(source));
        }

        public static AssertionExpression<string> IsNotNullOrEmpty(this AssertionExpression<string> source)
        {
            source.Assertions.Add(new StringIsNotNullOrEmptyAssertion());
            return source;
        }

        public static AssertionExpression<string> IsNotNullOrWhitespace(this GuardExpression<string> source)
        {
            return IsNotNullOrWhitespace(new AssertionExpression<string>(source));
        }

        public static AssertionExpression<string> IsNotNullOrWhitespace(this AssertionExpression<string> source)
        {
            source.Assertions.Add(new StringIsNotNullOrWhitespaceAssertion());
            return source;
        }

        #endregion

        public static void ThrowOnFailure<T>(this AssertionExpression<T> source)
        {
            foreach (var assertion in source.Assertions)
            {
                assertion.Check(source.GuardExpression.ArgumentValue, source.GuardExpression.ArgumentName);
            }
        }
    }
}
