using System;
using System.IO;

namespace FileReadingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //read file
            string fullPath = @"C:\Test\Help\PFRO.log";
            StreamReader sr = new StreamReader(new FileStream(fullPath, FileMode.Open));

            while(sr.EndOfStream == false)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();//open -> close 필수!


            //write file
            string writePath = @"C:\Test\Help\Ksy.txt";
            StreamWriter sw = new StreamWriter(new FileStream(writePath, FileMode.Create));

            sw.Write("Hello World!\n");
            sw.Write("안녕하세요 ");
            sw.Write(3.141592);

            sw.Close();//필수

            Console.WriteLine("File Read/Write finished");
        }
    }
}
