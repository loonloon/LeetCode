using System;
/*
 * 748. Shortest Completing Word
 * https://leetcode.com/problems/shortest-completing-word/
 */
namespace ShortestCompletingWord
{
    class Program
    {
        /*
         * Find the minimum length word from a given dictionary words, which has all the letters from the string licensePlate.
         * Such a word is said to complete the given string licensePlate
         * Here, for letters we ignore case. For example, "P" on the licensePlate still matches "p" on the word.
         * It is guaranteed an answer exists. If there are multiple answers, return the one that occurs first in the array.
         *
         * The license plate might have the same letter occurring multiple times.
         * For example, given a licensePlate of "PP", the word "pair" does not complete the licensePlate, but the word "supper" does.
         *
         * Example 1:
         * Input: licensePlate = "1s3 PSt", words = ["step", "steps", "stripe", "stepple"]
         * Output: "steps"
         * Explanation: The smallest length word that contains the letters "S", "P", "S", and "T".
         *
         * Note that the answer is not "step", because the letter "s" must occur in the word twice.
         * Also note that we ignored case for the purposes of comparing whether a letter exists in the word.
         *
         * Example 2:
         * Input: licensePlate = "1s3 456", words = ["looks", "pest", "stew", "show"]
         * Output: "pest"
         * Explanation: There are 3 smallest length words that contains the letters "s". We return the one that occurred first.
         *
         * Note:
         * licensePlate will be a string with length in range [1, 7].
         * licensePlate will contain digits, spaces, or letters (uppercase or lowercase).
         * words will have a length in the range [10, 1000].
         * Every words[i] will consist of lowercase letters, and have length in range [1, 15].
         *
         */
        static void Main(string[] args)
        {
            var result = ShortestCompletingWord("1s3 PSt", new[] { "step", "steps", "stripe", "stepple" });
            var result2 = ShortestCompletingWord("1s3 456", new[] { "looks", "pest", "stew", "show" });
        }

        public static string ShortestCompletingWord(string licensePlate, string[] words)
        {
            var characterArray = new int[26];

            for (var i = 0; i < licensePlate.Length; i++)
            {
                if (!char.IsLetter(licensePlate[i]))
                {
                    continue;
                } 

                var lowerCharacter = licensePlate[i] < 97 || licensePlate[i] > 122 ? char.ToLower(licensePlate[i]) : licensePlate[i]; 
                characterArray[lowerCharacter - 'a']++;
            }

            var temp = new int[characterArray.Length];
            var highestHitCount = int.MinValue;
            var highestHitCountIndex = 0;

            for (var i = 0; i < words.Length; i++)
            {
                var word = words[i];
                Array.Copy(characterArray, temp, characterArray.Length);
                var hitCount = 0;

                for (var j = 0; j < word.Length; j++)
                {
                    var ascii = word[j] - 'a';

                    if (temp[ascii] > 0)
                    {
                        hitCount++;
                        temp[ascii]--;
                    }
                }

                if (hitCount > highestHitCount || 
                    hitCount == highestHitCount && words[i].Length < words[highestHitCountIndex].Length)
                {
                    highestHitCount = hitCount;
                    highestHitCountIndex = i;
                }
            }

            return words[highestHitCountIndex];
        }
    }
}
