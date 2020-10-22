using System;
using System.Collections.Generic;

using System.IO;

namespace InterfaceIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Path for Windows
            //string pathHardCode = @"C:\Users\apagar\Projects\InterfaceIComparable\employees.csv";

            //Path for macOS
            string pathHardCode = "/Users/nxgames/Projects/interfaceicomparable";

            string fileSource = "employees.csv";

            string pathSourceFile = pathHardCode + Path.DirectorySeparatorChar + fileSource;

            try
            {
                using (StreamReader sr = File.OpenText(pathSourceFile))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee (sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}