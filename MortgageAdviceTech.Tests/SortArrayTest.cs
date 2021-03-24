using MortgageAdviceTech.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MortgageAdviceTech.Tests
{
    public class SortArrayTest
    {
        [Fact]
        public void SortedArrayByLowestNumber() 
        {
            // ACTUAL
            int[] actual = new int[] { 4, 7, 8, 9, 11, 12 };

            int[] nums = new int[] { 9, 12, 4, 7, 8, 11 };
            var a = new SortArray();
            var result = a.SortedArrayByLowestNumber(nums);

            Assert.Equal(result, actual);
        }
    }
}
