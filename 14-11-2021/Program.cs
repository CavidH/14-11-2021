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
            // CopyFilesRecursively(DefaultPath, CopyPath);
            CopyPath(new DirectoryInfo(DefaultPath), new DirectoryInfo(CopyPath));



        }

        public static void CopyDirWithContent(DirectoryInfo DefaultPath,DirectoryInfo CopyPath)
        {
            
        }

        

    }
}
 
