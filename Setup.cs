using System;
using System.Collections.Generic;
using System.Text;

namespace NickRandomiser
{
    class Setup
    {
        public static int length;
        public static char[] consonantVowelFormat;
        public static char[] vowels;
        public static char[] consonants;
        protected static List<char> variableList;
        public static char[] transformFormat;
        protected static int userInputLength;
        protected static System.ConsoleKeyInfo userInput;
        public static void SetupVariables()
        {
            consonantVowelFormat = new char[length];
            Console.ForegroundColor = ConsoleColor.White; Console.Write("Nickname Randomiser (C#)\r\nPlease enter the length of your nickname");
            Console.ForegroundColor = ConsoleColor.White; Console.Write(".\r\n>");
            Console.ForegroundColor = ConsoleColor.Yellow; length = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Please enter the consonants and vowel format of your nickname. for example:\r\n[CVCCCVCVCVC] will return, [NICKNAMEGEN]");
            Console.Write("["); Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < length; i++)
            {
                Console.Write('.');
            }
            Console.ForegroundColor = ConsoleColor.White; Console.Write("]\r\n");
            Console.SetCursorPosition(1, 5);
            Console.ForegroundColor = ConsoleColor.Yellow;
            consonantVowelFormat = InputValidation(ConsoleKey.C, ConsoleKey.V).ToCharArray();
            Console.Write("\r\n");

            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Please enter the vowels to use. for example:\r\nAEIOUY\t(TOTAL VOWELS AND CONSONANTS MUST BE LESS THAN OR EQUAL TO 10)");
            Console.Write(">"); Console.ForegroundColor = ConsoleColor.Yellow; vowels = InputValidation('V').ToCharArray();
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Please enter the consonants to use. for example:\r\nBCDFGHJKLMNPQRSTVWXZ\t(TOTAL VOWELS AND CONSONATS MUST BE LESS THAN OR EQUAL TO 10)");
            Console.Write(">"); Console.ForegroundColor = ConsoleColor.Yellow; consonants = InputValidation('C').ToCharArray(); Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Please enter any fixed parts for your nickname. for example:\r\n[S.......SON] will return, [SICKNAMESON]");
            Console.Write("["); Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < length; i++)
            {
                Console.Write('.');
            }
            Console.ForegroundColor = ConsoleColor.White; Console.Write("]\r\n");
            Console.SetCursorPosition(1, 14);
            Console.ForegroundColor = ConsoleColor.Yellow; transformFormat = InputValidation('A').ToCharArray();
            Console.ForegroundColor = ConsoleColor.White; Console.Write("]\r\n");

        }

        public static string InputValidation(ConsoleKey inputA, ConsoleKey inputB)
        {
            userInputLength = 0;
            char[] variable = new char[length];
            while (userInputLength < length)
            {
                userInput = Console.ReadKey(true);
                if (userInput.Key == ConsoleKey.Backspace)
                {
                    if (userInputLength > 0)
                    {
                        userInputLength--;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\b.\b");

                    }
                }
                else if ((userInput.Key == inputA) || (userInput.Key == inputB))
                {
                    userInputLength++;
                    variable[userInputLength - 1] = userInput.KeyChar;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(userInput.KeyChar);
                }
            }
            return String.Join("", variable);
        }
        public static string InputValidation(char mode)
        {
            userInputLength = 0;
            variableList = new List<char>();
            char[] variable;
            switch (mode)
            {
                case 'C': //consonant
                    while (userInputLength < 10 - vowels.Length) //10 - vowels used
                    {
                        userInput = Console.ReadKey(true);
                        if (userInput.Key == ConsoleKey.Backspace)
                        {
                            if (userInputLength > 0)
                            {
                                userInputLength--;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("\b \b");
                                variableList.RemoveAt(userInputLength);
                            }
                        }
                        else if (userInput.Key == ConsoleKey.Enter)
                        {
                            Console.Write("\r\n");
                            break;
                        }
                        else if ((userInput.Key != ConsoleKey.A) && (userInput.Key != ConsoleKey.E) && (userInput.Key != ConsoleKey.I) && (userInput.Key != ConsoleKey.O) && (userInput.Key != ConsoleKey.U) && (userInput.Key != ConsoleKey.Y))
                        {
                            userInputLength++;
                            variableList.Add(userInput.KeyChar);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(userInput.KeyChar);
                        }
                    }
                    variable = (new string(variableList.ToArray())).ToCharArray();
                    return String.Join("", variable);
                case 'V': //vowel
                    while (userInputLength < 6) //only 6 vowels
                    {
                        userInput = Console.ReadKey(true);
                        if (userInput.Key == ConsoleKey.Backspace)
                        {
                            if (userInputLength > 0)
                            {
                                userInputLength--;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("\b \b");
                                variableList.RemoveAt(userInputLength);
                            }
                        }
                        else if (userInput.Key == ConsoleKey.Enter)
                        {
                            Console.Write("\r\n");
                            break;
                        }
                        else if ((userInput.Key == ConsoleKey.A) || (userInput.Key == ConsoleKey.E) || (userInput.Key == ConsoleKey.I) || (userInput.Key == ConsoleKey.O) || (userInput.Key == ConsoleKey.U) || (userInput.Key == ConsoleKey.Y))
                        {
                            userInputLength++;
                            variableList.Add(userInput.KeyChar);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(userInput.KeyChar);
                        }
                    }
                    variable = (new string(variableList.ToArray())).ToCharArray();
                    return String.Join("", variable);
                case 'A': //alphabetic
                    variable = new char[length];
                    while (userInputLength < length)
                    {
                        userInput = Console.ReadKey(true);
                        if (userInput.Key == ConsoleKey.Backspace)
                        {
                            if (userInputLength > 0)
                            {
                                userInputLength--;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("\b.\b");

                            }
                        }
                        else if (char.IsLetter(userInput.KeyChar) || userInput.Key == ConsoleKey.OemPeriod)
                        {
                            userInputLength++;
                            variable[userInputLength - 1] = userInput.KeyChar;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(userInput.KeyChar);
                        }
                    }
                    return String.Join("", variable);
                default:
                    return null;
            }
        }
    }
}
