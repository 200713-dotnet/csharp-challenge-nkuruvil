using System;


namespace Palindrome.Domain
{
    public class Class1
    {

        static void Main()
        {
           Console.WriteLine("Welcome to Palindrome Checker. Enter word or phrase.");
            var phrase = System.Console.ReadLine();
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
        }



    }
}
