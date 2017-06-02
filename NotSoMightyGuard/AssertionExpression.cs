namespace NotSoMightyGuard
{
    using System.Collections.Generic;

    using NotSoMightyGuard.Assertions;

    public class AssertionExpression<T>
    {
        internal AssertionExpression(GuardExpression<T> guardExpression)
        {
            GuardExpression = guardExpression;
        }

        internal GuardExpression<T> GuardExpression { get; }

        internal ICollection<Assertion<T>> Assertions { get; } = new List<Assertion<T>>();
    }
}
