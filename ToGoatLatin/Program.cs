﻿using System.Linq;
using System.Text;

/*
 * 824. Goat Latin
 * https://leetcode.com/problems/goat-latin/description/
 */

namespace ToGoatLatin
{
    class Program
    {
        /*
         * A sentence S is given, composed of words separated by spaces. Each word consists of lowercase and uppercase letters only.
         *
         * We would like to convert the sentence to "Goat Latin" (a made-up language similar to Pig Latin.)
         * The rules of Goat Latin are as follows:
         *
         * If a word begins with a vowel (a, e, i, o, or u), append "ma" to the end of the word.
         * For example, the word 'apple' becomes 'applema'.
         *
         * If a word begins with a consonant (i.e. not a vowel), remove the first letter and append it to the end, then add "ma".
         * For example, the word "goat" becomes "oatgma".
         *
         * Add one letter 'a' to the end of each word per its word index in the sentence, starting with 1.
         * For example, the first word gets "a" added to the end, the second word gets "aa" added to the end and so on.
         *
         * Return the final sentence representing the conversion from S to Goat Latin.
         *
         * Example 1:
         * Input: "I speak Goat Latin"
         * Output: "Imaa peaksmaaa oatGmaaaa atinLmaaaaa"
         *
         * Example 2:
         * Input: "The quick brown fox jumped over the lazy dog"
         * Output: "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa"
         *
         * Notes:
         * S contains only uppercase, lowercase and spaces. Exactly one space between each word.
         * 1 <= S.length <= 150.
         *
         */
        static void Main(string[] args)
        {
            var result = ToGoatLatin("I speak Goat Latin");
            var result2 = ToGoatLatin("The quick brown fox jumped over the lazy dog");
        }

        public static string ToGoatLatin(string S)
        {
            var vowel = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var goatLatin = new StringBuilder();
            var words = S.Split(' ');
            int j, i = 0;

            foreach (var word in words)
            {
                goatLatin.Append(" ");
                goatLatin.Append(vowel.Contains(word[0]) ? word : $"{word.Substring(1)}{word[0]}");
                goatLatin.Append("ma");

                for (j = 0, i++; j < i; j++)
                {
                    goatLatin.Append("a");
                }
            }

            return goatLatin.ToString().Substring(1);
        }
    }
}
