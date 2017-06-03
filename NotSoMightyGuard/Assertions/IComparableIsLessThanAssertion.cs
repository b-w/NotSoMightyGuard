namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class IComparableIsLessThanAssertion<T> : Assertion<T>
        where T : IComparable<T>
    {
        internal IComparableIsLessThanAssertion(T targetValue)
        {
            TargetValue = targetValue;
        }

        internal T TargetValue { get; }

        internal override bool Check(T value)
        {
            return value.CompareTo(TargetValue) < 0;
        }

        internal override void CheckAndThrow(T value, string name)
        {
            if (!Check(value))
            {
                throw new ArgumentException($"Value <{value}> was not less than <{TargetValue}>.", name);
            }
        }
    }
}
