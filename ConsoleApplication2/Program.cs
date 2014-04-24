using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using ConsoleApplication2;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\charl_000\Downloads\Test_534c59466ca7204619000005._qrda\0_Mathew_Alvarado.xml";
            QRDAParser obj = new QRDAParser();

            if (File.Exists(path))
            {
                //Open the file and read it into a string
                string message = File.ReadAllText(path);
                obj.ReadXML(message);

                
            }
            else
            {
                Console.WriteLine("Couldn't open file: " + path);
            }

            var name = Console.ReadLine();


        }
    }
}
