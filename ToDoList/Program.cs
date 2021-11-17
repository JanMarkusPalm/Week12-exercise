using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            //prepare a list to save data from file
            List<string> ToDo = new List<string>();
            string ToDoFilePath = @"C:\Users\opilane\samples\TITpe21\ToDoList.txt";
            ToDo = File.ReadAllLines(ToDoFilePath).ToList();

            foreach(string task in ToDo)
            {
                Console.WriteLine(task);
            }

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add a task? Y/N");
                char userinput = Convert.ToChar(Console.ReadLine().ToLower());
            
            if (userinput == 'y')
                {
                    Console.WriteLine("enter a task");
                    string usertask = Console.ReadLine();
                    ToDo.Add(usertask);
                    Console.WriteLine($"task {usertask} has been added successfully!");
                }
                else
                {
                    Console.WriteLine("seeya");
                    loopActive = false;
                }
            }
            File.WriteAllLines(ToDoFilePath, ToDo.ToArray());
        }
    }
}
