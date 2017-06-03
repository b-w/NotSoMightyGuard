namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class ObjectIsNotNullAssertion<T> : Assertion<T>
        where T : class
    {
        internal override bool Check(T value)
        {
            return value != null;
        }

        internal override void CheckAndThrow(T value, string name)
        {
            if (!Check(value))
            {
                throw new ArgumentNullException(name);
            }
        }
    }
}
