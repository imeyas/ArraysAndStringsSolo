using System;

namespace ArraysAndStringsSolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Multidimensional array declaration and initialization
            Console.WriteLine($"Here's an example of a multidimensional array:\n");
            int[ , ] dimensionalArray = { { 2, 3, 4 }, { 4, 5, 5 }, { 6, 7, 4 }, { 8, 9, 6 } };

            for (int k = 0; k < 4; k++)
                {
                    for (int j = 0; j < 2; j++)
                        {
                        Console.Write(dimensionalArray[k, j] + " ");
                        }

                    Console.WriteLine();
                }




            //Jagged array or an array-of-arrays declartion and initialization
            int[][] jaggedArray = new int[][]
            {
                new int[] {17, 45, 55, 35, 77},
                new int[] {3, 5, 7, 8, 9},
                new int[] {17, 19, 27, 47},
            };

            int q = jaggedArray[2][1]; // verifed value of 19 using breakpoint debug

            Console.WriteLine($"\n------------------------------------------------------------------------\n");


            //Utilizing the different methods available to an array and printing the respective value on the screen
            Console.WriteLine($"\nJagged array rank is: {jaggedArray.Rank}");
            Console.WriteLine($"\nJagged array length is: {jaggedArray.Length}");

            Console.WriteLine($"\n------------------------------------------------------------------------\n");

            int[] arrayMethods = { 3, 4, 7, 17, 45, 35 };

            Console.WriteLine($"\nThis arrays length is: {arrayMethods.Length}");
            Console.WriteLine($"\nThis arrays rank is: {arrayMethods.Rank}");
            Console.WriteLine($"\nThis arrays maximum value is: {arrayMethods.Max()}");
            Console.WriteLine($"\nThis arrays minimum value is: {arrayMethods.Min()}");
            Console.WriteLine($"\nThe sum (value of all the numbers added together) of this array is: {arrayMethods.Sum()}");

            Console.WriteLine($"\n------------------------------------------------------------------------\n");

            //Working with Strings as objects in C Sharp

            string thisString = "\nAmericans FIRST to Make America Great Again :-)!!!";

            //Getting the length of a string
            Console.WriteLine($"\nThe length of this string is: {thisString.Length}");

            Console.WriteLine($"\n------------------------------------------------------------------------\n");

            //Getting the index of a specified word (could be a character) in a string
            Console.WriteLine($"\nThe index of the word 'Great' is: {thisString.IndexOf("Great")}");

            Console.WriteLine($"\n------------------------------------------------------------------------\n");

            //Replace specified words (could be a character) in a string
            thisString = thisString.Replace("Americans FIRST", "Make America Great Again");
            Console.WriteLine($"\nThis is an example of replacement in string: {thisString}");

            Console.WriteLine($"\n------------------------------------------------------------------------\n");

            //Checking to see if this string contains a word (could be a character) and printing the result on screen
            if (thisString.Contains("Make America"))
            {
                Console.WriteLine("\nFound Make America sitting right next to Great Again :-p");
            }

            Console.WriteLine($"\n------------------------------------------------------------------------\n");

            //Removing a specified word (could be a character) from a string
            thisString = thisString.Remove(5);
            Console.WriteLine($"\nThis has been removed from the string: {thisString}");

            Console.WriteLine($"\n------------------------------------------------------------------------\n");

            //Getting the substring of a specified word (could be a character) from a string
            thisString = thisString.Substring(1);
            Console.WriteLine($"\nThis value was acquired using the Substring member/method: {thisString}");

            Console.WriteLine($"\n------------------------------------------------------------------------\n");

            //Accessing characters of a string using its index like accessing the elements of an array
            string americaFirst = "Americans first";
            Console.WriteLine($"\nThis value was accessed using indexing like we do with an array: {americaFirst[2]}");

            Console.WriteLine($"\n------------------------------------------------------------------------\n");

            //A program to take a string and replace all occurence of the word "dog with "cat" and output the first sentence only
            string petText = "\nThis is a paragraph about a dog. The word dog appears in this paragraph a number of times. This is the end.";
            petText = petText.Replace("dog", "cat");
            petText = petText.Substring(0, petText.IndexOf(".") + 1);
            Console.WriteLine($"\nREPLACE DOG TO CAT AND PRINT FIRST SENTENCE ONLY PROGRAM:");
            Console.WriteLine($"{petText}");

            Console.WriteLine($"\n------------------------------------------------------------------------\n");

            //Working with strings and modulus operator to find an integer value
            string s = "SoloLearn";
            int x = s.Length;
            int y = s.IndexOf("e");
            Console.Write($"\nString 'Sololearn' Length(9) modulus(%) IndexOf 'e'(5) = {x % y}\n");
        }
    }
}