using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string:"); // prompt user to enter a word
            string input = Console.ReadLine();//s used to read a line of text from the console input and store it as a string.

            Console.WriteLine("Chose an operation:");//is used to display a message to the console.
            Console.WriteLine("1.Reverse string");//It's a prompt or option, indicating to the user that they can choose option 1 to reverse a string.
            Console.WriteLine("2.Count vowles"); //It's a prompt or option, indicating to the user that they can choose option 2 to reverse a string.
            Console.WriteLine("3.Check if palidrome");//It's a prompt or option, indicating to the user that they can choose option 3 to reverse a string.

            int choice = int.Parse(Console.ReadLine());//is used to get user input as a string and convert it to an integer.

            switch (choice)
            {
                case 1:
                    string reversedString = ReverseString(input);//is used to call a method named ReverseString and assign the returned value to the reversedString variable.
                    Console.WriteLine("Reversed string: " + reversedString);//It combines the string "Reversed string: " with the value of the reversedString variable. The + operator is used for string concatenation
                    break;//statement is used to exit the switch statement after the conversion is performed.
                case 2:
                    int vowelCount = CountVowels(input);//is used to call a method named CountVowels and assign the returned value to the vowelCount variable.
                    Console.WriteLine("Number of vowels: " + vowelCount);//is used to display the number of vowels found in the input string to the console.
                    break;//statement is used to exit the switch statement after the conversion is performed.
                case 3:
                    bool isPalindrome = IsPalindrome(input);//used to call a method named IsPalindrome and assign the returned value to the isPalindrome variable.
                    Console.WriteLine("Is palidrome: " + isPalindrome);//is used to display whether the input string is a palindrome or not to the console.
                    break;//statement is used to exit the switch statement after the conversion is performed.
            }
            static string ReverseString(string input)//you can call the method directly on the class name without creating an object
            {
                char[] charArray = input.ToCharArray();//converts a string to a character array.
                Array.Reverse(charArray);// reverses the order of the elements in the charArray array.
                return new string(charArray);//creates a new string from a character array and returns it.
            }
            static int CountVowels(string input)//you can call the method directly on the class name without creating an object.
            {
                int count = 0; //declares and initializes an integer variable named count.
                foreach (char c in input)//is a foreach loop in C# that iterates over each character in the input string.
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')// is used to check if a character is a vowel
                    {
                        count++;//is used to increment the value of the count variable by 1.
                    }
                }
                return count;//is used to return the value of the count variable from the method.
            }
            static bool IsPalindrome(string input)//you can call the method directly on the class name without creating an object.
            {
                int left = 0;//declares and initializes an integer variable named left.
                int right = input.Length - 1;// declares and initializes an integer variable named right.

                while (left < right)//is used to create a loop that continues to execute as long as the value of the left variable is less than the value of the right variable.
                {
                    if (input[left] != input[right])//is used to check if two characters in a string are not equal.
                    {
                        return false;//is used to return the value false from the method.
                    }
                    left++;//  is used to increment the value of the left variable by 1.
                    right--;//is used to decrement the value of the right variable by 1.
                }
                return true;//is used to return the value true from the method.
            }
        }
    }
}

