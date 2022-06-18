using System;
using System.Linq;

namespace AdderforBigNumber
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AdderTwoStringNumber();
        }
        #region Question by Endless Clouds Inc
        const int MAX_NUMBERS_OF_DIGITS = 9;
        const string chars = "1234567890";

        static string RandomBigNumberStr()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            var strArray = Enumerable.Repeat(chars, MAX_NUMBERS_OF_DIGITS).Select(s => s[r.Next(chars.Length)]).ToArray();
            return new string(strArray).TrimStart('0');
        }
        #endregion


        #region Question by William
        static void AdderTwoStringNumber()
        {

            string NumberA = RandomBigNumberStr();
            string NumberB = RandomBigNumberStr();

            string SumAB = Add(NumberA, NumberB);

        }

        static string Add(string s1, string s2)
        {
            return (Helper(s1) + Helper(s2)).ToString();
        }

        static long Helper(string s)
        {
            int len = s.Length;
            long sum = 0;
            long multiplier = 1;
            for (int i = len - 1; i >= 0; i--)
            {
                sum += (s[i] - 48) * multiplier;
                multiplier *= 10;
            }
            return sum;
        }
        #endregion
    }
}
