using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Readfile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                //pass the file path and file name to the streamReader constructor.
                StreamReader sr = new StreamReader("WriteTest.txt");

                String line;
                //read the first line
                line = sr.ReadLine();
                //continue to read until you reach the end of file
                while (line != null)
                {
                    //write the first line to console
                    Console.WriteLine(line);
                    //Readfile the next line
                    line = sr.ReadLine();

                }
                sr.Close();
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:" + e.Message);
            }
            finally
            {
                Console.WriteLine("Now executing the finally block");
                Console.ReadKey();
            }
        }
    }
}
