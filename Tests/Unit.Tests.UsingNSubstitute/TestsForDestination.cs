using App.controllers;
using App.interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Unit.Tests.UsingNSubstitute
{
    public class TestsForDestination
    {
        private IDestination destination;

        [SetUp]
        public void Setup()
        {
            destination = new Destination();
        }

        [Test]
        public void Test_When_Destination_WriteChar_IsCalled()
        {
            destination.WriteChar('a');
        }

        [Test]
        public void Test_When_Destination_WriteChars_With_Count_Parameter_IsCalled()
        {
            destination.WriteChars(new char[] { 'a', 'b', '\n' });
        }

        [Test]
        public void Test_When_Destination_WriteChar_IsCalled_With_Newline()
        {
            destination.WriteChar('\n');
        }
    }
}