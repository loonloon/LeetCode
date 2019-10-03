/*
 * 1108. Defanging an IP Address
 * https://leetcode.com/problems/defanging-an-ip-address/
 */
namespace DefangIPaddr
{
    class Program
    {
        /*
         * Given a valid (IPv4) IP address, return a defanged version of that IP address.
         * A defanged IP address replaces every period "." with "[.]".
         *
         * Example 1:
         * Input: address = "1.1.1.1"
         * Output: "1[.]1[.]1[.]1"
         *
         * Example 2:
         * Input: address = "255.100.50.0"
         * Output: "255[.]100[.]50[.]0"
         *
         * Constraints:
         * The given address is a valid IPv4 address.
         *
         */
        static void Main(string[] args)
        {
            var result = DefangIPaddr("1.1.1.1");
            var result2 = DefangIPaddr("255.100.50.0");
        }

        public static string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}
