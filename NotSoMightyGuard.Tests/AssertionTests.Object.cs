namespace NotSoMightyGuard.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public partial class AssertionTests
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsNull_Should_Throw_When_Given_Value_Object()
        {
            // arrange
            object value = new object();

            // act
            Guard.EnsureThat(value)
                .IsNull()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsNull_Should_Not_Throw_When_Given_Null_Object()
        {
            // arrange
            object value = null;

            // act
            Guard.EnsureThat(value)
                .IsNull()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_Not_IsNull_Should_Not_Throw_When_Given_Value_Object()
        {
            // arrange
            object value = new object();

            // act
            Guard.EnsureThat(value)
                .Not.IsNull()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Guard_Not_IsNull_Should_Throw_When_Given_Null_Object()
        {
            // arrange
            object value = null;

            // act
            Guard.EnsureThat(value)
                .Not.IsNull()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsNull_Should_Throw_When_Given_Value_Struct()
        {
            // arrange
            int? value = 42;

            // act
            Guard.EnsureThat(value)
                .IsNull()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsNull_Should_Not_Throw_When_Given_Null_Struct()
        {
            // arrange
            int? value = null;

            // act
            Guard.EnsureThat(value)
                .IsNull()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_Not_IsNull_Should_Not_Throw_When_Given_Value_Struct()
        {
            // arrange
            int? value = 42;

            // act
            Guard.EnsureThat(value)
                .Not.IsNull()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Guard_Not_IsNull_Should_Throw_When_Given_Null_Struct()
        {
            // arrange
            int? value = null;

            // act
            Guard.EnsureThat(value)
                .Not.IsNull()
                .ThrowOnFailure();

            // assert
        }
    }
}
