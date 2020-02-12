using System;

namespace StringGenerator
{
    class GenInts
    {
        public static string ReturnGeneratedInts()
        {
            char[] conVowFormat = Setup.consonantVowelFormat;
            int[] letters = new int[Setup.length];
            Random rnd = new Random();
            for (int i = 0; i < Setup.length; i++)
            {
                if (conVowFormat[i] == 'C' || conVowFormat[i] == 'c')
                {
                    letters[i] = rnd.Next(0, Setup.consonants.Length);
                }
                else if (conVowFormat[i] == 'V' || conVowFormat[i] == 'v')
                {
                    letters[i] = rnd.Next(Setup.consonants.Length, Setup.consonants.Length + Setup.vowels.Length);
                }
            }
            return String.Join("", letters);
        }
    }
}
