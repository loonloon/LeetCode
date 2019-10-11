using System.Collections.Generic;
/*
 * 937. Reorder Data in Log Files
 * https://leetcode.com/problems/reorder-data-in-log-files/
 */
namespace ReorderLogFiles
{
    class Program
    {
        /*
         * You have an array of logs.  Each log is a space delimited string of words.
         * For each log, the first word in each log is an alphanumeric identifier.  Then, either:
         *
         * Each word after the identifier will consist only of lowercase letters, or;
         * Each word after the identifier will consist only of digits.
         *
         * We will call these two varieties of logs letter-logs and digit-logs.
         * It is guaranteed that each log has at least one word after its identifier.
         *
         * Reorder the logs so that all of the letter-logs come before any digit-log.
         * The letter-logs are ordered lexicographically ignoring identifier, with the identifier used in case of ties.
         * The digit-logs should be put in their original order.
         * Return the final order of the logs.
         *
         * Example 1:
         * Input: logs = ["dig1 8 1 5 1","let1 art can","dig2 3 6","let2 own kit dig","let3 art zero"]
         * Output: ["let1 art can","let3 art zero","let2 own kit dig","dig1 8 1 5 1","dig2 3 6"]
         *
         * Constraints:
         * 0 <= logs.length <= 100
         * 3 <= logs[i].length <= 100
         * logs[i] is guaranteed to have an identifier, and a word after the identifier.
         *
         */
        static void Main(string[] args)
        {
            var result = ReorderLogFiles(new[] { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" });
        }

        public static string[] ReorderLogFiles(string[] logs)
        {
            var letterList = new List<string>();
            var digitList = new List<string>();

            for (var i = 0; i < logs.Length; i++)
            {
                var spaceIndex = logs[i].IndexOf(' ');
                var c = logs[i][spaceIndex + 1];

                if (c - '0' <= 9)
                {
                    digitList.Add(logs[i]);
                }
                else
                {
                    letterList.Add(logs[i]);
                }
            }

            letterList.Sort((s1, s2) =>
            {
                var spaceIndex1 = s1.IndexOf(' ');
                var spaceIndex2 = s2.IndexOf(' ');

                var letter1 = s1.Substring(spaceIndex1);
                var letter2 = s2.Substring(spaceIndex2);
                var letterResult = letter1.CompareTo(letter2);

                if (letterResult != 0)
                {
                    return letterResult;
                }

                var id1 = s1.Substring(0, spaceIndex1);
                var id2 = s2.Substring(0, spaceIndex2);

                return id1.CompareTo(id2);
            });

            var result = new string[logs.Length];

            for (var i = 0; i < letterList.Count; i++)
            {
                result[i] = letterList[i];
            }

            for (var i = 0; i < digitList.Count; i++)
            {
                result[i + letterList.Count] = digitList[i];
            }

            return result;
        }
    }
}
