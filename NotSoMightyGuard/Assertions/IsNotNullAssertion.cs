namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class IsNotNullAssertion<T> : Assertion<T>
        where T : class
    {
        internal override void Check(T value, string name)
        {
            if (value == null)
            {
                throw new ArgumentNullException(name);
            }
        }
    }
}
