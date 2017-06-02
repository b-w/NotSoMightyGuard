namespace NotSoMightyGuard.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using NotSoMightyGuard;

    [TestClass]
    public class AssertionTests
    {
        #region null checks

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Guard_IsNotNull_Should_Throw_When_Given_Null_Object()
        {
            // arrange
            object value = null;

            // act
            Guard.EnsureThat(value)
                .IsNotNull()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsNotNull_Should_Not_Throw_When_Given_Value_Object()
        {
            // arrange
            object value = new object();

            // act
            Guard.EnsureThat(value)
                .IsNotNull()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Guard_IsNotNull_Should_Throw_When_Given_Null_Struct()
        {
            // arrange
            int? value = null;

            // act
            Guard.EnsureThat(value)
                .IsNotNull()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsNotNull_Should_Not_Throw_When_Given_Value_Struct()
        {
            // arrange
            int? value = 42;

            // act
            Guard.EnsureThat(value)
                .IsNotNull()
                .ThrowOnFailure();

            // assert
        }

        #endregion

        #region default checks

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsNotDefault_Should_Throw_When_Given_Default_Value()
        {
            // arrange
            int value = default(int);

            // act
            Guard.EnsureThat(value)
                .IsNotDefault()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsNotDefault_Should_Not_Throw_When_Given_Valid_Value()
        {
            // arrange
            int value = 42;

            // act
            Guard.EnsureThat(value)
                .IsNotDefault()
                .ThrowOnFailure();

            // assert
        }

        #endregion

        #region string

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

        #endregion
    }
}
