namespace NotSoMightyGuard
{
    using NotSoMightyGuard.Assertions;

    public static partial class GuardExtensions
    {
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
    }
}
