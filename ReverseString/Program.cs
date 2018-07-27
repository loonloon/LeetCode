using System.Linq;

/*
 * 344. Reverse String
 */
namespace ReverseString
{
    class Program
    {
        /*
         * Write a function that takes a string as input and returns the string reversed.
         *
         * Example:
         * Given s = "hello", return "olleh".
         *
         */
        static void Main(string[] args)
        {
            var result = ReverseString("hello");
        }

        public static string ReverseString(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            var result = s.ToArray();

            for (var i = 0; i < result.Length / 2; i++)
            {
                var temp = result[result.Length - 1 - i];

                if (result[i] == temp)
                {
                    continue;
                }

                result[result.Length - 1 - i] = result[i];
                result[i] = temp;
            }

            return new string(result);

            //Initial O(n)
            //var result = "";

            //for (var i = s.Length - 1; i >= 0; i--)
            //{
            //    result += s[i];
            //}

            //return result;
        }
    }
}
