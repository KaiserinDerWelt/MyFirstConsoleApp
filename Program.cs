using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OperatorExamples();  //Here I am calling the Operator examples method that is inside of  the main class.
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("ITERATION" + i);
                 }
        
        }

        private static void OperatorExamples()
        {
            int width = 3;
            width++;

            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);
            while (area <20)
            {
                height++;
                area = width * height;
            }
            do
            {

            } while (area>25);

            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);

            bool truthValue = true;
            Console.WriteLine(truthValue);
        }
    }
}
