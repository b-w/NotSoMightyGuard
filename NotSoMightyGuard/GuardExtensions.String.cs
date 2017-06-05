namespace NotSoMightyGuard
{
    using NotSoMightyGuard.Assertions;

    public static partial class GuardExtensions
    {
        public static AssertionExpression<string> IsNullOrEmpty(this GuardExpression<string> source)
        {
            return IsNullOrEmpty(new AssertionExpression<string>(source));
        }

        public static AssertionExpression<string> IsNullOrEmpty(this AssertionExpression<string> source)
        {
            source.Assertions.Add(new StringIsNullOrEmptyAssertion());
            return source;
        }

        public static AssertionExpression<string> IsNullOrEmpty(this AssertionNegationExpression<GuardExpression<string>> source)
        {
            return IsNullOrEmpty(new AssertionExpression<string>(source.Parent).Not);
        }

        public static AssertionExpression<string> IsNullOrEmpty(this AssertionNegationExpression<AssertionExpression<string>> source)
        {
            source.Parent.Assertions.Add(new NegationAssertion<string>(new StringIsNullOrEmptyAssertion()));
            return source.Parent;
        }

        public static AssertionExpression<string> IsNullOrWhitespace(this GuardExpression<string> source)
        {
            return IsNullOrWhitespace(new AssertionExpression<string>(source));
        }

        public static AssertionExpression<string> IsNullOrWhitespace(this AssertionExpression<string> source)
        {
            source.Assertions.Add(new StringIsNullOrWhitespaceAssertion());
            return source;
        }

        public static AssertionExpression<string> IsNullOrWhitespace(this AssertionNegationExpression<GuardExpression<string>> source)
        {
            return IsNullOrWhitespace(new AssertionExpression<string>(source.Parent).Not);
        }

        public static AssertionExpression<string> IsNullOrWhitespace(this AssertionNegationExpression<AssertionExpression<string>> source)
        {
            source.Parent.Assertions.Add(new NegationAssertion<string>(new StringIsNullOrWhitespaceAssertion()));
            return source.Parent;
        }
    }
}
