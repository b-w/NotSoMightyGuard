namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class EnumHasFlagAssertion<T> : Assertion<T>
        where T : struct, IComparable, IConvertible, IFormattable
    {
        internal EnumHasFlagAssertion(T targetValue)
        {
            TargetValue = targetValue;
        }

        internal T TargetValue { get; }

        internal override bool Check(T value)
        {
            var enumValue = value as Enum;
            var flagValue = TargetValue as Enum;

            if (enumValue == null)
            {
                throw new ArgumentException($"Value <{value}> was not a valid Enum.");
            }

            if (flagValue == null)
            {
                throw new ArgumentException($"Value <{TargetValue}> was not a valid Enum.");
            }

            return enumValue.HasFlag(flagValue);
        }

        internal override void Throw(T value, string name)
        {
            throw new ArgumentException($"Value <{value}> did not have flag <{TargetValue}>.", name);
        }

        internal override void ThrowForNegation(T value, string name)
        {
            throw new ArgumentException($"Value <{value}> had flag <{TargetValue}>.", name);
        }
    }
}
