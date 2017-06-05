namespace NotSoMightyGuard.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public partial class AssertionTests
    {
        [TestMethod]
        public void Guard_IsNullOrEmpty_Should_Not_Throw_When_Given_Null_String()
        {
            // arrange
            string value = null;

            // act
            Guard.EnsureThat(value)
                .IsNullOrEmpty()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsNullOrEmpty_Should_Not_Throw_When_Given_Empty_String()
        {
            // arrange
            string value = string.Empty;

            // act
            Guard.EnsureThat(value)
                .IsNullOrEmpty()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsNullOrEmpty_Should_Throw_When_Given_Non_Empty_String_Value()
        {
            // arrange
            string value = "42";

            // act
            Guard.EnsureThat(value)
                .IsNullOrEmpty()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_Not_IsNullOrEmpty_Should_Throw_When_Given_Null_String()
        {
            // arrange
            string value = null;

            // act
            Guard.EnsureThat(value)
                .Not.IsNullOrEmpty()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_Not_IsNullOrEmpty_Should_Throw_When_Given_Empty_String()
        {
            // arrange
            string value = string.Empty;

            // act
            Guard.EnsureThat(value)
                .Not.IsNullOrEmpty()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_Not_IsNullOrEmpty_Should_Not_Throw_When_Given_Non_Empty_String_Value()
        {
            // arrange
            string value = "42";

            // act
            Guard.EnsureThat(value)
                .Not.IsNullOrEmpty()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsNullOrWhitespace_Should_Not_Throw_When_Given_Null_String()
        {
            // arrange
            string value = null;

            // act
            Guard.EnsureThat(value)
                .IsNullOrWhitespace()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsNullOrWhitespace_Should_Not_Throw_When_Given_Empty_String()
        {
            // arrange
            string value = string.Empty;

            // act
            Guard.EnsureThat(value)
                .IsNullOrWhitespace()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsNullOrWhitespace_Should_Not_Throw_When_Given_Whitespace_String()
        {
            // arrange
            string value = "   ";

            // act
            Guard.EnsureThat(value)
                .IsNullOrWhitespace()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsNullOrWhitespace_Should_Throw_When_Given_Non_Empty_String_Value()
        {
            // arrange
            string value = "42";

            // act
            Guard.EnsureThat(value)
                .IsNullOrWhitespace()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_Not_IsNullOrWhitespace_Should_Throw_When_Given_Null_String()
        {
            // arrange
            string value = null;

            // act
            Guard.EnsureThat(value)
                .Not.IsNullOrWhitespace()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_Not_IsNullOrWhitespace_Should_Throw_When_Given_Empty_String()
        {
            // arrange
            string value = string.Empty;

            // act
            Guard.EnsureThat(value)
                .Not.IsNullOrWhitespace()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_Not_IsNullOrWhitespace_Should_Throw_When_Given_Whitespace_String()
        {
            // arrange
            string value = "   ";

            // act
            Guard.EnsureThat(value)
                .Not.IsNullOrWhitespace()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_Not_IsNullOrWhitespace_Should_Not_Throw_When_Given_Non_Empty_String_Value()
        {
            // arrange
            string value = "42";

            // act
            Guard.EnsureThat(value)
                .Not.IsNullOrWhitespace()
                .ThrowOnFailure();

            // assert
        }
    }
}
