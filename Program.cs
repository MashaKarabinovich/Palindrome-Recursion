using System;

namespace palindromeRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
              string userInput;
            Console.WriteLine("Please enter a word: ");
            userInput = Console.ReadLine();
            Console.WriteLine(palindrome(userInput));
            Console.ReadLine();

        }

        public static bool palindrome(string word)
        {

            if (word.Length <= 1)
            {
                return true;
            }

            if (word[0] != word[word.Length - 1])
            {
                return false;
            }
            return palindrome(word.Substring(1, word.Length - 2));

        }
        }
    }
}
