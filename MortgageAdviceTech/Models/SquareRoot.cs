using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageAdviceTech.Models
{
    public class SquareRoot
    {
        public double SquareRootNumber(long n) 
        {
            double number = Convert.ToDouble(n);

            if(number > 0) 
            {
                double root = number / 3;
                int i;
                for(i = 0; i < 32; i++) 
                {
                    root = (root + number / root) / 2;
                }
                return root;
            }

            return number;
        }
    }
}
