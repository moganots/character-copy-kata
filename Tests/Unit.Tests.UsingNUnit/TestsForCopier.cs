using App.controllers;
using App.interfaces;
using NUnit.Framework;

namespace Unit.Tests.UsingNUnit
{
    public class TestsForCopier
    {
        private ISource source;
        private IDestination destination;
        private ICopier copier;

        [SetUp]
        public void Setup()
        {
            source = new Source();
            source.Value = "ABCDEF\n";
            destination = new Destination();
            copier = new Copier(source, destination);
        }

        [Test]
        public void success_when_Source_ReadChar_is_called_when_Copy_is_called()
        {
            var expected = 'A';
            copier.Copy();
            Assert.That(expected, Is.EqualTo(source.ReadChar()));
        }

        [Test]
        public void success_when_Destination_WriteChar_is_called_when_Copy_is_called()
        {
            var expected = 'A';
            copier.Copy();
            Assert.That(expected, Is.EqualTo(source.ReadChar()));
            destination.WriteChar(source.ReadChar());
        }
    }
}