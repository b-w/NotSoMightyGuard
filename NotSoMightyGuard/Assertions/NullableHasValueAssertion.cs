namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class NullableHasValueAssertion<T> : Assertion<T?>
        where T : struct
    {
        internal override bool Check(T? value, string name)
        {
            return value != null;
        }

        internal override void CheckAndThrow(T? value, string name)
        {
            if (!Check(value, name))
            {
                throw new ArgumentNullException(name);
            }
        }
    }
}
