using System;

namespace StringGenerator
{
    class ConvertLetters
    {
        public static string ReturnLetters(string input)
        {
            char[] letters = input.ToCharArray();
            char[] vowelConsonantsCombined = (String.Join("",Setup.consonants) + String.Join("", Setup.vowels)).ToCharArray();
            for (int i = 0; i < Setup.length; i++)
            {
                int temp = Convert.ToInt32(letters[i].ToString());
                (letters[i]) = vowelConsonantsCombined[temp];
            }
            letters[0] = Convert.ToChar(letters[0].ToString().ToUpper());
            return String.Join("", letters);
        }
    }
}
