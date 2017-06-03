namespace NotSoMightyGuard
{
    using NotSoMightyGuard.Assertions;

    public static partial class GuardExtensions
    {
        public static void ThrowOnFailure<T>(this AssertionExpression<T> source)
        {
            foreach (var assertion in source.Assertions)
            {
                assertion.CheckAndThrow(source.GuardExpression.ArgumentValue, source.GuardExpression.ArgumentName);
            }
        }
    }
}
