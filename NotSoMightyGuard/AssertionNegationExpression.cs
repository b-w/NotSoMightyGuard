namespace NotSoMightyGuard
{
    public class AssertionNegationExpression<T>
    {
        internal AssertionNegationExpression(T parent)
        {
            Parent = parent;
        }

        internal T Parent { get; }
    }
}
