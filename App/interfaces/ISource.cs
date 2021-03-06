using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.interfaces
{
    /// <summary>
    /// Defines the properties / methods / structure / syntax for handling a Source
    /// </summary>
    public interface ISource
    {
        #region Properties
        /// <summary>
        /// Gets or Sets the source value to be used for processing
        /// </summary>
        string Value { get; set; }
        #endregion Properties

        #region Methods
        /// <summary>
        /// Gets (Reads) a single character from a source string / value
        /// </summary>
        /// <returns>char</returns>
        char ReadChar();
        /// <summary>
        /// Gets (Reads) multiple characters from a source string / value, based on the specified count
        /// </summary>
        /// <param name="count">the number of characters to get (read)</param>
        /// <returns>char[]</returns>
        char[] ReadChars(int count);
        #endregion Methods
    }
}
