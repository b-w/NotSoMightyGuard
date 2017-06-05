namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class StringIsNullOrWhitespaceAssertion : Assertion<string>
    {
        internal override bool Check(string value)
        {
            return String.IsNullOrWhiteSpace(value);
        }

        internal override void Throw(string value, string name)
        {
            throw new ArgumentException($"String value <{value}> was not null, empty, or consited only of whitespace characters.", name);
        }

        internal override void ThrowForNegation(string value, string name)
        {
            throw new ArgumentException("String value was null, empty, or consited only of whitespace characters.", name);
        }
    }
}
