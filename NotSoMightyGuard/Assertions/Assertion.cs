﻿namespace NotSoMightyGuard.Assertions
{
    internal abstract class Assertion<T>
    {
        internal abstract bool Check(T value, string name);

        internal abstract void CheckAndThrow(T value, string name);
    }
}
