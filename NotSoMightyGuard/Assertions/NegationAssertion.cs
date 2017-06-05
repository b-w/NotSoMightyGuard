namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class NegationAssertion<T> : Assertion<T>
    {
        internal NegationAssertion(Assertion<T> underlyingAssertion)
        {
            UnderlyingAssertion = underlyingAssertion;
        }

        internal Assertion<T> UnderlyingAssertion { get; }

        internal override bool Check(T value)
        {
            return !UnderlyingAssertion.Check(value);
        }

        internal override void CheckAndThrow(T value, string name)
        {
            if (!Check(value))
            {
                UnderlyingAssertion.ThrowForNegation(value, name);
            }
        }

        internal override void Throw(T value, string name)
        {
            throw new InvalidOperationException($"Method {nameof(NegationAssertion<T>)}.{nameof(Throw)} should never be called. This is likely a bug in NotSoMightyGuard.");
        }

        internal override void ThrowForNegation(T value, string name)
        {
            throw new InvalidOperationException($"Method {nameof(NegationAssertion<T>)}.{nameof(ThrowForNegation)} should never be called. This is likely a bug in NotSoMightyGuard.");
        }
    }
}
