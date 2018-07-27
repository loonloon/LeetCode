using System.Text;

namespace ToLowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.asciitable.com/
            var result = ToLowerCase("Hello");
            var result2 = ToLowerCase("here");
            var result3 = ToLowerCase("LOVELY");
        }

        public static string ToLowerCase(string str)
        {
            var stringBuilder = new StringBuilder();

            foreach (var t in str)
            {
                var ascii = (int)t;

                if (ascii >= 65 && ascii <= 90)
                {
                    ascii += 32;
                }

                stringBuilder.Append((char)ascii);
            }

            return stringBuilder.ToString();
        }
    }
}
