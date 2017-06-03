namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class StringIsNotNullOrEmptyAssertion : Assertion<string>
    {
        internal override bool Check(string value, string name)
        {
            return !String.IsNullOrEmpty(value);
        }

        internal override void CheckAndThrow(string value, string name)
        {
            if (!Check(value, name))
            {
                throw new ArgumentException("String value was null or empty.", name);
            }
        }
    }
}
