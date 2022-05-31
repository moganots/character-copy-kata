using App.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.controllers
{
    /// <summary>
    /// Provides the implementation of the properties / methods / structure / syntax for handling a Copier
    /// </summary>
    public class Copier: ICopier
    {
        #region Proerties
        /// <summary>
        /// Gets or Sets the Source object for this Copier
        /// </summary>
        public ISource Source { get; set; }

        /// <summary>
        /// Gets or Sets the Destination object for this Copier
        /// </summary>
        public IDestination Destination { get; set; }
        #endregion Proerties

        #region Constructor(s)
        /// <summary>
        /// Instantiates a new Copier object
        /// </summary>
        public Copier() { }
        public Copier(ISource source, IDestination destination): this()
        {
            this.Source = source;
            this.Destination = destination;
        }
        #endregion Constructor(s)

        #region Methods
        /// <summary>
        /// Performs a copy (read) and write of a single character value
        /// </summary>
        public void Copy()
        {
            char c = Source.ReadChar();
            if (c != '\n')
            {
                Destination.WriteChar(c);
            }
        }

        /// <summary>
        /// Performs a copy (read) and write of the number of specified character values
        /// </summary>
        /// <param name="count">the number of character values to copy</param>
        public void Copy(int count)
        {
            char[] c = Source.ReadChars(count);
            if (!c.Contains('\n'))
            {
                Destination.WriteChars(c);
            }
        }
        #endregion Methods
    }
}
