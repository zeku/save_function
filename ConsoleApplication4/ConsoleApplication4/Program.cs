using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
     class Program
    {
        StreamWriter writer; // Create a stream writer
        StreamReader reader; // Create a stream reader

         static void Main()
         {
             Console.WriteLine("Type the file");
             new Program (Console.ReadLine()); // Read in
         }

        public Program (String inFileName)
        {
            Save(inFileName);
        }
       
        public void Save(String inString)
        {
            string word;// string variable to hold text 

            openFile(inString); // Calling function 

            Console.WriteLine("Type the text you want");
            word = Console.ReadLine();

            // Writting into the file
            writer.WriteLine(DateTime.Now);
            writer.WriteLine(word);
            writer.WriteLine();

            writer.Close(); // Close the stream
        }
        private void openFile(String file)
        {
            if (!File.Exists(file)) // check if the file exist
            { 
                Console.WriteLine("The file does not exist. You want to creat new?Y/N");

                if (Console.ReadLine() == "Y")
                {
                    writer = new StreamWriter(file); //creat the file 
                } 
            }
            else
            {
                Console.WriteLine("The file you typed exist");
                reader = new StreamReader(file); //read a file 
                Console.WriteLine(reader.ReadToEnd()); //open a file 
                reader.Close();
                writer = File.AppendText(file); // append the text into the file
                Console.WriteLine("\n");
            }
        }
    }
}



