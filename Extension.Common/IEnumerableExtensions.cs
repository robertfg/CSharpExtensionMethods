using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Common
{
    public static class IEnumerableExtensions
    {
        // Copied from StringExtensions
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            //return string.IsNullOrEmpty(@this);
            return @this == null || !@this.Any();
        }

        public static bool IsEmpty<T>(this IEnumerable<T> @this)
        {
            return !@this.Any();
        }

        public static T FirstOr<T>(this IEnumerable<T> @this, Func<T, bool> predicate, Func<T> onOr)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            // Find the first or default value:
            T found = @this.FirstOrDefault(predicate);

            // If you don't find it, call the onOr function:
            if (found.Equals(default(T)))
            {
                found = onOr();
            }

            return found;
        }
    }
}
