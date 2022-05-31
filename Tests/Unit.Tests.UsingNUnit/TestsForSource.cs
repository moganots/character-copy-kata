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
            var result = source.ReadChar();
            Assert.Pass(result.ToString());
        }

        [Test]
        public void Test_When_Source_ReadChars_With_Count_Parameter_IsCalled()
        {
            var result = source.ReadChars(2);
            Assert.Pass(result.ToString());
        }

        [Test]
        public void Test_When_Source_ReadChar_IsCalled_With_Newline()
        {
            var result = source.ReadChars('\n');
            Assert.Pass(result.ToString());
        }
    }
}