﻿using System.Collections.Generic;
using System.Linq;

/*
 * 690. Employee Importance
 * https://leetcode.com/problems/employee-importance/description/
 */
namespace GetImportance
{
    class Program
    {
        /*
         * You are given a data structure of employee information, which includes the employee's unique id,
         * his importance value and his direct subordinates' id.
         *
         * For example, employee 1 is the leader of employee 2, and employee 2 is the leader of employee 3.
         * They have importance value 15, 10 and 5, respectively. Then employee 1 has a data structure like [1, 15, [2]],
         * and employee 2 has [2, 10, [3]], and employee 3 has [3, 5, []].
         * Note that although employee 3 is also a subordinate of employee 1, the relationship is not direct.
         *
         * Now given the employee information of a company, and an employee id,
         * you need to return the total importance value of this employee and all his subordinates.
         *
         * Example 1:
         * Input: [[1, 5, [2, 3]], [2, 3, []], [3, 3, []]], 1
         * Output: 11
         * Explanation:
         * Employee 1 has importance value 5, and he has two direct subordinates: employee 2 and employee 3.
         * They both have importance value 3. So the total importance value of employee 1 is 5 + 3 + 3 = 11.
         *
         * Note:
         * 1. One employee has at most one direct leader and may have several subordinates.
         * 2. The maximum number of employees won't exceed 2000.
         *
         */
        static void Main(string[] args)
        {
            var result = GetImportance(new List<Employee>
            {
                new Employee{ Id = 1, Importance = 5, Subordinates = new List<int> {2, 3} },
                new Employee{ Id = 2, Importance = 3 },
                new Employee{ Id = 3, Importance = 3 }
            }, 1);
        }

        public static int GetImportance(List<Employee> employees, int id)
        {
            var manager = employees.Single(x => x.Id == id);
            var sum = manager.Importance;

            foreach (var x in employees)
            {
                if (manager.Subordinates.Contains(x.Id))
                {
                    sum += x.Importance;
                }
            }

            return sum;
        }
    }

    public class Employee
    {
        public int Id;
        public int Importance;
        public List<int> Subordinates;
    }
}
