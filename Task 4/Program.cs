using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.TTC8840
{
    public class Palindrome
    {
        public static bool Check(string input)
        {
            input = input.Replace(" ", string.Empty);
            char[] list1 = input.ToCharArray();
            char[] list2 = input.ToCharArray();
            Array.Reverse(list2);
            string word = new string(list1);
            string reverse = new string(list2);
            Console.WriteLine(reverse);
            Console.WriteLine(word);
            if (reverse == word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            string input = Console.ReadLine();
            if (Palindrome.Check(input) == true)
            {
                Console.WriteLine("This string is a Palindrome.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("This string is not a Palindrome.");
                Console.ReadKey();
            }
        }
    }
}
