using System;
using System.Collections.Generic;

namespace StringGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Setup.SetupVariables();
            while (true)
            {
                string generatedLetters = GenInts.ReturnGeneratedInts();
                string fixedLetters = FixInts.ReturnFixedInts(generatedLetters);
                string convertedLetters = ConvertLetters.ReturnLetters(fixedLetters);
                string transformedLetters = TransformInts.ReturnTransformedInt(convertedLetters);
                PrintConsole.PrintFormattedOutput(generatedLetters, transformedLetters, FixInts.changedInts, TransformInts.transformedInts);
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                
            }
        }
    }
}
