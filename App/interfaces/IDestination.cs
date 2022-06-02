using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.interfaces
{
    /// <summary>
    /// Defines the properties / methods / structure / syntax for handling a Destination
    /// </summary>
    public interface IDestination
    {
        #region Methods
        /// <summary>
        /// Writes the provided character
        /// </summary>
        /// <param name="value">the character value to be written</param>
        void WriteChar(char value);

        /// <summary>
        /// Writes the provided characters
        /// </summary>
        /// <param name="values">the character values to be written</param>
        void WriteChars(char[] values);
        #endregion Methods
    }
}
