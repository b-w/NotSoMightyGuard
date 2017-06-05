namespace NotSoMightyGuard.Assertions
{
    internal abstract class Assertion<T>
    {
        internal abstract bool Check(T value);

        internal virtual void CheckAndThrow(T value, string name)
        {
            if (!Check(value))
            {
                Throw(value, name);
            }
        }

        internal abstract void Throw(T value, string name);

        internal abstract void ThrowForNegation(T value, string name);
    }
}
