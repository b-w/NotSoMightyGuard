namespace NotSoMightyGuard
{
    public class GuardExpression<T>
    {
        internal GuardExpression(T argumentValue)
            : this(argumentValue, "value")
        {
        }

        internal GuardExpression(T argumentValue, string argumentName)
        {
            ArgumentValue = argumentValue;
            ArgumentName = argumentName;
        }

        internal T ArgumentValue { get; }

        internal string ArgumentName { get; }
    }
}
