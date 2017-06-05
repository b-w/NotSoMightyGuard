namespace NotSoMightyGuard
{
    using NotSoMightyGuard.Assertions;

    public static partial class GuardExtensions
    {
        public static AssertionExpression<T> IsDefault<T>(this GuardExpression<T> source)
            where T : struct
        {
            return IsNotDefault(new AssertionExpression<T>(source));
        }

        public static AssertionExpression<T> IsNotDefault<T>(this AssertionExpression<T> source)
            where T : struct
        {
            source.Assertions.Add(new ValueTypeIsDefaultAssertion<T>());
            return source;
        }

        public static AssertionExpression<T> IsDefault<T>(this AssertionNegationExpression<GuardExpression<T>> source)
            where T : struct
        {
            return IsNotDefault(new AssertionExpression<T>(source.Parent).Not);
        }

        public static AssertionExpression<T> IsNotDefault<T>(this AssertionNegationExpression<AssertionExpression<T>> source)
            where T : struct
        {
            source.Parent.Assertions.Add(new NegationAssertion<T>(new ValueTypeIsDefaultAssertion<T>()));
            return source.Parent;
        }
    }
}
