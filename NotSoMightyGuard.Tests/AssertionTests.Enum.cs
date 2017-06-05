namespace NotSoMightyGuard.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [Flags]
    public enum TestEnum
    {
        Alpha = 1,
        Beta = 1 << 1,
        Gamma = 1 << 2
    }

    public partial class AssertionTests
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_IsValidEnum_Should_Throw_When_Given_Invalid_Enum()
        {
            // arrange
            TestEnum value = (TestEnum)99;

            // act
            Guard.EnsureThat(value)
                .IsValidEnum()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_IsValidEnum_Should_Not_Throw_When_Given_Valid_Enum()
        {
            // arrange
            TestEnum value = TestEnum.Beta;

            // act
            Guard.EnsureThat(value)
                .IsValidEnum()
                .ThrowOnFailure();

            // assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Guard_HasFlag_Should_Throw_When_Given_Value_Does_Not_Have_Flag()
        {
            // arrange
            TestEnum value = TestEnum.Gamma;

            // act
            Guard.EnsureThat(value)
                .HasFlag(TestEnum.Alpha)
                .ThrowOnFailure();

            // assert
        }

        [TestMethod]
        public void Guard_HasFlag_Should_Not_Throw_When_Given_Value_Has_Flag()
        {
            // arrange
            TestEnum value = TestEnum.Beta;

            // act
            Guard.EnsureThat(value)
                .HasFlag(TestEnum.Beta)
                .ThrowOnFailure();

            // assert
        }
    }
}
