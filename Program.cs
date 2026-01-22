using System;
using System.IO;
namespace A_2_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup the File Path
           
            string folderPath = @"C:\MSSA_CAD\Files";
            Console.WriteLine("Enter the File Name:");
            string fileName = Console.ReadLine() + ".txt";
            string filePath = Path.Combine(folderPath, fileName);
            Console.WriteLine($"Setup the path for the file -> {filePath}\n");

            List<Person> personList = new List<Person>();
            personList.Add(new Person("JJ Watts", 36, "123 Texans Rd, Houston TX 98765"));
            personList.Add(new Person("James Harden", 38, "111 LA Rd, Los Angeles CA 45678"));
            personList.Add(new Person("Jon Jones", 40, "999 Garden Dr, Santa Fe NM 65432"));

           
            // Writting to the File
            try
            {
               
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("********** List of People **********\n");
                    foreach (var person in personList)
                    {
                        writer.WriteLine($"Name:{person.Name}");
                        writer.WriteLine($"Age:{person.Age}");
                        writer.WriteLine($"Address:{person.Address}");
                        writer.WriteLine("*************************************************");
                    }

                }
                Console.WriteLine($"Details saved successfully to: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"File Processing Error: {ex.Message}");
            }

            Console.WriteLine("\n********** Reading the Content Back **********\n");

            // Reading the File
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string? line;
                        
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("File not found!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }

        }

    }
}
