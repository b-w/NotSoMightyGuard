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

        internal override void Throw(T value, string name)
        {
            throw new ArgumentException($"Value <{value}> did not match predicate.", name);
        }

        internal override void ThrowForNegation(T value, string name)
        {
            throw new ArgumentException($"Value <{value}> matched predicate.", name);
        }
    }
}
