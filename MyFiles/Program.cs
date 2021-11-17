using System;
using System.IO;

namespace MyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullfilepath = @"C:\Users\opilane\samples\TITpe21";
            string filepath = fullfilepath + @"\MyFiles.txt";
            string[] dataFromFile = File.ReadAllLines(filepath);



            for (int i = 0; i < dataFromFile.Length; i++)
            {
                dataFromFile[i] = dataFromFile[i].Replace('4', 'a');
                dataFromFile[i] = dataFromFile[i].Replace('3', 'e');
                dataFromFile[i] = dataFromFile[i].Replace('0', 'o');
                dataFromFile[i] = dataFromFile[i].Replace('1', 'i');

                File.WriteAllLines(filepath, dataFromFile);
            }
          
            foreach (string line in dataFromFile)
            {
                File.Create($@"{fullfilepath}\{line}.txt");

            }


        }
    }
}
