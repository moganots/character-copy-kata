using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.interfaces
{
    /// <summary>
    /// Defines the properties / methods / structure / syntax for handling a Copier
    /// </summary>
    public interface ICopier
    {
        #region Proerties
        /// <summary>
        /// Gets or Sets the Source object for this Copier
        /// </summary>
        ISource Source { get; set; }

        /// <summary>
        /// Gets or Sets the Destination object for this Copier
        /// </summary>
        IDestination Destination { get; set; }
        #endregion Proerties

        #region Methods
        /// <summary>
        /// Performs a copy (read) and write of a single character value
        /// </summary>
        void Copy();

        /// <summary>
        /// Performs a copy (read) and write of the number of specified character values
        /// </summary>
        /// <param name="count">the number of character values to copy</param>
        void Copy(int count);
        #endregion Methods
    }
}
