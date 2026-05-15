using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 12, 3, 20, 7 };

            // largest and smallest 

            int largestno = numbers[0];
            int smallestno = numbers[0];
            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] > largestno)
                    largestno = numbers[i];

                if (numbers[i] < smallestno)
                    smallestno = numbers[i];

                total = total + numbers[i];



            }

            double average = total / numbers.Length;

            Console.WriteLine($"largestno: {largestno}");
            Console.WriteLine($"smallestno: {smallestno}");
            Console.WriteLine($"average: {average} ");
            Console.WriteLine($"total: {total}" );

            // Ascending order
            Array.Sort(numbers);
            Console.WriteLine("\nAscending Order: ");
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            // Descending order
            Console.WriteLine("\n Descending Order: ");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
              
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
