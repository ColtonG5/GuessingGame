using System;

namespace ConsoleApplication1
{
    class Program
    {
        public static stringUtility.StringLibrary clsString = new stringUtility.StringLibrary ();

        static void Main(string[] args)
        {
            MainFunc();
        }

        static void MainFunc() {

            Console.WriteLine("Type a string");
            string userInput = Console.ReadLine();

            Operation(userInput);

            AskToExit();

        }

        static void Operation(string u) {

            Console.WriteLine("What do you want to check? (1 for palindrome, 2 for uppercase)");
            
            string s = Console.ReadLine();
            
            switch (s) {
                
                case "1":

                    if (clsString.IsStringPalindrome(u)) {
                        Console.WriteLine("The string is a Palindrome");
                    } else {
                        Console.WriteLine("The string is not a Palindrome");
                    }
                    break;

                case "2":

                    if (clsString.StartsWithUpper(u)) {
                        Console.WriteLine("The string starts with an uppercase");
                    } else {
                        Console.WriteLine("The string does not start with an uppercase");
                    }
                    break;

            }
        }

        static void AskToExit() {

            Console.WriteLine("Would you like to start again or exit? (1 to start over, 2 to exit)");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x == 1) {

                MainFunc();

            } else {

                Environment.Exit(0);

            }
        }
    }
}
