using System;
using System.IO.Compression;

namespace _6._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:\ZipFileDemo", @"C:\ZipFileDemoOutput/MyZipFile.zip");
            ZipFile.ExtractToDirectory(@"C:\ZipFileDemoOutput/MyZipFile.zip", @"C:\ZipFileResult");

            
        }
    }
}
