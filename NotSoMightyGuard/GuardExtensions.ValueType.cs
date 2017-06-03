namespace NotSoMightyGuard
{
    using NotSoMightyGuard.Assertions;

    public static partial class GuardExtensions
    {
        public static AssertionExpression<T> IsNotDefault<T>(this GuardExpression<T> source)
            where T : struct
        {
            return IsNotDefault(new AssertionExpression<T>(source));
        }

        public static AssertionExpression<T> IsNotDefault<T>(this AssertionExpression<T> source)
            where T : struct
        {
            source.Assertions.Add(new ValueTypeIsNotDefaultAssertion<T>());
            return source;
        }
    }
}
