using System;
using System.IO;

namespace CreateTITpe
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            Console.WriteLine("enter directory name");
            string userFolder = Console.ReadLine();

            string NewDirectoryFullPath = @$"{rootDirectory}\{userFolder}";

            bool directoryExists = Directory.Exists(NewDirectoryFullPath);

            if (directoryExists)
            {
                Console.WriteLine($"{userFolder} exists");
                Console.WriteLine("Would you like to create a folder? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());


                if (userInput == 'Y')
                {
                    Console.WriteLine("Enter file name:");
                    string UserFile = Console.ReadLine() + ".txt";
                    string UserFileFullPath = $@"{NewDirectoryFullPath}\{UserFile}";
                    File.Create(UserFileFullPath);
                }


                else
                {
                    Console.WriteLine("Cheers");
                }


            }
            else
            {
                Directory.CreateDirectory(NewDirectoryFullPath);
                Console.WriteLine($"Directory {userFolder} has been created");
            }

        }
    }
}
