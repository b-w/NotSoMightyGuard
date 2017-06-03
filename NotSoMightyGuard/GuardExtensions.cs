﻿namespace NotSoMightyGuard
{
    using System;

    using NotSoMightyGuard.Assertions;

    public static partial class GuardExtensions
    {
        public static AssertionExpression<T> Matches<T>(this GuardExpression<T> source, Predicate<T> predicate)
        {
            return Matches(new AssertionExpression<T>(source), predicate);
        }

        public static AssertionExpression<T> Matches<T>(this AssertionExpression<T> source, Predicate<T> predicate)
        {
            source.Assertions.Add(new PredicateAssertion<T>(predicate));
            return source;
        }

        public static void ThrowOnFailure<T>(this AssertionExpression<T> source)
        {
            foreach (var assertion in source.Assertions)
            {
                assertion.CheckAndThrow(source.GuardExpression.ArgumentValue, source.GuardExpression.ArgumentName);
            }
        }
    }
}
