using HashSetExample.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace HashSetExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\in.txt";

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);

                        set.Add(new LogRecord { User =  name, Instant = instant });
                    }

                    Console.WriteLine($"Total Users: {set.Count} ");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
