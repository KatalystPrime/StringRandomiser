using System;
using System.Collections.Generic;

namespace NickRandomiser
{
    class FixInts
    {
        public static List<int> changedInts;
        public static string ReturnFixedInts(string input)
        {
            changedInts = new List<int>();
            Random rnd = new Random();
            char[] letters = input.ToCharArray();
            bool repeats = true;
            while (repeats == true)
            {
                repeats = false;
                for (int i = 0; i < Setup.length-1; i++)
                {
                    if (letters[i] == letters[i+1])
                    {
                        repeats = true;
                        if (Setup.consonantVowelFormat[i] == 'V')
                        {
                            letters[i] = Convert.ToChar(rnd.Next(Setup.consonants.Length, Setup.consonants.Length + Setup.vowels.Length).ToString());
                            changedInts.Add(i);
                        }
                        else
                        {
                            letters[i] = Convert.ToChar(rnd.Next(0, Setup.consonants.Length).ToString());
                            changedInts.Add(i);
                        }
                    }
                }
            }
            return (string.Join("", letters));
        }
    }
}
