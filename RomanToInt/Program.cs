/*
 * 13. Roman to Integer
 * https://leetcode.com/problems/roman-to-integer/description/
 */
namespace RomanToInt
{
    class Program
    {
        /*
         * Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
         * Symbol       Value
         * I             1
         * V             5
         * X             10
         * L             50
         * C             100
         * D             500
         * M             1000
         *
         * For example, two is written as II in Roman numeral, just two one's added together.
         * Twelve is written as, XII, which is simply X + II. The number twenty seven is written as XXVII, which is XX + V + II.
         *
         * Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII.
         * Instead, the number four is written as IV. Because the one is before the five we subtract it making four.
         * The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:
         * I can be placed before V (5) and X (10) to make 4 and 9.
         * X can be placed before L (50) and C (100) to make 40 and 90.
         * C can be placed before D (500) and M (1000) to make 400 and 900.
         *
         * Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999.
         *
         * Example 1:
         * Input: "III"
         * Output: 3
         *
         * Example 2:
         * Input: "IV"
         * Output: 4
         *
         * Example 3:
         * Input: "IX"
         * Output: 9
         *
         * Example 4:
         * Input: "LVIII"
         * Output: 58
         * Explanation: C = 100, L = 50, XXX = 30 and III = 3.
         *
         * Example 5:
         * Input: "MCMXCIV"
         * Output: 1994
         * Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
         *
         */
        static void Main(string[] args)
        {
            var result = RomanToInt("III");
            var result2 = RomanToInt("IV");
            var result3 = RomanToInt("IX");
            var result4 = RomanToInt("LVIII");
            var result5 = RomanToInt("MCMXCIV");
        }

        public static int RomanToInt(string s)
        {
            var total = 0;

            if (s.Contains("IV")) { total -= 2; }
            if (s.Contains("IX")) { total -= 2; }
            if (s.Contains("XL")) { total -= 20; }
            if (s.Contains("XC")) { total -= 20; }
            if (s.Contains("CD")) { total -= 200; }
            if (s.Contains("CM")) { total -= 200; }

            foreach (var character in s)
            {
                switch (character)
                {
                    case 'M':
                        total += 1000;
                        break;
                    case 'D':
                        total += 500;
                        break;
                    case 'C':
                        total += 100;
                        break;
                    case 'L':
                        total += 50;
                        break;
                    case 'X':
                        total += 10;
                        break;
                    case 'V':
                        total += 5;
                        break;
                    case 'I':
                        total += 1;
                        break;
                }
            }

            return total;
        }
    }
}
