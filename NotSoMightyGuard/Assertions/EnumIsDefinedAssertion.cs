namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class EnumIsDefinedAssertion<T> : Assertion<T>
        where T : struct, IComparable, IConvertible, IFormattable
    {
        internal override bool Check(T value)
        {
            return Enum.IsDefined(typeof(T), value);
        }

        internal override void CheckAndThrow(T value, string name)
        {
            if (!Check(value))
            {
                throw new ArgumentException($"Value <{value}> is not defined for Enum of type <{typeof(T)}>.", name);
            }
        }
    }
}
