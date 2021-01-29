using System;
using System.IO;

namespace _4._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "data/CopyMe.png";
            string dest = "data/NewCopy.png";
            using (FileStream StreamReader = new FileStream(path, FileMode.Open))
            {
                using (FileStream StreamWriter = new FileStream(dest, FileMode.Create))
                {

                    while (StreamReader.CanRead)
                    {
                        byte[] buffer = new byte[4096];

                        int ReadSize = StreamReader.Read(buffer, 0, buffer.Length);

                        if (ReadSize == 0)
                        {
                            break;
                        }

                        StreamWriter.Write(buffer, 0, ReadSize);
                    }
                }
            }
        }
    }
}
