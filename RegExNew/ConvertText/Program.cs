using System;
using System.IO;
using System.Text;

namespace ConvertText
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\User\Documents\tempDir\temp2\myfile.txt");
            StreamWriter sw = new StreamWriter("myfile-utf7.txt", false, Encoding.UTF7);
            sw.WriteLine(sr.ReadToEnd()); 
            sw.Close();
            sr.Close();
        }
    }
}
