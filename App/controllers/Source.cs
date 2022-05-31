using App.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.controllers
{
    /// <summary>
    /// Provides the implementation of the properties / methods / structure / syntax for handling a Source
    /// </summary>
    public class Source: ISource
    {
        #region Constructor(s)
        /// <summary>
        /// Instantiates a new Source object
        /// </summary>
        public Source() { }
        #endregion Constructor(s)

        #region Methods
        /// <summary>
        /// Gets (Reads) a single character from a source string / value
        /// </summary>
        /// <returns>char</returns>
        public char ReadChar()
        {
            return default;
        }
        /// <summary>
        /// Gets (Reads) multiple characters from a source string / value, based on the specified count
        /// </summary>
        /// <param name="count">the number of characters to get (read)</param>
        /// <returns>char[]</returns>
        public char[] ReadChars(int count)
        {
            return default;
        }
        #endregion Methods
    }
}
