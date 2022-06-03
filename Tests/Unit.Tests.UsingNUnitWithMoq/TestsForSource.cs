using App.controllers;
using App.interfaces;
using Moq;
using NUnit.Framework;
using System.Linq;

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
            var expected = 'A';
            var result = source.Object.ReadChar();
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void Test_When_Source_ReadChars_With_Count_Parameter_IsCalled()
        {
            var expected = "AB".ToCharArray();
            var result = source.Object.ReadChars(2);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void Test_When_Source_ReadChar_IsCalled_With_Newline()
        {
            source.Setup(s => s.Value).Returns("\n");
            var expected = ' ';
            var result = source.Object.ReadChar();
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}