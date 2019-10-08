/*
 * 1185. Day of the Week
 * https://leetcode.com/problems/day-of-the-week/
 */
namespace DayOfTheWeek
{
    class Program
    {
        /*
         * Given a date, return the corresponding day of the week for that date.
         * The input is given as three integers representing the day, month and year respectively.
         * Return the answer as one of the following values {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}.
         *
         * Example 1:
         * Input: day = 31, month = 8, year = 2019
         * Output: "Saturday"
         *
         * Example 2:
         * Input: day = 18, month = 7, year = 1999
         * Output: "Sunday"
         *
         * Example 3:
         * Input: day = 15, month = 8, year = 1993
         * Output: "Sunday"
         *
         * Constraints:
         * The given dates are valid dates between the years 1971 and 2100.
         *
         */
        static void Main(string[] args)
        {
            var result = DayOfTheWeek(31, 8, 2019);
            var result2 = DayOfTheWeek(18, 7, 1999);
            var result3 = DayOfTheWeek(15, 8, 1993);
        }

        public static string DayOfTheWeek(int day, int month, int year)
        {
            //1971.1.1 is Friday
            var leapMonths = new[] { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            var notLeapMonths = new[] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            var dayInString = new[] { "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Monday" };

            var newYear = year - 1971;
            var dayIndex = 0;

            for (var i = newYear; i < UPPER; i++)
            {
                
            }

            if (year % 4 == 0)
            {
                dayIndex += ;
            }
            else
            {
                dayIndex += ;
            }

            return dayInString[dayIndex % 7];
        }
    }
}
