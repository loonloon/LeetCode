/*
 * 917. Reverse Only Letters
 * https://leetcode.com/problems/reverse-only-letters/
 */
namespace ReverseOnlyLetters
{
    class Program
    {
        /*
         * Given a string S, return the "reversed" string where all characters that are not a letter stay in the same place,
         * and all letters reverse their positions.
         *
         * Example 1:
         * Input: "ab-cd"
         * Output: "dc-ba"
         *
         * Example 2:
         * Input: "a-bC-dEf-ghIj"
         * Output: "j-Ih-gfE-dCba"
         *
         * Example 3:
         * Input: "Test1ng-Leet=code-Q!"
         * Output: "Qedo1ct-eeLg=ntse-T!"
         *
         * Note:
         * S.length <= 100
         * 33 <= S[i].ASCIIcode <= 122
         * S doesn't contain \ or "
         *
         */
        static void Main(string[] args)
        {
            var result = ReverseOnlyLetters("ab-cd");
            var result2 = ReverseOnlyLetters("a-bC-dEf-ghIj");
            var result3 = ReverseOnlyLetters("Test1ng-Leet=code-Q!");
        }

        public static string ReverseOnlyLetters(string S)
        {
            var charArr = S.ToCharArray();
            var leftPointerIndex = 0;
            var rightPointerIndex = charArr.Length - 1;

            for (var i = 0; i < charArr.Length; i++)
            {
                if (leftPointerIndex >= rightPointerIndex)
                {
                    break;
                }

                var leftLetter = charArr[leftPointerIndex];

                if (!char.IsLetter(leftLetter))
                {
                    leftPointerIndex++;
                    continue;
                }

                var rightLetter = charArr[rightPointerIndex];

                if (!char.IsLetter(rightLetter))
                {
                    rightPointerIndex--;
                    continue;
                }

                var temp = leftLetter;
                charArr[leftPointerIndex] = rightLetter;
                charArr[rightPointerIndex] = temp;
                leftPointerIndex++;
                rightPointerIndex--;
            }

            return new string(charArr);
        }
    }
}
