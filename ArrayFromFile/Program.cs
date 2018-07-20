using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            const string file = "settings.ini";
            if (File.Exists(file))
            {
                string[] arr = File.ReadAllLines(file);
                char pattern = ',';
                String[] mobs = arr[0].Split(pattern);
                for (int i = 0; i < mobs.Length; i++)
                {
                    Console.WriteLine(mobs[i]);
                }
            }
            else
            Console.WriteLine("Файл settings.ini не найден");
            Console.ReadKey();
        }
    }
}
