using System;

/*Extension Method
 * ------------------
 * An extension method in C# is a feature that allows you to add new methods to existing types (classes, interfaces, or  delegate types) without modifying the original source code of the type. It enables you to extend the functionality of types from external libraries or system types.
 * 

/*
 *  My own method under the string|int|Array|bool
 *  
 *  
 *   string str = "Hello worlZ ";
       // Method
        //Extension method static class
        // 2
        //str.
        //    false                //"100f"    0
        //bool output = int.TryParse(input, out number);
 *  
 */

namespace ExtensionMethodsNamespace
{
    // static     class       -->  every member should be static  
    // non-static class       -->  every member can be static or nonstatic
    static class StringExtensions
    {                                           //hello world
        public static int WordCount(this string input)
        {
            //split based on the space
            string[] words = input.Split(' ');
            int wordCount = words.Length;
            //What you want to do
            return wordCount;
        }
    }


    public class Program
    {
        static void Main()
        {
            string sentence = "Hello world";
            sentence.WordCount(); //created by me  //2
            int result1 = sentence.WordCount(); //5


            string anothersentence = "Hello, extension methods are powerful!";
            //int length = anothersentence.Length;
            //anothersentence.ToUpper();
            //anothersentence.ToLower();
            //anothersentence.Substring(0, 5);


           int result2 =  anothersentence.WordCount(); //5

            Console.ReadLine();


        }
    }



}
