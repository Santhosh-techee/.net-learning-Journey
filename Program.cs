using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program to reverse a string using for loop.
            String s = "Softwaredeveloper";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(s[i]);
            }

            // Write a C# program to check whether a string is palindrome or not.
            string Name = "mayalam";
            string rev = "";

            for (int i = Name.Length - 1; i >= 0; i--)
            {
                rev += Name[i];
            }
            if (Name == rev)
            {
                Console.WriteLine("The string is palindrome:" + Name);
            }
            else
            {
                Console.WriteLine("The string is not palindrome:" + Name);
            }

            // Write a C# program to reverse the words in a given string.
            string str = "I am a Software developer";
            string[] words = str.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
            //write a C# program to reverse each word in a given string.
            string DEPt = "BE Computer Science and Engineering";
            string[] CLG = DEPt.Split(' ');

            foreach (string w in CLG)
            {

                for (int i = w.Length - 1; i >= 0; i--)
                {
                    Console.Write(w[i]);
                }

                Console.Write(" ");
            }
            //write a C# program to count the number of occurrences of each character in a string.
            string stack = "DOTNET";

            for (int i = 0; i < stack.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < stack.Length; j++)
                {
                    if (stack[i] == stack[j])
                    {
                        count++;
                    }
                }

                Console.WriteLine(stack[i] + " = " + count);
            }

            //write a C# program to remove duplicate characters from a string.
            string lang = "programming";
            string result = "";

            foreach (char ch in lang)
            {
                if (!result.Contains(ch))
                {
                    result = result + ch;
                }
            }

            Console.WriteLine(result);
            //write a C# program to print all the substrings of a given string.
            string don = "Santhosh";

            for (int i = 0; i < don.Length; i++)
            {
                for (int j = i; j < don.Length; j++)
                {
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write(don[k]);
                    }

                    Console.WriteLine();
                }
            }







        }
    }
}
