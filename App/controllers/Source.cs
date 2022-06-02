using App.interfaces;
using App.utils;
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
        #region Properties
        /// <summary>
        /// Gets or Sets the source value to be used for processing
        /// </summary>
        public string Value { get; set; }
        HashSet<object> CharsValueRead => new HashSet<object>();
        HashSet<char[]> CharsValuesRead => new HashSet<char[]>();
        #endregion Properties

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
            var value = GetCharsNotRead(Value.ToCharArray());
            if (value.IsSet() && !value.IsNewline())
            {
                CharsValueRead.Add(value);
                return value;
            }
            return default;
        }

        char GetCharsNotRead(char[] values)
        {
            return values.First((e) => !CharsValueRead.Contains(e));
        }

        /// <summary>
        /// Gets (Reads) multiple characters from a source string / value, based on the specified count
        /// </summary>
        /// <param name="count">the number of characters to get (read)</param>
        /// <returns>char[]</returns>
        public char[] ReadChars(int count)
        {
            var value = GetCharsNotRead(GroupByCountAndSelect(count).ToArray()).RemoveNewline();
            if (value.IsSet() && !value.IsNewline())
            {
                CharsValueRead.Add(value);
                return value.ToCharArray();
            }
            return default;
        }

        IEnumerable<string> GroupByCountAndSelect(int count)
        {
            var index = 0;
            return Value.ToCharArray().GroupBy(_ => index++ / count).Select((group) => string.Join("", group));
        }
        string GetCharsNotRead(string[] values)
        {
            return values.First((e) => !CharsValueRead.Contains(e));
        }
        #endregion Methods
    }
}
