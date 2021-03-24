using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MortgageAdviceTech.PalindromesTask
{
    public class Palindromes
    {
        public bool IsPalindromes(string s) 
        {
            char[] reverseStringToArray = s.ToCharArray();
            Array.Reverse(reverseStringToArray);
            string reverseToString = new string(reverseStringToArray);

            string forwardString = Regex.Replace(s, @"\s", "");
            string backwardString = Regex.Replace(reverseToString, @"\s", "");

            if (forwardString.Equals(backwardString, StringComparison.InvariantCultureIgnoreCase)) 
            {
                return true;
            }

            return false;
        }
    }
}
