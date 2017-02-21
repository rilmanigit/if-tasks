using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program asks a number (an integer) as an input from the user. Output will show whether the entered number is even, odd or zero.
            // If the user input is other than an integer "Not a number" will be printed on a screen.
            int number = 0;
            string message = string.Empty;
            Console.Write("This program checks if entered number is even, odd or zero.\nPlease enter a number (an integer): ");
            bool result = int.TryParse(Console.ReadLine(), out number);

            if (!result)
            {
                message = "Your input is not a number, please check your input.";
            }

            else if (number == 0)
            {
                message = string.Format("Number {0} is zero", number);
                message = "Number " + number + " is Zero";
            }

            else if (number % 2 == 0)
            {
                message = string.Format("Number {0} is Even", number);
                message = "Number " + number + " is Even";
            }

            else if (number % 2 == 1)
            {
                message = string.Format("Number {0} is Odd", number);
                message = "Number " + number + " is Odd";
            }

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
