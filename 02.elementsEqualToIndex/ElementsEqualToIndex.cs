using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.elementsEqualToIndex
{
    public class ElementsEqualToIndex
    {
        public static void Main()
        {
            var elementsEqualToIndex = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var finalString = string.Empty;

            for (int i = 0; i < elementsEqualToIndex.Length; i++)
            {
                if (elementsEqualToIndex[i] == i)
                {
                    finalString = finalString + " " + elementsEqualToIndex[i];
                }

            }
            var newstring = finalString.Trim();
            Console.WriteLine(newstring);

        }
    }
}
