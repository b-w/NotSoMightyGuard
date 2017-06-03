namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class StringIsNotNullOrEmptyAssertion : Assertion<string>
    {
        internal override bool Check(string value)
        {
            return !String.IsNullOrEmpty(value);
        }

        internal override void CheckAndThrow(string value, string name)
        {
            if (!Check(value))
            {
                throw new ArgumentException("String value was null or empty.", name);
            }
        }
    }
}
