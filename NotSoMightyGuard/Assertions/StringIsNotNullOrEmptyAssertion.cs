namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class StringIsNotNullOrEmptyAssertion : Assertion<string>
    {
        internal override void Check(string value, string name)
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("String value was null or empty.", name);
            }
        }
    }
}
