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
            destination = new Destination();
            copier = new Copier(source, destination);
        }

        [Test]
        public void Test_Source_Copy_When_Copier_Copy_IsCalled()
        {
            copier.Copy();
        }

        [Test]
        public void Test_Source_Copy_With_Count_Parameter_When_Copier_Copy_IsCalled()
        {
            copier.Copy(2);
        }

        [Test]
        public void Test_Source_IsCalled_With_Newline()
        {
            copier.Copy();
        }
    }
}