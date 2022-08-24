using System;
using System.Linq;

namespace ArrayTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st task
            Console.WriteLine("1st task");
            int[] arr = { 1, 2, 3, 2, 4, 5, 2, 4 };

            if (arr.Length != arr.Distinct().Count())
            {
                Console.WriteLine("Array contains duplicates");
            }
            else
            {
                Console.WriteLine("Array does not contain duplicates");
            }

            //2nd task
            Console.WriteLine("2nd task");
            string[] names = { "Narmin", "Leyla", "Arzu" };
            if (names.Contains("AA"))
            {
                Console.WriteLine("Contains");
            }
            else
            {
                Console.WriteLine("Does not Contain");
            }
            //3rd task
            Console.WriteLine("4th task");
            int[] checkNumbers = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(string.Join("\n", checkNumbers));

            //4th task
            Console.WriteLine("4th task");
            string[] vehichles = { "car", "bike", "truck", "bus" };
            String[] res = Array.FindAll(vehichles, ele => ele.StartsWith("b",
            StringComparison.Ordinal));

            Console.Write("\nAll Searched elements...\n");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine( res[i]);
            }
            //5th task
            Console.WriteLine("5th task");

            string[] letters = { "ab", "bd", "vc", "dgfd"};
            Console.WriteLine(string.Join("\n", letters));
            
            //6th task 
            Console.WriteLine("6th task");
            int[] firstArray = { 1, 2, 4, 6, 7, 8, 9, 10, 11 };
            int[] secondArray = { 3, 5, 6, 7, 8 };
            var intersect = firstArray.Intersect(secondArray);
            foreach (int result in intersect)
            {
                Console.WriteLine("Same values are: " + result);
            }
            var difference = firstArray.Except(secondArray);
            foreach (int result in difference)
            {
                Console.WriteLine("Different values are: " + result);
            }



        }
    }
}
