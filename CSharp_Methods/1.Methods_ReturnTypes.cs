using System;


class Methods_ReturnTypes
{
    /* Method return types ********************************/
    /* Method return types are Two 
        * 1. void
        * 2. Non-void
        */
    static void Main()
    {
        PrintMessage();
        //string message1 = "Message1";

        string message1 = GetMessage();

        PrintCalculateAddition();

        int total = GetCalculateAddition();

        /*Home work for calling rest methods*/
    }

    static void PrintMessage()
    {
        Console.WriteLine("Print Message");
    }

    static string GetMessage()
    {
        return "Message1";
    }

    //No inputs
    static void PrintCalculateAddition()
    {
        int a = 10;
        int b = 20;
        Console.WriteLine("Addition is a and b is. I.e. ", a + b);
    }

    static int GetCalculateAddition()
    {
        int a = 10;
        int b = 20;
        return a + b; //30
    }

    static int[] GetNumbersList()
    {
        int[] result = { 1, 2, 3, 4 };

        return result;

        //return new int[] { 1, 2, 3, 4 };
    }

    static bool ReturnStatus()
    {
        int a = 10;
        if (a == 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }



}

