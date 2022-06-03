using App.controllers;
using App.interfaces;
using Moq;
using NUnit.Framework;
using System.Linq;

namespace Unit.Tests.UsingNUnitWithMoq
{
    public class TestsForDestination
    {
        private Mock<ISource> source;
        private Mock<IDestination> destination;

        [SetUp]
        public void Setup()
        {
            source = new Mock<ISource>();
            source.Setup(src => src.Value).Returns("ABCDEF\n");
            destination = new Mock<IDestination>();
        }

        [Test]
        public void Test_When_Destination_WriteChar_IsCalled()
        {
            var charValue = source.Object.ReadChar();
            if(charValue == 'A')
            {
                Assert.Pass();
                destination.Object.WriteChar(charValue);
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test_When_Destination_WriteChars_With_Count_Parameter_IsCalled()
        {
            var charValues = source.Object.ReadChars(2).ToString();
            if (charValues == "AB")
            {
                Assert.Pass();
                destination.Object.WriteChars(charValues.ToCharArray());
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}