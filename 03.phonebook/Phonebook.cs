using System;

namespace _03.phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            string[] firstString = Console.ReadLine().Split(' ');
            string[] secondString = Console.ReadLine().Split(' ');

            string name = Console.ReadLine();

            while (name != "done")
            {
                PrintElement(firstString, secondString, name);
                name = Console.ReadLine();
            }
        }

        public static void PrintElement(string[] firstString, string[] secondString, string name)
        {
            for (int i = 0; i < secondString.Length; i++)
            {
                if (name == secondString[i])
                {
                    Console.WriteLine("{0} -> {1} ", secondString[i], firstString[i]);
                }

            }
        }
    }
}

