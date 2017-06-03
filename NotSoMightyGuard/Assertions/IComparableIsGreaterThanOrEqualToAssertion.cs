namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class IComparableIsGreaterThanOrEqualToAssertion<T> : Assertion<T>
        where T : IComparable<T>
    {
        internal IComparableIsGreaterThanOrEqualToAssertion(T targetValue)
        {
            TargetValue = targetValue;
        }

        internal T TargetValue { get; }

        internal override bool Check(T value, string name)
        {
            return value.CompareTo(TargetValue) >= 0;
        }

        internal override void CheckAndThrow(T value, string name)
        {
            if (!Check(value, name))
            {
                throw new ArgumentException($"Value was not greater than or equal to {TargetValue}.", name);
            }
        }
    }
}
