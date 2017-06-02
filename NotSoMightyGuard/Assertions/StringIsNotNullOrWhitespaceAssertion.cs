namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class StringIsNotNullOrWhitespaceAssertion : Assertion<string>
    {
        internal override void Check(string value, string name)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("String value was null, empty, or consited only of whitespace characters.", name);
            }
        }
    }
}
