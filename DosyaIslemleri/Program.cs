using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaIslemleri
{
    class Program
    {
        public static void WriteFile()
        {
            string path = @"C:\Users\Hp\source\repos\DosyaIslemleri\example.txt";
            FileInfo fi = new FileInfo(path);
            Console.WriteLine(fi.FullName);
        }

        public static void ReadFile() 
        {
            string path = @"C:\Users\Hp\source\repos\DosyaIslemleri\example.txt";
            Console.WriteLine(File.GetLastWriteTime(path)+"11111");
        }
        static void Main(string[] args)
        {
            WriteFile();
            ReadFile();
            Console.ReadKey();
        }
    }
}
