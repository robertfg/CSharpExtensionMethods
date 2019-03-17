using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Extension.Common
// Remove from Program.cs by changing namespace back to Extension.Common
//namespace Extension.Collections.Generic
namespace Extension.NotInUse
{
    public static class ListUtils
    {
        private static Random _random = new Random();

        //public static T RandomItem<T>(List<T> list)
        public static T RandomItem<T>(this List<T> list)
        {
            return list[_random.Next(0, list.Count)];
        }
    }
}
