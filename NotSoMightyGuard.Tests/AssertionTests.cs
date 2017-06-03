namespace NotSoMightyGuard.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using NotSoMightyGuard;

    [TestClass]
    public partial class AssertionTests
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_Matches_Should_Throw_When_Value_Does_Not_Match_Predicate()
        {
            // arrange
            int value = 13;

            // act
            Guard.EnsureThat(value)
                .Matches(x => x == 42)
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_Matches_Should_Not_Throw_When_Value_Matches_Predicate()
        {
            // arrange
            int value = 42;

            // act
            Guard.EnsureThat(value)
                .Matches(x => x == 42)
                .ThrowOnFailure();

            // assert
        }
    }
}
