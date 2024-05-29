using System;
using System.Data.Common;

class MethodsParameters
{

    //in * out , ref
    static void Main()
    {
        //These values expect from UI
        PrintInfo("Raju", 10);

        //Assign the value based on parameter name
        PrintInfo1( age:25, location:"Hyderabad" , name:"Raju");

        //In ui i am passing only one parameterm,
        // Firstname : Textbox
        // giving Raju value
        PrintInfo2("Rajesh");
        PrintInfo2("John"  , 20);

        PrintInfo3();

        PrintInfo4("john", 20, 1, 678, 20000);

    }


    /// <summary>
    ///  Print Customer Information
    /// </summary>
    /// <param name="name">Customer name</param>
    /// <param name="age">Customer age</param>
    static void PrintInfo(string name, int age)
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
    }


    static void PrintInfo1(string name, int age , string location)
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
    }


    static void PrintInfo2(string name, int age = 0)
    {
        Console.WriteLine(age); //20
    }


    //My design
    static void PrintInfo3(string name = "Not available", int age = 0)
    {
        Console.WriteLine(name); // here if name is their then name will be print . incase not then "Not availble" print
        Console.WriteLine(age); //20
    }


    //static void PrintInfo4(string name , int age , int id , int locationid , int salary)
    //{
    //    Console.WriteLine(name); // here if name is their then name will be print . incase not then "Not availble" print
    //    Console.WriteLine(age); //20
    //}

    //PrintInfo4("john", 20, 1, 678, 20000, 10 , 70, 30,45,676,654);
    
    static void PrintInfo4(string name, params int[] values)
    {                        //{20, 1, 678, 20000}
        foreach (int value in values)
        { 
            Console.WriteLine(value); //20 
        }
       // Console.WriteLine(name); // here if name is their then name will be print . incase not then "Not availble" print
        //Console.WriteLine(age); //20
    }




}

