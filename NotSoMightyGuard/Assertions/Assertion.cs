namespace NotSoMightyGuard.Assertions
{
    internal abstract class Assertion<T>
    {
        internal abstract void Check(T value, string name);
    }
}
