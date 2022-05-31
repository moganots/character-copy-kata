using App.controllers;
using App.interfaces;
using System;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISource source;
            IDestination destination;
            ICopier copier;

            source = new Source();
            destination = new Destination();
            copier = new Copier(source, destination);

            copier.Copy();

            copier.Copy(2);
        }
    }
}
