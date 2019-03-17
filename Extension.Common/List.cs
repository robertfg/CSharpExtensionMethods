using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Collections.Generic
{
    // I changed this from List so it wouldn't error
    //public class List<T> : System.Collections.Generic.List<T>
    public class List_NotInUse<T> : System.Collections.Generic.List<T>
    {
        /*
         * Done properly, we'd create constructors for all constructors
         * in base System.Collections.Generic.List class.
         * */
        private static Random _random = new Random();

        // Moved from Program.cs in ExtensionMethods project
        //private static string GetRandomItem(List<string> list)
        public T RandomItem()
        {
            return this[_random.Next(0, Count)];
        }
    }
}
