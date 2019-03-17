using System;
using System.Collections.Generic;
using Extension.Collections.Generic;
//using static Extension.Common.IntExtensions;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extension.Common;

namespace ExtensionMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            //string myString = "apples, bananas, oranges";
            //myString.Split(',', 3);

            //myString = null;
            //myString.IsNullOrEmpty();

            var synonymsForBest = new List<string>
            {
                "best",
                "finest",
                "top",
                "foremost",
                "leading",
                "most excellent",
                "preeminent",
                "premier",
                "chief",
                "supreme",
                "unrivalled",
                "ultimate",
                "perfect",
                "incomparable",
                "ideal"
            };

            //Console.WriteLine($"My daughter Colleen is the {synonymsForBest.RandomItem()} daughter.");

            /* If FirstOr finds an item in the list with an even length, it will return that;
             * otherwise, it will call the RandomItem function.  Only call RandomItem if you
             * have to. */
            var best = synonymsForBest.FirstOr(s => s.Length.IsEven(), synonymsForBest.RandomItem);

            Console.WriteLine($"My daughter Colleen is the {best} daughter.");
            Console.ReadKey();
        }
    }
}
