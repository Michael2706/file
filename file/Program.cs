using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream stream = File.Open(@"C:\temp\testfile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            Console.ReadKey();

        }
    }
}
