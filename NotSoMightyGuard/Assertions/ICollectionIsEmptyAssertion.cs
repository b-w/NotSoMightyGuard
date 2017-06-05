namespace NotSoMightyGuard.Assertions
{
    using System;
    using System.Collections.Generic;

    internal class ICollectionIsEmptyAssertion<T> : Assertion<ICollection<T>>
    {
        internal override bool Check(ICollection<T> value)
        {
            return !(value?.Count > 0);
        }

        internal override void Throw(ICollection<T> value, string name)
        {
            throw new ArgumentException("Collection was not empty.", name);
        }

        internal override void ThrowForNegation(ICollection<T> value, string name)
        {
            throw new ArgumentException("Collection was null or empty.", name);
        }
    }
}
