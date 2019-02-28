using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace hashcode
{
    class Program
    {
        class dataset {

        }
        static List<Images> dataInput = new List<Images>();
        static void Main(string[] args)
        {

            readDAtaset();
            var plm = dataInput[5];
        }

        static void readDAtaset()
        {
            string nume = Directory.GetCurrentDirectory();
            string path = @"..\..\Data\b_lovely_landscapes.txt";
            string[] files = File.ReadAllLines(path);
            for(int i=1; i< Int32.Parse(files[0]); ++i)
            {
                string[] content = files[i].Split(' ');
                var new_img = new Images(content[0]);
                for (var j = 2; j < content.Length; ++j)
                {
                    new_img.AddTag(content[j]);
                }
                dataInput.Add(new_img);

            }
        }
    }
}
