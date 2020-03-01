using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        public enum Weekdays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {            //Create a list to hold tasdks
            List<string> tasklist = new List<string>();

            //for each value in the Enum...let the user create a task.
            foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            {
                Console.WriteLine("Enter a new task" + day);
                string task = day + ":" + Console.ReadLine();
                tasklist.Add(task);
            }
            //print all of the task.
            foreach (string task in tasklist)
            {





                Console.WriteLine("Hello World!");
            }
        }
    }
}