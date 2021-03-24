using MortgageAdviceTech.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MortgageAdviceTech.Tests
{
    public class FibonacciTest
    {
        [Fact]
        public void Fibonacci4thSequence() 
        {
            var f = Fibonacci.CalculateNthFibonacci(4);

            var actual = 3;
            Assert.Equal(f, actual);
        }

        [Fact]
        public void Fibonacci13thSequence()
        {
            var f = Fibonacci.CalculateNthFibonacci(13);

            var actual = 233;
            Assert.Equal(f, actual);
        }
    }
}
