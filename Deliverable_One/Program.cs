using System;

namespace Deliverable_One
{
    class Program
    {
        static void Main(string[] args)
        {
            string again;
            do
            {
                Console.WriteLine("Please input measurement type. ");

                string measurementUnit = Console.ReadLine();

                Console.WriteLine("Please enter amount. ");
                long amount = long.Parse(Console.ReadLine());
                if (measurementUnit == "inch")
                {
                    Console.WriteLine(amount / .2857142857142857 + "fidget spinners");
                }
                if (measurementUnit == "fidget spinners")
                {
                    Console.WriteLine(amount / 3.5 + "inches");
                }
                if (measurementUnit == "memes")
                {
                    Console.WriteLine(amount * .2 + "feet");
                }
                if (measurementUnit == "foot")
                {
                    Console.WriteLine(amount * 5 + "memes");
                }
                Console.WriteLine("Would you like to try another conversion? yes/no");
                again = Console.ReadLine();
            } while (again == "yes");
        }
    }
}
