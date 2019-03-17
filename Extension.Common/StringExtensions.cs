using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Common
{
    public static class StringExtensions
    {
        // Call like this:
        //myString.Split('S', 3);

        public static string[] Split(this string @this, char separator, int count)
        {
            // Check for null
            if (@this == null)
            {
                //throw new ArgumentNullException("@this");
                throw new ArgumentNullException(nameof(@this));
            }

            // Call regular Split class:
            return @this.Split(new[] { separator}, count);
        }

        // Copy to IEnumerableExtensions
        //public static bool IsNullOrEmpty(this string @this)
        //{
        //    return string.IsNullOrEmpty(@this);
        //}
    }
}
