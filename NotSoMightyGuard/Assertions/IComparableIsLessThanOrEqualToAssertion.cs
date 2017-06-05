namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class IComparableIsLessThanOrEqualToAssertion<T> : Assertion<T>
        where T : IComparable<T>
    {
        internal IComparableIsLessThanOrEqualToAssertion(T targetValue)
        {
            TargetValue = targetValue;
        }

        internal T TargetValue { get; }

        internal override bool Check(T value)
        {
            return value.CompareTo(TargetValue) <= 0;
        }

        internal override void Throw(T value, string name)
        {
            throw new ArgumentException($"Value <{value}> was not less than or equal to <{TargetValue}>.", name);
        }

        internal override void ThrowForNegation(T value, string name)
        {
            throw new ArgumentException($"Value <{value}> was less than or equal to <{TargetValue}>.", name);
        }
    }
}
