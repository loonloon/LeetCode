﻿/*
 * 299. Bulls and Cows
 * https://leetcode.com/problems/bulls-and-cows/
 */
namespace GetHint
{
    class Program
    {
        /*
         * You are playing the following Bulls and Cows game with your friend: You write down a number and ask your friend to guess what the number is.
         *
         * Each time your friend makes a guess, you provide a hint that indicates how many digits in said guess match your secret number exactly in both digit and position (called "bulls")
         * and how many digits match the secret number but locate in the wrong position (called "cows"). Your friend will use successive guesses and hints to eventually derive the secret number.
         *
         * Write a function to return a hint according to the secret number and friend's guess, use A to indicate the bulls and B to indicate the cows.
         * Please note that both secret number and friend's guess may contain duplicate digits.
         *
         * Example 1:
         * Input: secret = "1807", guess = "7810"
         * Output: "1A3B"
         * Explanation: 1 bull and 3 cows. The bull is 8, the cows are 0, 1 and 7.
         *
         * Example 2:
         * Input: secret = "1123", guess = "0111"
         * Output: "1A1B"
         *
         * Explanation: The 1st 1 in friend's guess is a bull, the 2nd or 3rd 1 is a cow.
         * Note: You may assume that the secret number and your friend's guess only contain digits, and their lengths are always equal.
         */
        static void Main(string[] args)
        {
            var result = GetHint("1807", "7810");
            var result2 = GetHint("1123", "0111");
        }

        public static string GetHint(string secret, string guess)
        {
            var bulls = 0;
            var cows = 0;

            //table records the appearance of a digit
            //digit from secret will increase the counter
            //digit from guess will decrease the counter
            var numbers = new int[10];

            for (var i = 0; i < secret.Length; i++)
            {
                var s = secret[i] - '0';
                var g = guess[i] - '0';

                if (s == g)
                {
                    bulls++;
                }
                else
                {
                    //if prev part of guess has curr digit in secret
                    //then we found a pair that has same digit with different position
                    if (numbers[s] < 0)
                    {
                        cows++;
                    }

                    //if prev part of secret has curr digit in guess
                    //then we found a pair that has same digit with different position                
                    if (numbers[g] > 0)
                    {
                        cows++;
                    }

                    numbers[s]++;
                    numbers[g]--;
                }
            }

            return $"{bulls}A{cows}B";
        }
    }
}
