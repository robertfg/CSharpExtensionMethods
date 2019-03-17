using System;

// Utility method
using System.Collections.Generic;

// Class library and Utility method
using Extension.Collections.Generic;

// For IsEven:
using static Extension.Common.IntExtensions;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program1
    {
        //static void Main(string[] args)
        public static void Main1(string[] args)
        {
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

            //Console.WriteLine($"My daughter Colleen is the {GetRandomItem(synonymsForBest)} daughter.");

            // Class Library
            //Console.WriteLine($"My daughter Colleen is the {synonymsForBest.RandomItem()} daughter.");

            // Utility method
            //Console.WriteLine($"My daughter Colleen is the {ListUtils.RandomItem(synonymsForBest)} daughter.");
            Console.WriteLine($"My daughter Colleen is the {synonymsForBest.RandomItem()} daughter.");

            Console.ReadKey();
        }

        // Moved to Extension.Common.List class
        //private static string GetRandomItem(List<string> list)
        //{
        //    var random = new Random();
        //    return list[random.Next(0, list.Count)];
        //}
    }
}
