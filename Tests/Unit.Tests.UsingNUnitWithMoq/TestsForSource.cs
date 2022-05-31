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
        }

        [Test]
        public void Test_When_Source_ReadChar_IsCalled()
        {
            var result = source.Object.ReadChar();
            Assert.Pass(result.ToString());
        }

        [Test]
        public void Test_When_Source_ReadChars_With_Count_Parameter_IsCalled()
        {
            var result = source.Object.ReadChars(2);
            Assert.Pass(result.ToString());
        }

        [Test]
        public void Test_When_Source_ReadChar_IsCalled_With_Newline()
        {
            var result = source.Object.ReadChars('\n');
            Assert.Pass(result.ToString());
        }
    }
}