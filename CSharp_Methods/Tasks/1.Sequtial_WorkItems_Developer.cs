using System;
using System.Threading;


namespace SequentailWorkItemDevelopers
{
    class WorkItems
    {
        //For completing javascript item it will take some time..
        public static void JavascriptWorkItem()
        {
            DateTime startTime = DateTime.Now;  //27-05-2024 10:09;20secs
            //For taking time...
            Thread.Sleep(2000); //2secs i am stopping compiler manually in 2 secs

            DateTime endTime = DateTime.Now;    //27-05-2024 10:11; 20secs

            TimeSpan timeSpan = endTime - startTime;  //2secs
            
            Console.WriteLine($"Total time has taken for completing Javascript Workitem {timeSpan}");//2 secs
            
        }
        public static void TypescriptWorkItem()
        {
            DateTime startTime = DateTime.Now;  //27-05-2024 10:09;20secs
            //For taking time...
            Thread.Sleep(4000); //2secs i am stopping compiler manually in 2 secs

            DateTime endTime = DateTime.Now;    //27-05-2024 10:11; 20secs

            TimeSpan timeSpan = endTime - startTime;  //2secs

            Console.WriteLine($"Total time has taken for completing Typescript Workitem {timeSpan}");//2 secs

        }
        public static void HTMLWorkItem()
        {
            DateTime startTime = DateTime.Now;  //27-05-2024 10:09;20secs
            //For taking time...
            Thread.Sleep(3000); //2secs i am stopping compiler manually in 2 secs

            DateTime endTime = DateTime.Now;    //27-05-2024 10:11; 20secs

            TimeSpan timeSpan = endTime - startTime;  //2secs

            Console.WriteLine($"Total time has taken for completing HTML Workitem {timeSpan}");//2 secs

        }
        public static void CSharpWorkItem()
        {
            DateTime startTime = DateTime.Now;  //27-05-2024 10:09;20secs
            //For taking time...
            Thread.Sleep(5000); //5secs i am stopping compiler manually in 2 secs

            DateTime endTime = DateTime.Now;    //27-05-2024 10:11; 20secs

            TimeSpan timeSpan = endTime - startTime;  //2secs

            Console.WriteLine($"Total time has taken for completing Csharp Workitem {timeSpan}");//2 secs

        }
    }

    class DeveloperAssignments
    {
        public static void AssingedToMadan()
        {
            Console.WriteLine("Sequential Work:");

            DateTime startTime = DateTime.Now;

            WorkItems.JavascriptWorkItem();
            WorkItems.HTMLWorkItem();
            WorkItems.TypescriptWorkItem();
            WorkItems.CSharpWorkItem();

            DateTime endTime = DateTime.Now;
            TimeSpan timeSpan = endTime - startTime;
            Console.WriteLine($"Sequentail Work has completed. And total time is {timeSpan} ");
        }


    }


    class Program
    {
        static void Main()
        {
            DeveloperAssignments.AssingedToMadan();

            Console.ReadLine();
        }
    }

}
