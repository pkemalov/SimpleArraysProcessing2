using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.charRotation
{
    public class CharRotation
    {
        public static void Main()
        {
            var firstString = Console.ReadLine();
            char[] stringsToCharArray = firstString.ToCharArray();
            string result = "";
            var intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < stringsToCharArray.Length; i++)
            {
                if (intArray[i]%2==0)
                {
                    result += (char)(stringsToCharArray[i] - intArray[i]);
                }
                else
                {
                    result += (char)(stringsToCharArray[i] + intArray[i]);
                }
                
            }
            Console.WriteLine(result);
        }
    }
}
