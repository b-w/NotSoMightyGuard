namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class StringIsNotNullOrWhitespaceAssertion : Assertion<string>
    {
        internal override bool Check(string value, string name)
        {
            return !String.IsNullOrWhiteSpace(value);
        }

        internal override void CheckAndThrow(string value, string name)
        {
            if (!Check(value, name))
            {
                throw new ArgumentException("String value was null, empty, or consited only of whitespace characters.", name);
            }
        }
    }
}
