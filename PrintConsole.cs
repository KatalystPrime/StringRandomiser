using System;
using System.Collections.Generic;
using System.Text;

namespace StringGenerator
{
    class PrintConsole
    {
        public static void PrintFormattedOutput(string intInput , string transformedInput, List<int> fixedInputList, List<int> transformedInputList)
        {
            Console.WriteLine(" " + intInput);
            Console.Write(" ");
            for (int i = 0; i < Setup.length; i++)
            {
                if (fixedInputList.Contains(i))
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                }
                else if (transformedInputList.Contains(i))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write(transformedInput[i]);
            }
            Console.Write("\r\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" " + transformedInput.ToUpper());
            Console.WriteLine(" " + transformedInput.ToLower());
            
        }
    }
}
