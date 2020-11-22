using System;
using System.IO;
namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveDesiredFileToFruitFolder();
            MoveDesiredFileToVegetablesFolder();
            DeletesFilesFromFruitAndVegetablesFolder();
        }
        public static void MoveDesiredFileToFruitFolder()
        {
            Console.WriteLine("What file do you wish to move to fruit folder?");
            string userInput = Console.ReadLine();
            string sourceDirectory = @"C:\Users\mammu\samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationPath = @"C:\Users\mammu\samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            File.Move(Path.Combine(sourceDirectory, userInput), Path.Combine(destinationPath, userInput));
            if (File.Exists(Path.Combine(sourceDirectory, destinationPath)))
            { 
                
                Console.WriteLine("File moved.");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
        public static void MoveDesiredFileToVegetablesFolder()
        {
            Console.WriteLine("What file do you wish to move to vegetable folder?");
            string userInput = Console.ReadLine();
            string sourceDirectory = @"C:\Users\mammu\samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationPath = @"C:\Users\mammu\samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";
            File.Move(Path.Combine(sourceDirectory, userInput), Path.Combine(destinationPath, userInput));
            if (File.Exists(Path.Combine(sourceDirectory, destinationPath)))
            {               
                Console.WriteLine("File moved.");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
        public static void DeletesFilesFromFruitAndVegetablesFolder()
        {
            string rootpath1 = @"C:\Users\mammu\samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            string rootpath2 = @"C:\Users\mammu\samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";
            string fileName1 = "toiletPaper.txt";
            string fileName2 = "cheeses.txt";
            if (File.Exists(Path.Combine(rootpath1, fileName1)))
            {
                File.Delete(Path.Combine(rootpath1, fileName1));
                Console.WriteLine("File deleted.");
            }
            else
            {
                Console.WriteLine("File not found");
            }
            if (File.Exists(Path.Combine(rootpath2, fileName2)))
            {
                File.Delete(Path.Combine(rootpath2, fileName2));
                Console.WriteLine("File deleted.");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
       
    }
}