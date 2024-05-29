using System;

// in  , ref and out

class MethodsParameterTypes
{
    static void Main()
    {
        int number1 = 0;
        bool status1 = false;
        string eName1 = null;

        //Printinfo(number1 ,  status1 , eName1);
        //Console.WriteLine($"Number {number1} , status : {status1} , ename :{eName1}");
        //                                0                     false              null

        RefPrintinfo(ref number1 , ref status1 , ref eName1);
        Console.WriteLine($"Number {number1} , status : {status1} , ename :{eName1}");


        int number2;
        bool status2;
        string eName2;

        //int id;
        //Console.WriteLine(id);  // 0

        OutPrintinfo(out number2, out status2, out eName2);
        Console.WriteLine($"Number {number2} , status : {status2} , ename :{eName2}");


        //input , Ref and out Example
        int number = 0; //ref atlease one value you have to assign
        bool IsSuccess;

        //TryParseInt( "100" , ref number, out IsSuccess);
        TryParseInt("Raju", ref number, out IsSuccess);
        Console.WriteLine($"number : {number} , IsSuccess :{IsSuccess}");
        
        Console.ReadLine();

    }

    static void Printinfo(int Id , bool status , string eName)
    {

        Id = 1;
        status = true;
        eName = "John";
        /// Implementaion..
    }

    static void RefPrintinfo(ref int Id, ref bool status, ref string eName)
    {
        Id = 1;
        status = true;
        eName = "John";
        /// Implementaion..
    }

    static void OutPrintinfo(out int Id, out bool status, out string eName)
    {
        Id = 101;
        status = true;
        eName = "Robert";
        /// Implementaion..
    }

    //                             //"100"
    static void TryParseInt(string input , ref int number  , out bool Issuccess )
    {
        //try parse "100" --> 100 -- true
        //"Hello 100 take" -->  --false

        //     true                      //"100"    100
        bool output = int.TryParse(input, out number);

        if (output)
        {
            Issuccess  = true;
        }
        else
        {
            number = 0;
            Issuccess = false;
        }


       

    }

}
