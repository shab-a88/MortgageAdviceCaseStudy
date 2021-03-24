using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MortgageAdviceTech.Models
{
    public class SortArray
    {
        public int[] SortedArrayByLowestNumber(int[] arr) 
        {
            var sorted = arr.OrderBy(i => i);

            return sorted.ToArray();
        }
    }
}
