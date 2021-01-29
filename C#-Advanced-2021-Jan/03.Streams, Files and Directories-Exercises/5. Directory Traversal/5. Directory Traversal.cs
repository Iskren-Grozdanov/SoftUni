using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _5._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> fileInfo = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directoryInfo = new DirectoryInfo(".");
            FileInfo[] files = directoryInfo.GetFiles();

            foreach (var file in files)
            {
                if (!fileInfo.ContainsKey(file.Extension))
                {
                    fileInfo.Add(file.Extension, new Dictionary<string, double>());
                }
                fileInfo[file.Extension].Add(file.Name, file.Length / 1000.00);
            }

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

            using (StreamWriter writer = new StreamWriter(@$"{path}\report.txt"))
            {
                foreach (var item in fileInfo.OrderByDescending(x => x.Value.Count).ThenBy(i => i.Key))
                {
                    writer.WriteLine(item.Key);

                    foreach (var file in item.Value.OrderByDescending(f => f.Value))
                    {
                        writer.WriteLine($"--{file.Key} - {file.Value}kb");
                    }
                }
            }
        }
    }
}
