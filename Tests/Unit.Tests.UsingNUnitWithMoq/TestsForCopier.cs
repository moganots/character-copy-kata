using App.controllers;
using App.interfaces;
using Moq;
using NUnit.Framework;

namespace Unit.Tests.UsingNUnitWithMoq
{
    public class TestsForCopier
    {
        private Mock<ISource> source;
        private Mock<IDestination> destination;
        private Mock<ICopier> copier;

        [SetUp]
        public void Setup()
        {
            source = new Mock<ISource>();
            source.Setup(src => src.Value).Returns("ABCDEF\n");
            destination = new Mock<IDestination>();
            copier = new Mock<ICopier>(source.Object, destination.Object);
        }

        [Test]
        public void success_when_Source_ReadChar_is_called_when_Copy_is_called()
        {
            var expected = 'A';
            copier.Object.Copy();
            Assert.That(expected, Is.EqualTo(source.Object.ReadChar()));
        }

        [Test]
        public void success_when_Destination_WriteChar_is_called_when_Copy_is_called()
        {
            var expected = 'A';
            copier.Object.Copy();
            Assert.That(expected, Is.EqualTo(source.Object.ReadChar()));
            destination.Object.WriteChar(source.Object.ReadChar());
        }
    }
}