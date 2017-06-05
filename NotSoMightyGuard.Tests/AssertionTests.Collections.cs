namespace NotSoMightyGuard.Tests
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public partial class AssertionTests
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsEmpty_Should_Throw_When_Given_Non_Empty_Collection()
        {
            // arrange
            ICollection<object> value = new List<object>
            {
                new object(),
                new object(),
                new object()
            };

            // act
            Guard.EnsureThat(value)
                .IsEmpty()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsEmpty_Should_Not_Throw_When_Given_Empty_Collection()
        {
            // arrange
            ICollection<object> value = new List<object>();

            // act
            Guard.EnsureThat(value)
                .IsEmpty()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsEmpty_Should_Not_Throw_When_Given_Null_Collection()
        {
            // arrange
            ICollection<object> value = null;

            // act
            Guard.EnsureThat(value)
                .IsEmpty()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_Not_IsEmpty_Should_Not_Throw_When_Given_Non_Empty_Collection()
        {
            // arrange
            ICollection<object> value = new List<object>
            {
                new object(),
                new object(),
                new object()
            };

            // act
            Guard.EnsureThat(value)
                .Not.IsEmpty()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_Not_IsEmpty_Should_Throw_When_Given_Empty_Collection()
        {
            // arrange
            ICollection<object> value = new List<object>();

            // act
            Guard.EnsureThat(value)
                .Not.IsEmpty()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_Not_IsEmpty_Should_Throw_When_Given_Null_Collection()
        {
            // arrange
            ICollection<object> value = null;

            // act
            Guard.EnsureThat(value)
                .Not.IsEmpty()
                .ThrowOnFailure();

            // assert
        }
    }
}
