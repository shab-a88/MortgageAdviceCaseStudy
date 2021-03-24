using MortgageAdviceTech.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MortgageAdviceTech.Tests
{
    public class SqaureRootTest
    {
        [Fact]
        public void SquareRootOfNine() 
        {
            var r = new SquareRoot();
            var sq = r.SquareRootNumber(9);

            var actual = 3;

            Assert.Equal(sq, actual);
        }

        [Fact]
        public void SquareRootOf60()
        {
            var r = new SquareRoot();
            var sq = r.SquareRootNumber(60);
            var actual = 7.745966692414834;
            Assert.Equal(sq, actual);
        }
    }
}
