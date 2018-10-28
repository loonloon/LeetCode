﻿using System.Linq;

/*
 * 551. Student Attendance Record I
 * https://leetcode.com/problems/student-attendance-record-i/
 */

namespace CheckRecord
{
    class Program
    {
        /*
         * You are given a string representing an attendance record for a student. The record only contains the following three characters:
         * 'A' : Absent.
         * 'L' : Late.
         * 'P' : Present.
         *
         * A student could be rewarded if his attendance record doesn't contain more than one 'A' (absent) or more than two continuous 'L' (late).
         * You need to return whether the student could be rewarded according to his attendance record.
         *
         * Example 1:
         * Input: "PPALLP"
         * Output: True
         *
         * Example 2:
         * Input: "PPALLL"
         * Output: False
         *
         */
        static void Main(string[] args)
        {
            var result = CheckRecord("PPALLP");
            var result2 = CheckRecord("PPALLL");
        }

        public static bool CheckRecord(string s)
        {
            return !s.Contains("LLL") && s.Count(x => x == 'A') <= 1;
        }
    }
}
