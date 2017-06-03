namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class PredicateAssertion<T> : Assertion<T>
    {
        internal PredicateAssertion(Predicate<T> predicate)
        {
            Predicate = predicate;
        }

        internal Predicate<T> Predicate { get; }

        internal override bool Check(T value)
        {
            return Predicate(value);
        }

        internal override void CheckAndThrow(T value, string name)
        {
            if (!Check(value))
            {
                throw new ArgumentException($"Value <{value}> did not match predicate.", name);
            }
        }
    }
}
