using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();


            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                    (string, string) num = ReadingNumberInput();

                    if (int.TryParse(num.Item1, out int addNumOne) && int.TryParse(num.Item2, out int addNumTwo))
                    {
                        Console.Write($"{num.Item1} + {num.Item2} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    (string, string) numSub = ReadingNumberInput();

                    if (int.TryParse(numSub.Item1, out int subNumOne) && int.TryParse(numSub.Item2, out int subNumTwo))
                    {
                        Console.Write($"{numSub.Item1} - {numSub.Item2} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "3":
                    // Add code here
                    //testing git commit by putting a message here first and pushing back
                    Console.WriteLine("Enter 2 integers to multiply");
                    (string, string) numMul = ReadingNumberInput();

                    if (int.TryParse(numMul.Item1, out int mulNumOne) && int.TryParse(numMul.Item2, out int mulNumTwo))
                    {
                        Console.Write($"{numMul.Item1} * {numMul.Item2} = ");
                        Console.Write(calculator.Multiply(mulNumOne, mulNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    (string, string) numDiv = ReadingNumberInput();

                    if (double.TryParse(numDiv.Item1, out double divNumOne) && double.TryParse(numDiv.Item2, out double divNumTwo))
                    {
                        Console.Write($"{numDiv.Item1} / {numDiv.Item2} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
        static (string, string) ReadingNumberInput()
        {           
           var Number1 = Console.ReadLine();
           var Number2 = Console.ReadLine();
            (string, string) numberInput = (Number1, Number2);
            return numberInput;
        }
    }
}