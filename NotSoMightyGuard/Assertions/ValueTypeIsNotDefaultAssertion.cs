namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class ValueTypeIsNotDefaultAssertion<T> : Assertion<T>
        where T : struct
    {
        internal override bool Check(T value, string name)
        {
            return !default(T).Equals(value);
        }

        internal override void CheckAndThrow(T value, string name)
        {
            if (!Check(value, name))
            {
                throw new ArgumentException("Struct value was default(T).", name);
            }
        }
    }
}
