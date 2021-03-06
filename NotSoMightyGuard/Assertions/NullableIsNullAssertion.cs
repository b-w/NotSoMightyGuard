﻿namespace NotSoMightyGuard.Assertions
{
    using System;

    internal class NullableIsNullAssertion<T> : Assertion<T?>
        where T : struct
    {
        internal override bool Check(T? value)
        {
            return value == null;
        }

        internal override void Throw(T? value, string name)
        {
            throw new ArgumentException($"Value <{value}> was not null.", name);
        }

        internal override void ThrowForNegation(T? value, string name)
        {
            throw new ArgumentNullException(name);
        }
    }
}
