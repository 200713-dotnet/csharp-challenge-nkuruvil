using System;
using Xunit;
using Palindrome.Domain;

namespace Palindrome.Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            var phrase = "racecar";
            Boolean isPalindrome = Class1.testPalindrome(phrase);
            Assert.True(isPalindrome);

            if(isPalindrome) {
                Console.WriteLine($"{phrase} is palindrome");
            } else {
                Console.WriteLine($"{phrase} is not Palindrome");
            }
        }
    }
}
