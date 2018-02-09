namespace RomanNumeralConverter
{
    using System;
    using System.Linq;

    public class RomanConvert
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Solution(3999));
            Console.ReadKey();
        }

        public static string Solution(int n)
        {
            var romanNum = new string[][] {new string[] {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"},
                                           new string[] {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"},
                                           new string[] {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"},
                                           new string[] {"", "M", "MM", "MMM"}};

            // Pulls out the individual digits, starting with the ONES place.
            var nums = n.ToString().ToCharArray().Reverse().Select(c => byte.Parse(c.ToString())).ToArray();
            var roman = String.Empty;

            for (int i = 0; i < nums.Length; i++)
            {
                roman = String.Concat(romanNum[i][nums[i]], roman);
            }

            return roman;
        }
    }
}
