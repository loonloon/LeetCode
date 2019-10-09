/*
 * 953. Verifying an Alien Dictionary
 * https://leetcode.com/problems/verifying-an-alien-dictionary/
 */
namespace IsAlienSorted
{
    class Program
    {
        /*
         * In an alien language, surprisingly they also use english lowercase letters, but possibly in a different order.
         * The order of the alphabet is some permutation of lowercase letters.
         *
         * Given a sequence of words written in the alien language, and the order of the alphabet,
         * return true if and only if the given words are sorted lexicographicaly in this alien language.
         *
         * Example 1:
         * Input: words = ["hello","leetcode"], order = "hlabcdefgijkmnopqrstuvwxyz"
         * Output: true
         * Explanation: As 'h' comes before 'l' in this language, then the sequence is sorted.
         *
         * Example 2:
         * Input: words = ["word","world","row"], order = "worldabcefghijkmnpqstuvxyz"
         * Output: false
         * Explanation: As 'd' comes after 'l' in this language, then words[0] > words[1], hence the sequence is unsorted.
         *
         * Example 3:
         * Input: words = ["apple","app"], order = "abcdefghijklmnopqrstuvwxyz"
         * Output: false
         * Explanation: The first three characters "app" match, and the second string is shorter (in size.)
         * According to lexicographical rules "apple" > "app", because 'l' > '∅', where '∅' is defined as the blank character
         * which is less than any other character (More info).
         *
         * Note:
         * 1 <= words.length <= 100
         * 1 <= words[i].length <= 20
         * order.length == 26
         * All characters in words[i] and order are english lowercase letters.
         *
         */
        static void Main(string[] args)
        {
            var result = IsAlienSorted(new[] { "hello", "leetcode" }, "hlabcdefgijkmnopqrstuvwxyz");
            var result2 = IsAlienSorted(new[] { "word", "world", "row" }, "worldabcefghijkmnpqstuvxyz");
            var result3 = IsAlienSorted(new[] { "apple", "app" }, "abcdefghijklmnopqrstuvwxyz");
        }

        public static bool IsAlienSorted(string[] words, string order)
        {
            for (var i = 0; i < words.Length - 1; i++)
            {
                var wordOne = words[i].ToCharArray();
                var wordTwo = words[i + 1].ToCharArray();
                var index = 0;

                while (index < wordOne.Length && index < wordTwo.Length)
                {
                    // get the index of each words character 
                    var posOne = order.IndexOf(wordOne[index]);
                    var posTwo = order.IndexOf(wordTwo[index]);

                    // if the first words character is ever greater than the second, it lexicographicaly should be the latter
                    if (posOne > posTwo)
                    {
                        return false;
                    }

                    // if the first words character is less than the second at any position, its already in order
                    if (posOne < posTwo)
                    {
                        break;
                    }

                    index++;

                    // where one word is a smaller permutation of the next, make sure the longer one is the latter
                    if (index > (wordTwo.Length - 1))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
