using System;
using System.Collections.Generic;
using System.Linq;

namespace SinarMasPreTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start:");
            var start = Console.ReadLine();

            Console.WriteLine("end:");
            var end = Console.ReadLine();
            int range = Convert.ToInt32(end) - Convert.ToInt32(start);

            var allNumbers = Enumerable
                           .Range(Convert.ToInt32(start), range)
                           .ToArray();
            List<int> passwords = new List<int>();

            foreach (var item in allNumbers)
            {
                string number = item.ToString();
                var charArray = number.ToCharArray();

                int i = 1;
                bool isThereSameDigit = false;

                while (i < charArray.Length && Convert.ToInt32(charArray[i]) >= Convert.ToInt32(charArray[i - 1]))
                {
                    if (Convert.ToInt32(charArray[i]) == Convert.ToInt32(charArray[i - 1]) && !isThereSameDigit)
                        isThereSameDigit = true;

                    if (i == charArray.Length - 1 && isThereSameDigit)
                    {
                        passwords.Add(Convert.ToInt32(item));
                        Console.WriteLine(item);
                    }
                    i++;
                }                
            }

            Console.WriteLine("passwords yang mungkin adalah : " + passwords.Count());
        }
    }
}
