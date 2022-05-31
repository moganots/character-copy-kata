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
            destination = new Mock<IDestination>();
            copier = new Mock<ICopier>(source.Object, destination.Object);
        }

        [Test]
        public void Test_Source_Copy_When_Copier_Copy_IsCalled()
        {
            copier.Object.Copy();
        }

        [Test]
        public void Test_Source_Copy_With_Count_Parameter_When_Copier_Copy_IsCalled()
        {
            copier.Object.Copy(2);
        }

        [Test]
        public void Test_Source_IsCalled_With_Newline()
        {
            copier.Object.Copy();
        }
    }
}