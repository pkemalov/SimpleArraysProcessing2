using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArraysProcessing2
{
    public class ConsecutiveEqualStrings
    {
        public static void Main()
        {
            var equalStrings = Console.ReadLine().Split(' ').ToArray();

            Array.Reverse(equalStrings);
            var count = 1;
            var finalString = string.Empty;

            for (int i = 0; i < equalStrings.Length; i++)
            {
                if (equalStrings[i + 1] == equalStrings[i])
                {
                    count++;
                    

                    if (count >= 3)
                    {
                        finalString = equalStrings[i];
                        break;
                    }
                    
                    // break;
                }

                else
                {
                    count = 1;
                                        
                }
                
            }
            string[] final = { finalString, finalString, finalString };
            Console.WriteLine(string.Join(" ", final));
        }
    }
}
