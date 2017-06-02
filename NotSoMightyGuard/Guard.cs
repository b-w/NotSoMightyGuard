namespace NotSoMightyGuard
{
    public static class Guard
    {
        public static GuardExpression<T> EnsureThat<T>(T value)
        {
            return new GuardExpression<T>(value);
        }

        public static GuardExpression<T> EnsureThat<T>(T value, string name)
        {
            return new GuardExpression<T>(value, name);
        }
    }
}
