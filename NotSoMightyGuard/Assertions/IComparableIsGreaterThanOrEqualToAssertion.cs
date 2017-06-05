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

        internal override bool Check(T value)
        {
            return value.CompareTo(TargetValue) >= 0;
        }

        internal override void Throw(T value, string name)
        {
            throw new ArgumentException($"Value <{value}> was not greater than or equal to <{TargetValue}>.", name);
        }

        internal override void ThrowForNegation(T value, string name)
        {
            throw new ArgumentException($"Value <{value}> was greater than or equal to <{TargetValue}>.", name);
        }
    }
}
