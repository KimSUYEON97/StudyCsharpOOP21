using System;
using System.IO;

namespace FileDirectoryTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string path = @"C:\Windows";// \ 를 인식하기 위해서 1. \\로 바꾸기 or 2. @"dir path" : verbatim string 형태!
            var dirs = Directory.GetDirectories(path);//string array형식

            foreach (var item in dirs)
            {
                Console.WriteLine(item);
                var dirInfo = new DirectoryInfo(item);
                Console.WriteLine($"{dirInfo.Name} / {dirInfo.Attributes} / {dirInfo.CreationTime}");
            }
            Console.WriteLine();

            var files = Directory.GetFiles(path);
            foreach (var item in files)
            {
                Console.WriteLine(item);
                var fileInfo = new FileInfo(item);
                Console.WriteLine($"{fileInfo.Name} / {fileInfo.Attributes} / {fileInfo.CreationTime} / {fileInfo.Length} ");//length == size
            }*/

            string newPath = @"C:\Test\Help";//dir,파일 생성할 위치
            int dirNum = 0;//dir 이름에 1씩 증가 시켜 중복 dir생성 방지

            while (true)
            {
                Console.WriteLine("enter file / dir , end program enter X");

                var input = Console.ReadLine();

                if (input == "X")
                {
                    break;
                }
                else
                {
                    //Console.WriteLine("...ing...");
                    //파일/폴더 만드는 로직 생성
                    if (input == "file")
                    {
                        var fileName = $"Samplefile_{DateTime.Now.ToString("yyMMdd.hhmmss")}.txt";
                        var fullPath = $@"{newPath}\{fileName}";//C:\Test\Help\Samplefile

                        File.Create(fullPath);
                    }
                    else if(input == "dir")
                    {
                        var dirName = "SampleDir";
                        var fullPath = @$"{newPath}\{dirName}";//C:\Test\Help\SampleDir

                        if (!Directory.Exists(fullPath))
                        {
                            Directory.CreateDirectory(fullPath);
                        }
                        else
                        {
                            dirNum++;
                            fullPath = @$"{newPath}\{dirName}{dirNum}";
                            Directory.CreateDirectory(fullPath);
                        }
                    }
                    else
                    {
                        Console.WriteLine("need to be entered by file/dir");
                    }
                }
            }

            Console.WriteLine("Program ended");
        }
    }
}
