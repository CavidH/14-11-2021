using System;
using System.IO;

namespace _14_11_2021
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string DefaultPath = @"C:\Users\cavid\Desktop\code";
            string CopyPath = DefaultPath + "Copy";
            CopyDirWithContent(new DirectoryInfo(DefaultPath), new DirectoryInfo(CopyPath));



        }
        public static void CopyDirWithContent(DirectoryInfo DefaultPath, DirectoryInfo CopyPath)
        {



            Console.WriteLine(CopyPath.FullName + " basha qayitdi");
            Directory.CreateDirectory(CopyPath.FullName);

            // yaratdiqmiz dir de olan fayli copy edirik
            foreach (FileInfo file in DefaultPath.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", CopyPath.FullName, file.Name);
                file.CopyTo(Path.Combine(CopyPath.FullName, file.Name), true);
            }

          
            foreach (DirectoryInfo DefaultPathDir in DefaultPath.GetDirectories())
            {
                DirectoryInfo SubDirector =
                    CopyPath.CreateSubdirectory(DefaultPathDir.Name);
                CopyDirWithContent(DefaultPathDir, SubDirector);
            }
        }
    }
}
