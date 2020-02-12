using System;
using System.Collections.Generic;

namespace StringGenerator
{
    class TransformInts
    {
        public static List<int> transformedInts;
        public static string ReturnTransformedInt(string input)
        {
            transformedInts = new List<int>();
            char[] letters = input.ToCharArray();
            for (int i = 0; i < Setup.length; i++)
            {
                if (Setup.transformFormat[i] != '.')
                {
                    transformedInts.Add(i);
                    letters[i] = Setup.transformFormat[i];
                }
            }

            return (String.Join("", letters));
        }
    }
}
