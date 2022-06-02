using App.controllers;
using App.interfaces;
using NUnit.Framework;

namespace Unit.Tests.UsingNUnit
{
    public class TestsForSource
    {
        private ISource source;

        [SetUp]
        public void Setup()
        {
            source = new Source();
        }

        [Test]
        public void Test_When_Source_ReadChar_IsCalled()
        {
            source.Value = "A";
            var result = source.ReadChar();
            Assert.IsTrue(result == 'A');
        }

        [Test]
        public void Test_When_Source_ReadChar_IsCalled_With_Newline()
        {
            source.Value = "\n";
            var result = source.ReadChar();
            Assert.IsTrue(result == ' ');
        }

        [Test]
        public void Test_When_Source_ReadChars_With_Count_Parameter_IsCalled()
        {
            source.Value = "ABCDEFG\n";
            var result = source.ReadChars(1).ToString();
            Assert.IsTrue(result == "AB");
        }
    }
}