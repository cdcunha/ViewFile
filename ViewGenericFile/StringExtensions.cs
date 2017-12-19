using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ViewGenericFile.Helpers
{
    public static class StringExtensions
    {
        public static bool Like(this string text, string pattern, bool ignoreCase = true, bool useCharClasses = true)
        {
            // Check input parameters
            if (pattern == null || text == null || pattern.Length == 0 || text.Length == 0 || pattern == "*.*" == true)
            {
                // Default return is true
                return true;
            }

            // Escape all strings
            System.Text.StringBuilder regPattern = new System.Text.StringBuilder(Regex.Escape(pattern));

            // Replace the LIKE patterns with regular expression patterns
            regPattern = regPattern.Replace(Regex.Escape("*"), ".*");
            regPattern = regPattern.Replace(Regex.Escape("?"), @".");
            regPattern = regPattern.Replace(Regex.Escape("#"), @"[0-9]");
            //if pattern to compare includes VB character class markers and is not using character classes then don't unescape them
            if (useCharClasses)
            {
                regPattern = regPattern.Replace(Regex.Escape("[!"), @"[!");
                regPattern = regPattern.Replace(Regex.Escape("["), @"[");
                regPattern = regPattern.Replace(Regex.Escape("]"), @"]");
            }

            // Add begin and end blocks (to match on the whole string only)
            regPattern.Insert(0, "^");
            regPattern.Append("$");

            if (ignoreCase == false)
            {
                return Regex.IsMatch(text, regPattern.ToString());
            }
            else
            {
                return Regex.IsMatch(text, regPattern.ToString(), RegexOptions.IgnoreCase);
            }
        }
    }
}
