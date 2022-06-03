using App.controllers;
using App.interfaces;
using NUnit.Framework;

namespace Unit.Tests.UsingNUnit
{
    public class TestsForDestination
    {
        private ISource source;
        private IDestination destination;

        [SetUp]
        public void Setup()
        {
            source = new Source();
            source.Value = "ABCDEF\n";
            destination = new Destination();
        }

        [Test]
        public void Test_When_Destination_WriteChar_IsCalled()
        {
            var charValue = source.ReadChar();
            if (charValue == 'A')
            {
                Assert.Pass();
                destination.WriteChar(charValue);
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test_When_Destination_WriteChars_With_Count_Parameter_IsCalled()
        {
            var charValues = source.ReadChars(2).ToString();
            if (charValues == "AB")
            {
                Assert.Pass();
                destination.WriteChars(charValues.ToCharArray());
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}