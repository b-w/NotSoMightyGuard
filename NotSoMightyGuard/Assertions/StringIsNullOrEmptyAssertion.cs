namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class StringIsNullOrEmptyAssertion : Assertion<string>
    {
        internal override bool Check(string value)
        {
            return String.IsNullOrEmpty(value);
        }

        internal override void Throw(string value, string name)
        {
            throw new ArgumentException($"String value <{value}> was not null or empty.", name);
        }

        internal override void ThrowForNegation(string value, string name)
        {
            throw new ArgumentException("String value was null or empty.", name);
        }
    }
}
