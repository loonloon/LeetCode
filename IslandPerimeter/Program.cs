/*
 * 463. Island Perimeter
 * https://leetcode.com/problems/island-perimeter/description/
 */

using System;

namespace IslandPerimeter
{
    class Program
    {
        /*
         * You are given a map in form of a two-dimensional integer grid where 1 represents land and 0 represents water.
         * Grid cells are connected horizontally/vertically (not diagonally).
         * The grid is completely surrounded by water, and there is exactly one island (i.e., one or more connected land cells).
         * The island doesn't have "lakes" (water inside that isn't connected to the water around the island). One cell is a square with side length 1.
         * The grid is rectangular, width and height don't exceed 100. Determine the perimeter of the island.
         *
         * Example:
         * [[0,1,0,0],
         * [1,1,1,0],
         * [0,1,0,0],
         * [1,1,0,0]]
         *
         * Answer: 16
         * Explanation: The perimeter is the 16 yellow stripes in the image below:
         *
         */
        static void Main(string[] args)
        {
            var result = IslandPerimeter(new[,]
            {
                { 0, 1, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 1, 0, 0 },
                { 1, 1, 0, 0 }
            });
        }

        public static int IslandPerimeter(int[,] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            var perimeter = 0;

            //row
            for (var i = 0; i < grid.GetLength(0); i++)
            {
                //column
                for (var j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] != 1)
                    {
                        continue;
                    }

                    perimeter += 4;

                    //left
                    if (j - 1 >= 0 && grid[i, j - 1] == 1)
                    {
                        --perimeter;
                    }

                    //right
                    if (j + 1 < grid.GetLength(1) && grid[i, j + 1] == 1)
                    {
                        --perimeter;
                    }

                    //up
                    if (i - 1 >= 0 && grid[i - 1, j] == 1)
                    {
                        --perimeter;
                    }

                    //down
                    if (i + 1 < grid.GetLength(0) && grid[i + 1, j] == 1)
                    {
                        --perimeter;
                    }
                }
            }

            return perimeter;
        }
    }
}
