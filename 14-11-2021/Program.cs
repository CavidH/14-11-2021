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

        private static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }

    }
}
 
