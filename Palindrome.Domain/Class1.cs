using System;


namespace Palindrome.Domain
{
    public class Class1
    {

        public static Boolean testPalindrome(string phrase)
        {
            int phraseLength = phrase.Length;
            Boolean isPalindrome = true;

            for(int i=0; i<phraseLength/2; i++){
                if(phrase[i] != phrase[phraseLength-i-1]){
                    isPalindrome = false;
                    break;
                }
            }

            if(isPalindrome) {
                Console.WriteLine($"{phrase} is palindrome");
            } else {
                Console.WriteLine($"{phrase} is not Palindrome");
            }

            return isPalindrome;
        }



    }
}
