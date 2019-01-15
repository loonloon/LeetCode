using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
/*
 * 888. Uncommon Words from Two Sentences
 * https://leetcode.com/problems/uncommon-words-from-two-sentences/description/
 */
namespace UncommonFromSentences
{
    class Program
    {
        /*
         * We are given two sentences A and B.  (A sentence is a string of space separated words.  Each word consists only of lowercase letters.)
         * A word is uncommon if it appears exactly once in one of the sentences, and does not appear in the other sentence.
         *
         * Return a list of all uncommon words.
         * You may return the list in any order.
         *
         * Example 1:
         * Input: A = "this apple is sweet", B = "this apple is sour"
         * Output: ["sweet","sour"]
         *
         * Example 2:
         * Input: A = "apple apple", B = "banana"
         * Output: ["banana"]
         *
         * Note:
         * 1. 0 <= A.length <= 200
         * 2. 0 <= B.length <= 200
         * 3. A and B both contain only spaces and lowercase letters.
         *
         */
        static void Main(string[] args)
        {
            var result = UncommonFromSentences("this apple is sweet", "this apple is sour");
            var result2 = UncommonFromSentences("apple apple", "banana");
        }

        public static string[] UncommonFromSentences(string A, string B)
        {
            var dictionary = new Dictionary<string, int>();
            var words = $"{A} {B}".Split(' ');

            foreach (var word in words)
            {
                int count;

                if (dictionary.TryGetValue(word, out count))
                {
                    dictionary[word] = count + 1;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }

            var uncommonList = new List<string>();

            foreach (var key in dictionary.Keys)
            {
                if (dictionary[key] == 1)
                {
                    uncommonList.Add(key);
                }
            }

            return uncommonList.ToArray();
        }
    }
}
