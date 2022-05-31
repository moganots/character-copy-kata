using App.controllers;
using App.interfaces;
using Moq;
using NUnit.Framework;

namespace Unit.Tests.UsingNUnitWithMoq
{
    public class TestsForDestination
    {
        private Mock<IDestination> destination;

        [SetUp]
        public void Setup()
        {
            destination = new Mock<IDestination>();
        }

        [Test]
        public void Test_When_Destination_WriteChar_IsCalled()
        {
            destination.Object.WriteChar('a');
        }

        [Test]
        public void Test_When_Destination_WriteChars_With_Count_Parameter_IsCalled()
        {
            destination.Object.WriteChars(new char[] { 'a', 'b', '\n' });
        }

        [Test]
        public void Test_When_Destination_WriteChar_IsCalled_With_Newline()
        {
            destination.Object.WriteChar('\n');
        }
    }
}