namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class ValueTypeIsDefaultAssertion<T> : Assertion<T>
        where T : struct
    {
        internal override bool Check(T value)
        {
            return default(T).Equals(value);
        }

        internal override void Throw(T value, string name)
        {
            throw new ArgumentException($"Struct value <{value}> was not equal to default(T).", name);
        }

        internal override void ThrowForNegation(T value, string name)
        {
            throw new ArgumentException("Struct value was equal to default(T).", name);
        }
    }
}
