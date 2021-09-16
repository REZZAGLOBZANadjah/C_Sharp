
    using System;
    using System.IO;
/*
    namespace ConsoleAppFileIOA
    {

        class Program
        {

            static void Main(string[] args)
            {
                FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate,
                   FileAccess.ReadWrite);

                for (int i = 1; i <= 20; i++)
                {
                    F.WriteByte((byte)i);
                }

                F.Position = 0;
                for (int i = 0; i <= 20; i++)
                {
                    Console.Write(F.ReadByte() + " ");
                }
                F.Close();
                Console.ReadKey();
            }
        }
    }
//-------------------------------------------
*/
namespace FileApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("F:/jamaica.txt"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
