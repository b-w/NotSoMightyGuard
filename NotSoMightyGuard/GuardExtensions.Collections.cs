namespace NotSoMightyGuard
{
    using System.Collections.Generic;

    using NotSoMightyGuard.Assertions;

    public static partial class GuardExtensions
    {
        public static AssertionExpression<ICollection<T>> IsEmpty<T>(this GuardExpression<ICollection<T>> source)
        {
            return IsEmpty(new AssertionExpression<ICollection<T>>(source));
        }

        public static AssertionExpression<ICollection<T>> IsEmpty<T>(this AssertionExpression<ICollection<T>> source)
        {
            source.Assertions.Add(new ICollectionIsEmptyAssertion<T>());
            return source;
        }

        public static AssertionExpression<ICollection<T>> IsEmpty<T>(this AssertionNegationExpression<GuardExpression<ICollection<T>>> source)
            where T : class
        {
            return IsEmpty(new AssertionExpression<ICollection<T>>(source.Parent).Not);
        }

        public static AssertionExpression<ICollection<T>> IsEmpty<T>(this AssertionNegationExpression<AssertionExpression<ICollection<T>>> source)
            where T : class
        {
            source.Parent.Assertions.Add(new NegationAssertion<ICollection<T>>(new ICollectionIsEmptyAssertion<T>()));
            return source.Parent;
        }
    }
}
