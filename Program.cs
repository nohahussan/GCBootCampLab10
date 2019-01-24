using System;

namespace Lab10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");
            Boolean repeat = false;
            do
            {
                Console.WriteLine("Enter a raduis: ");
                var userInput = Validator.ValidateInput(Console.ReadLine());//validate the input static method ValidateInput()
                if (userInput == -1)//if the user entered invalid data print error message
                {
                    Console.WriteLine("ERROR invalid data!! ");
                }
                else
                {
                    Circle obj = new Circle(userInput);
                    Console.WriteLine(obj.CalculateFormattedCircumference());
                    Console.WriteLine(obj.CalculateFormattedArea());
                }
                repeat = Continue();
                Console.WriteLine("You created {0} Circle objects",Circle.numberOfCircles); 
            } while (repeat);
        }
        public static Boolean Continue ()
        {
            Console.WriteLine("Continue ? (y/n)");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                Console.WriteLine("Goodbye.");
                return false;
            }
            else 
            {
                Console.WriteLine("invalid input");
                return true;
            }

        }
    }
}
