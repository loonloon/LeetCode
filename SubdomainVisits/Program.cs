using System;
using System.Collections.Generic;

/*
 * 811. Subdomain Visit Count
 * https://leetcode.com/problems/subdomain-visit-count/description/
 */

namespace SubdomainVisits
{
    class Program
    {
        /*
         * A website domain like "discuss.leetcode.com" consists of various subdomains. At the top level, we have "com", at the next level,
         * we have "leetcode.com", and at the lowest level, "discuss.leetcode.com". When we visit a domain like "discuss.leetcode.com",
         * we will also visit the parent domains "leetcode.com" and "com" implicitly.
         *
         * Now, call a "count-paired domain" to be a count (representing the number of visits this domain received),
         * followed by a space, followed by the address. An example of a count-paired domain might be "9001 discuss.leetcode.com".
         *
         * We are given a list cpdomains of count-paired domains. We would like a list of count-paired domains,
         * (in the same format as the input, and in any order), that explicitly counts the number of visits to each subdomain.
         *
         * Example 1:
         * Input:
         * ["9001 discuss.leetcode.com"]
         *
         * Output:
         * ["9001 discuss.leetcode.com", "9001 leetcode.com", "9001 com"]
         *
         * Explanation:
         * We only have one website domain: "discuss.leetcode.com". As discussed above, the subdomain "leetcode.com" and
         * "com" will also be visited. So they will all be visited 9001 times.
         *
         * Example 2:
         * Input:
         * ["900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org"]
         *
         * Output:
         * ["901 mail.com","50 yahoo.com","900 google.mail.com","5 wiki.org","5 org","1 intel.mail.com","951 com"]
         *
         * Explanation:
         * We will visit "google.mail.com" 900 times, "yahoo.com" 50 times, "intel.mail.com" once and "wiki.org" 5 times.
         * For the subdomains, we will visit "mail.com" 900 + 1 = 901 times, "com" 900 + 50 + 1 = 951 times, and "org" 5 times.
         *
         * Notes:
         * The length of cpdomains will not exceed 100.
         * The length of each domain name will not exceed 100.
         * Each address will have either 1 or 2 "." characters.
         * The input count in any count-paired domain will not exceed 10000.
         * The answer output can be returned in any order.
         *
         */
        static void Main(string[] args)
        {
            var result = SubdomainVisits(new[] { "9001 discuss.leetcode.com" });
            var result2 = SubdomainVisits(new[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" });
        }

        public static IList<string> SubdomainVisits(string[] cpdomains)
        {
            var dictionary = new Dictionary<string, int>();

            foreach (var cd in cpdomains)
            {
                var splitString = cd.Split(' ');
                var number = Convert.ToInt32(splitString[0]);
                var domain = splitString[1];
                int numberFromDictionary;

                for (var i = 0; i < domain.Length; ++i)
                {
                    if (domain[i] != '.')
                    {
                        continue;
                    }

                    var parentDomain = domain.Substring(i + 1);

                    //NET's Dictionary will replace the existing value with the new one if you use [] indexing.
                    //If you use the Add method, it will instead throw an ArgumentException.
                    dictionary[parentDomain] = (dictionary.TryGetValue(parentDomain, out numberFromDictionary) ? numberFromDictionary : 0) + number;
                }

                dictionary[domain] = (dictionary.TryGetValue(domain, out numberFromDictionary) ? numberFromDictionary : 0) + number;
            }

            var res = new List<string>();

            foreach (var d in dictionary)
            {
                res.Add($"{dictionary[d.Key]} {d.Key}");
            }

            return res;
        }
    }
}
