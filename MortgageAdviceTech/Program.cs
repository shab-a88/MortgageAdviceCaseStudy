using MortgageAdviceTech.Models;
using MortgageAdviceTech.PalindromesTask;
using System;

namespace MortgageAdviceTech
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. SORTED ARRAY SMALLEST TO HIGHEST
            int[] nums = new int[] { 9, 12, 4, 7, 8, 11 };
            var a = new SortArray();
            var ar = a.SortedArrayByLowestNumber(nums);
            foreach (var i in ar) 
            {
                Console.WriteLine(i);
            }

            // 2. FIBONNACI CALCULATE NTH SEQUENCE

            var f = Fibonacci.CalculateNthFibonacci(13);
            Console.WriteLine(f);

            // 3. PALINDROME

            var p = new Palindromes();
            var ps = p.IsPalindromes("A man a plan a canal Panama");
            Console.WriteLine(ps);

            // 4. SQUARE ROOT

            var r = new SquareRoot();
            var sq = r.SquareRootNumber(60);
            Console.WriteLine(sq);
        }
    }
}
