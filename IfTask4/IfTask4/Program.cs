using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Three numbers, separated by comma, will be asked as an input.
             Numbers will be sorted in ascending order and printed on a screen */

            string numbers;
            int number1;
            int number2;
            int number3;


            Console.WriteLine(" Please type in three numbers separated by comma (for example 1,2,3): ");
            numbers = Console.ReadLine();
            number1 = Convert.ToInt32(numbers.Split(',')[0]);
            number2 = Convert.ToInt32(numbers.Split(',')[1]);
            number3 = Convert.ToInt32(numbers.Split(',')[2]);

            var sortednumbers = new int[] { number1, number2, number3 };

            Array.Sort(sortednumbers);

            int numbermin = sortednumbers[0];
            int numbermid = sortednumbers[1];
            int numbermax = sortednumbers[2];

            Console.WriteLine(" Here you have numbers in ascending order: " + numbermin + "," + numbermid + "," + numbermax);
            Console.ReadKey();
        }
    }
}
