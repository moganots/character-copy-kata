using App.controllers;
using App.interfaces;
using Moq;
using NUnit.Framework;

namespace Unit.Tests.UsingNUnitWithMoq
{
    public class TestsForSource
    {
        private Mock<ISource> source;

        [SetUp]
        public void Setup()
        {
            source = new Mock<ISource>();
            source.Setup(src => src.Value).Returns("ABCDEF\n");
        }

        [Test]
        public void Test_When_Source_ReadChar_IsCalled()
        {
            var result = source.Object.ReadChar();
            Assert.IsTrue(result == 'A');
        }

        [Test]
        public void Test_When_Source_ReadChar_IsCalled_With_Newline()
        {
            var result = source.Object.ReadChar();
            Assert.IsTrue(result == ' ');
        }

        [Test]
        public void Test_When_Source_ReadChars_With_Count_Parameter_IsCalled()
        {
            var result = source.Object.ReadChars(2).ToString();
            Assert.IsTrue(result == "AB");
        }
    }
}