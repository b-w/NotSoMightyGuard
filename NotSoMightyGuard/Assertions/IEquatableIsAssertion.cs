namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class IEquatableIsAssertion<T> : Assertion<T>
        where T : IEquatable<T>
    {
        internal IEquatableIsAssertion(T targetValue)
        {
            TargetValue = targetValue;
        }

        internal T TargetValue { get; }

        internal override bool Check(T value)
        {
            return value.Equals(other: TargetValue);
        }

        internal override void CheckAndThrow(T value, string name)
        {
            if (!Check(value))
            {
                throw new ArgumentException($"Value <{value}> was not equal to <{TargetValue}>.", name);
            }
        }
    }
}
