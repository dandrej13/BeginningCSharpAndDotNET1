using System;
using System.IO;

namespace StreamWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (FileStream aFile = new FileStream("Log.txt.", FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(aFile))
                    {
                        bool truth = true;
                        // Write Data to file.
                        sw.WriteLine("Hello to you");
                        sw.Write($"It is now {DateTime.Now.ToLongDateString()}");
                        sw.Write(" and things are looking good. ");
                        sw.Write("More than that, ");
                        sw.Write($"it's {truth} that C3 is fun");

                    }
                }
            }
            catch(IOException e)
            {
                Console.Write("An IO exception has been thrown!");
                Console.WriteLine(e.ToString());
                Console.ReadLine();
                return;

            }
        }
    }
}
