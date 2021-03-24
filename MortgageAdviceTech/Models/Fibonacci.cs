using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageAdviceTech.Models
{
    public static class Fibonacci
    {
        public static int CalculateNthFibonacci(int n) 
        {
            if(n == 0) 
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else 
            {
                return CalculateNthFibonacci(n - 1) + CalculateNthFibonacci(n - 2);
            }
        }
    }
}
