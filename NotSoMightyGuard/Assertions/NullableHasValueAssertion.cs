namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class NullableHasValueAssertion<T> : Assertion<T?>
        where T : struct
    {
        internal override void Check(T? value, string name)
        {
            if (value == null)
            {
                throw new ArgumentNullException(name);
            }
        }
    }
}
