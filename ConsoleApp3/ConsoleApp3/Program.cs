using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            //ამოცანა #1: მარტივი კალკულატორი switch-ით

            Console.Write("sheiyvanet pirveli ricxvi   ");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("sheiyvanet matematikuri operatori ( +, -, *, / )   ");
            string operation = Console.ReadLine();

            Console.Write("sheiyvanet meore ricxvi   ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            int result;


            switch (operation)
            {
                case "+":
                    result = numberOne + numberTwo;
                    Console.WriteLine(numberOne + " " + operation + " " + numberTwo + " = " + result);
                    break;
                case "-":
                    result = numberOne - numberTwo;
                    Console.WriteLine(numberOne + " " + operation + " " + numberTwo + " = " + result);
                    break;
                case "*":
                    result = numberOne * numberTwo;
                    Console.WriteLine(numberOne + " " + operation + " " + numberTwo + " = " + result);
                    break;
                case "/":
                    result = numberOne / numberTwo;
                    Console.WriteLine(numberOne + " " + operation + " " + numberTwo + " = " + result);
                    break;
            }
            
            

        }
    }
}
