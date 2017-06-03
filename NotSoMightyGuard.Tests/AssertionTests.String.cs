namespace NotSoMightyGuard.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public partial class AssertionTests
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsNotNullOrEmpty_Should_Throw_When_Given_Null_String()
        {
            // arrange
            string value = null;

            // act
            Guard.EnsureThat(value)
                .IsNotNullOrEmpty()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsNotNullOrEmpty_Should_Throw_When_Given_Empty_String()
        {
            // arrange
            string value = string.Empty;

            // act
            Guard.EnsureThat(value)
                .IsNotNullOrEmpty()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsNotNullOrEmpty_Should_Not_Throw_When_Given_Valid_String_Value()
        {
            // arrange
            string value = "42";

            // act
            Guard.EnsureThat(value)
                .IsNotNullOrEmpty()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsNotNullOrWhitespace_Should_Throw_When_Given_Null_String()
        {
            // arrange
            string value = null;

            // act
            Guard.EnsureThat(value)
                .IsNotNullOrWhitespace()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsNotNullOrWhitespace_Should_Throw_When_Given_Empty_String()
        {
            // arrange
            string value = string.Empty;

            // act
            Guard.EnsureThat(value)
                .IsNotNullOrWhitespace()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsNotNullOrWhitespace_Should_Throw_When_Given_Whitespace_String()
        {
            // arrange
            string value = "   ";

            // act
            Guard.EnsureThat(value)
                .IsNotNullOrWhitespace()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsNotNullOrWhitespace_Should_Not_Throw_When_Given_Valid_String_Value()
        {
            // arrange
            string value = "42";

            // act
            Guard.EnsureThat(value)
                .IsNotNullOrWhitespace()
                .ThrowOnFailure();

            // assert
        }
    }
}
