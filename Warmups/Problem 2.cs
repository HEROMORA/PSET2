using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleFun
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear(); // NOT IMPORTANT
                Console.WriteLine("Please Enter the Number: "); // NOT IMPORTANT
                int n = Convert.ToInt32(Console.ReadLine());
                var digits =  n.ToString().Select(t=>int.Parse(t.ToString())).ToArray();
                bool result = false;

                if (digits.Length == 1)
                {
                    result = true;
                    goto end;
                }

                if (digits[0] + digits[1] == digits[digits.Length - 1] + digits[digits.Length - 2])
                    result = true;
                
                
                end:
                Console.WriteLine(result.ToString());

                // NOT IMPORTANT
                Console.WriteLine();
                Console.WriteLine("Press Any Key to Enter Another Number!");
                Console.ReadKey();
            }
        }
    }
}
