namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class ValueTypeIsNotDefaultAssertion<T> : Assertion<T>
        where T : struct
    {
        internal override void Check(T value, string name)
        {
            if (default(T).Equals(value))
            {
                throw new ArgumentException("Struct value was default(T).", name);
            }
        }
    }
}
