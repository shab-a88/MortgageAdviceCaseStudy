using MortgageAdviceTech.PalindromesTask;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MortgageAdviceTech.Tests
{
    public class PalindromesTest
    {
        [Fact]
        public void PalindromeReturnTrue() 
        {
            var p = new Palindromes();

            var pw = p.IsPalindromes("A man a plan a canal Panama");

            Assert.True(pw);
        }

        [Fact]
        public void PalindromeReturnFalse()
        {
            var p = new Palindromes();

            var pw = p.IsPalindromes("laptop");

            Assert.False(pw);
        }
    }
}
