using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab
{
    class Program
    {
        static void Main(string[] args)
        {

            bool shouldContinue = false;
            bool isInputValid = false;
            string input = null;
            double radius = 0;
            List<Circles> circle = new List<Circles>();

            Console.WriteLine("Welcome to the Circle Tester");

            do
            {
                shouldContinue = false;
                do
                {
                    try
                    {
                        isInputValid = true;
                        Console.Write("Enter radius: ");
                        input = Console.ReadLine();
                        radius = double.Parse(input);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That input is invalid");
                        isInputValid = false;
                    }
                } while (!isInputValid);

                Circles c = new Circles(radius);
                circle.Add(c);
                c.CalculateFormattedCircumference();
                Console.WriteLine(c.CalculateFormattedCircumference());
                c.CalculateFormattedArea();
                Console.WriteLine(c.CalculateFormattedArea());

                Console.WriteLine("Continue? (y/n)");
                input = Console.ReadLine();
                if (input.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                {
                    shouldContinue = true;
                }
            } while (shouldContinue);
            Console.WriteLine("Goodbye. You created " + circle.Count + " Circle object(s)");
            Console.ReadKey();
        }
    }
}

