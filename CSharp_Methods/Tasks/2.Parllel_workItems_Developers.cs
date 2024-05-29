using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace ParllelWorkItems
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

            Console.WriteLine($"Total time Rajesh has taken for completing Javascript Workitem {timeSpan}");//2 secs

        }
        public static void TypescriptWorkItem()
        {
            DateTime startTime = DateTime.Now;  //27-05-2024 10:09;20secs
            //For taking time...
            Thread.Sleep(4000); //2secs i am stopping compiler manually in 2 secs

            DateTime endTime = DateTime.Now;    //27-05-2024 10:11; 20secs

            TimeSpan timeSpan = endTime - startTime;  //2secs

            Console.WriteLine($"Total time Harinath has taken for completing Typescript Workitem {timeSpan}");//2 secs

        }
        public static void HTMLWorkItem()
        {
            DateTime startTime = DateTime.Now;  //27-05-2024 10:09;20secs
            //For taking time...
            Thread.Sleep(3000); //2secs i am stopping compiler manually in 2 secs

            DateTime endTime = DateTime.Now;    //27-05-2024 10:11; 20secs

            TimeSpan timeSpan = endTime - startTime;  //2secs

            Console.WriteLine($"Total time Vinod has taken for completing HTML Workitem {timeSpan}");//2 secs

        }
        public static void CSharpWorkItem()
        {
            DateTime startTime = DateTime.Now;  //27-05-2024 10:09;20secs
            //For taking time...
            Thread.Sleep(5000); //5secs i am stopping compiler manually in 2 secs

            DateTime endTime = DateTime.Now;    //27-05-2024 10:11; 20secs

            TimeSpan timeSpan = endTime - startTime;  //2secs

            Console.WriteLine($"Total time Rajeshwar has taken for completing Csharp Workitem {timeSpan}");//2 secs

        }
    }
    class DeveloperAssignments
    {

        //public static int abc()
        //{
        //    return 1;
        //}
        public static Task AssingedToRajesh()
        {
            return Task.Run(() =>
              {
                  WorkItems.JavascriptWorkItem();
              });
        }
        public static Task AssingedToRajeshwar()
        {
            return Task.Run(() =>
             {
                 WorkItems.CSharpWorkItem();
             });

        }
        public static Task AssingedToVinod()
        {
            return Task.Run(() =>
             {
                 WorkItems.HTMLWorkItem();
             });
        }
        public static Task AssingedToHarinath()
        {
            return Task.Run(() =>
             {
                 WorkItems.TypescriptWorkItem();
             });
        }


    }
    class Program
    {
        //static void Main()
        //{
        //    Task rajeshTask = DeveloperAssignments.AssingedToRajesh();
        //    Task harinathTask = DeveloperAssignments.AssingedToHarinath();
        //    Task rajeswarTask = DeveloperAssignments.AssingedToRajeshwar();
        //    Task vinodTask = DeveloperAssignments.AssingedToVinod();

        //    /**********For based on the Tasks ***********/
        //    DateTime taskStartTime = DateTime.Now;
        //    Console.WriteLine($"Total time of Developers before wait {taskStartTime}");

        //    //Just waiting stage 
        //    Task.WhenAll(rajeshTask, harinathTask, rajeswarTask, vinodTask).Wait();

        //    DateTime taskEnd = DateTime.Now;
        //    TimeSpan timeSpan= taskEnd - taskStartTime;
        //    Console.WriteLine($"All developers taken time is {timeSpan}");

        //    Console.ReadLine();

        //}

       async static void Main()
        {
            Task rajeshTask = DeveloperAssignments.AssingedToRajesh();
            Task harinathTask = DeveloperAssignments.AssingedToHarinath();
            Task rajeswarTask = DeveloperAssignments.AssingedToRajeshwar();
            Task vinodTask = DeveloperAssignments.AssingedToVinod();

            /**********For based on the Tasks ***********/
            DateTime taskStartTime = DateTime.Now;
            Console.WriteLine($"Total time of Developers before wait {taskStartTime}");

            //Just waiting stage 
            //waiting for tasks
            await Task.WhenAll(rajeshTask, harinathTask, rajeswarTask, vinodTask);

            DateTime taskEnd = DateTime.Now;
            TimeSpan timeSpan = taskEnd - taskStartTime;
            Console.WriteLine($"All developers taken time is {timeSpan}");

            Console.ReadLine();

        }
    }

}
