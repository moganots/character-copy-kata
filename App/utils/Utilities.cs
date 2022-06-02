using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.utils
{
    public static class Utilities
    {
        public static char NewLine = '\n';
        public static char NewRow = '\r';
        public static string NewRowLine = "\r\n";

        public static bool IsSet(this object value)
        {
            return !(value == null);
        }
        public static bool IsSet(this string value)
        {
            return IsSet(value) && !(value.Trim().Length == 0);
        }
        public static bool IsNewline(this char value)
        {
            return value == NewLine;
        }
        public static bool IsNewRow(this char value)
        {
            return value == NewLine;
        }
        public static bool IsNewRowLine(this char value)
        {
            return value == NewLine;
        }

        public static bool IsNewline(this string value)
        {
            return value == "\n";
        }
        public static bool IsNewRow(this string value)
        {
            return value == "\r";
        }
        public static bool IsNewRowLine(this string value)
        {
            return value == "\r\n";
        }
        public static string RemoveNewline(this string value)
        {
            return value.Replace("\n", "").Replace("\r", "");
        }
    }
}
