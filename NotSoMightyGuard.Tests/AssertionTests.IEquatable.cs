namespace NotSoMightyGuard.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public partial class AssertionTests
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_Is_Should_Throw_When_Value_Not_Equal_To_Target()
        {
            // arrange
            int value = 13;

            // act
            Guard.EnsureThat(value)
                .Is(42)
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_Is_Should_Not_Throw_When_Value_Equals_Target()
        {
            // arrange
            int value = 42;

            // act
            Guard.EnsureThat(value)
                .Is(42)
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsNot_Should_Throw_When_Value_Equals_Target()
        {
            // arrange
            int value = 13;

            // act
            Guard.EnsureThat(value)
                .IsNot(13)
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsNot_Should_Not_Throw_When_Value_Not_Equal_To_Target()
        {
            // arrange
            int value = 42;

            // act
            Guard.EnsureThat(value)
                .IsNot(13)
                .ThrowOnFailure();

            // assert
        }
    }
}
