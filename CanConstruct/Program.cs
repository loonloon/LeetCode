/*
 * 383. Ransom Note
 * https://leetcode.com/problems/ransom-note/description/
 */
namespace CanConstruct
{
    class Program
    {
        /*
         * Given an arbitrary ransom note string and another string containing letters from all the magazines,
         * write a function that will return true if the ransom note can be constructed from the magazines ; otherwise, it will return false.
         * Each letter in the magazine string can only be used once in your ransom note.
         *
         * Note:
         * You may assume that both strings contain only lowercase letters.
         * canConstruct("a", "b") -> false
         * canConstruct("aa", "ab") -> false
         * canConstruct("aa", "aab") -> true
         *
         */
        static void Main(string[] args)
        {
            var result = CanConstruct("a", "b");
            var result2 = CanConstruct("aa", "ab");
            var result3 = CanConstruct("aa", "aab");
        }

        public static bool CanConstruct(string ransomNote, string magazine)
        {
            //Solution 3
            //only consider a -> z
            var table = new int[26];

            foreach (var c in magazine)
            {
                table[c - 'a']++;
            }

            foreach (var c in ransomNote)
            {
                if (--table[c - 'a'] < 0)
                {
                    return false;
                }
            }

            return true;

            //Solution 2
            //var table = new int[128];

            //foreach (var c in magazine)
            //{
            //    table[c]++;
            //}

            //foreach (var c in ransomNote)
            //{
            //    if (--table[c] < 0)
            //    {
            //        return false;
            //    }
            //}

            //return true;

            //Solution 1
            //var magazineChars = magazine.ToCharArray().ToList();

            //foreach (var ransomNoteChar in ransomNote)
            //{
            //    if (!magazineChars.Remove(ransomNoteChar))
            //    {
            //        return false;
            //    }
            //}

            //return true;
        }
    }
}
