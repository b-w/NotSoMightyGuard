namespace NotSoMightyGuard.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public partial class AssertionTests
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsDefault_Should_Throw_When_Given_Valid_Value()
        {
            // arrange
            int value = 42;

            // act
            Guard.EnsureThat(value)
                .IsDefault()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsDefault_Should_Not_Throw_When_Given_Default_Value()
        {
            // arrange
            int value = default(int);

            // act
            Guard.EnsureThat(value)
                .IsDefault()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_Not_IsDefault_Should_Not_Throw_When_Given_Valid_Value()
        {
            // arrange
            int value = 42;

            // act
            Guard.EnsureThat(value)
                .Not.IsDefault()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_Not_IsDefault_Should_Throw_When_Given_Default_Value()
        {
            // arrange
            int value = default(int);

            // act
            Guard.EnsureThat(value)
                .Not.IsDefault()
                .ThrowOnFailure();

            // assert
        }
    }
}
