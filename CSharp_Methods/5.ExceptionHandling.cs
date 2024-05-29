using System;


/*
   Exception handling in C# is a crucial aspect of writing robust and reliable code. It allows developers to anticipate and gracefully handle unexpected errors or exceptional conditions that may occur during the execution of a program. Here's an overview of exception handling in C#:

   Types of Exceptions: Exceptions in C# can be of various types, such as System.Exception, System.ArgumentException, System.NullReferenceException, etc. Each exception type represents a specific kind of error that may occur during program execution.

   Try-Catch Blocks: Exception handling in C# is typically done using try-catch blocks. The try block contains the code that may throw an exception, and the catch block handles the exception if one occurs.

  Syntax :
    try
    {
        // Code that may throw an exception
    }
    catch (Exception ex)
    {
        // Handle the exception
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
    finally{
     
    }

 */

/* to handle runtime errors --> try catch finally(optional) 
 * try{
 * 
 * }
 * catch(){}

  Goal : You have to allow compiler to move to the next line....
 */

namespace ExceptionHandlingNameSpace
{
    class Program
    {
        static void FirstMethod()
        {
            
            string location = null;//this values you will receive from UI.
            int locationLength = 0;
            try
            {
                // can i try catch in try block
                locationLength = location.Length;
            }
            catch (NullReferenceException nullexceptoin)
            {
                //try catch in catch
                Console.WriteLine($"Exception occured.Please try again. Exception details {nullexceptoin.Message}");
            }

            Console.WriteLine(locationLength);

        }


        static void SecondMethod()
        {
            string pincode = "560034";//this values you will receive from UI.
            int formatPincode = 0;
            try
            {
                formatPincode = int.Parse(pincode);
            }
            catch (FormatException nullexceptoin)
            {
                Console.WriteLine($"Exception occured.Please try again. Exception details {nullexceptoin.Message}");
            }

            Console.WriteLine(formatPincode);
        }

        static void ThirdMethod()
        {
            int[] numbers = { 10,20,30};//this values you will receive from UI.

            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30; ;
            Console.WriteLine("Please enter the index to find the value");
            int index = 0;
            int result = 0;
            try
            {
                 index = int.Parse(Console.ReadLine()); //0
                 result = numbers[index];
            }
            //catch(IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Index out of range");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("format exception out of range");
            //}
            catch(Exception ex)
            {
                Console.WriteLine ("Fault is our side. we are doing the work");
            }
            finally
            {
                Console.WriteLine("Completed the program.Thanks for login.....");
            }
            Console.WriteLine($"Got it !!!!! your index is {index} and its value is {result}");



        }

        static void Main()
        {
            //FirstMethod();
            //SecondMethod();
            ThirdMethod();
            Console.ReadLine();
        }
    }
}
