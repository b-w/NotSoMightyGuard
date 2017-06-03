namespace NotSoMightyGuard.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public partial class AssertionTests
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsLessThan_Should_Throw_When_Value_Is_Greater_Than_Target()
        {
            // arrange
            int value = 42;

            // act
            Guard.EnsureThat(value)
                .IsLessThan(13)
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsLessThan_Should_Throw_When_Value_Equals_Target()
        {
            // arrange
            int value = 13;

            // act
            Guard.EnsureThat(value)
                .IsLessThan(13)
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsLessThan_Should_Not_Throw_When_Value_Is_Less_Than_Target()
        {
            // arrange
            int value = 13;

            // act
            Guard.EnsureThat(value)
                .IsLessThan(42)
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsGreaterThan_Should_Throw_When_Value_Is_Less_Than_Target()
        {
            // arrange
            int value = 13;

            // act
            Guard.EnsureThat(value)
                .IsGreaterThan(42)
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsGreaterThan_Should_Throw_When_Value_Equals_Target()
        {
            // arrange
            int value = 13;

            // act
            Guard.EnsureThat(value)
                .IsGreaterThan(13)
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsGreaterThan_Should_Not_Throw_When_Value_Is_Greater_Than_Target()
        {
            // arrange
            int value = 42;

            // act
            Guard.EnsureThat(value)
                .IsGreaterThan(13)
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsLessThanOrEqualTo_Should_Throw_When_Value_Is_Greater_Than_Target()
        {
            // arrange
            int value = 42;

            // act
            Guard.EnsureThat(value)
                .IsLessThanOrEqualTo(13)
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsLessThanOrEqual_Should_Not_Throw_When_Value_Equals_Target()
        {
            // arrange
            int value = 13;

            // act
            Guard.EnsureThat(value)
                .IsLessThanOrEqualTo(13)
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsLessThanOrEqualTo_Should_Not_Throw_When_Value_Is_Less_Than_Target()
        {
            // arrange
            int value = 13;

            // act
            Guard.EnsureThat(value)
                .IsLessThanOrEqualTo(42)
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsGreaterThanOrEqualTo_Should_Throw_When_Value_Is_Less_Than_Target()
        {
            // arrange
            int value = 13;

            // act
            Guard.EnsureThat(value)
                .IsGreaterThanOrEqualTo(42)
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsGreaterThanOrEqualTo_Should_Not_Throw_When_Value_Equals_Target()
        {
            // arrange
            int value = 13;

            // act
            Guard.EnsureThat(value)
                .IsGreaterThanOrEqualTo(13)
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsGreaterThanOrEqualTo_Should_Not_Throw_When_Value_Is_Greater_Than_Target()
        {
            // arrange
            int value = 42;

            // act
            Guard.EnsureThat(value)
                .IsGreaterThanOrEqualTo(13)
                .ThrowOnFailure();

            // assert
        }
    }
}
