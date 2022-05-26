using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ChefPovar
{
    public class FileService
    {
        public void FileWriter(string[] loger)
        {
            string dataTime = DateTime.Now.ToString("hh.mm.ss dd.MM.yyyy");
            string stringData = string.Concat(dataTime, ".txt");
            Console.WriteLine(stringData);
            string[] allfiles = Directory.GetFiles(@"C:\Users\Admin\source\repos\ChefPovar\ChefPovar\Foodkataog\");
            foreach (string file in allfiles)
            {
                Console.WriteLine(file);
            }

            if (allfiles.Length > 1)
            {
                DateTime[] dateTimes = new DateTime[allfiles.Length];
                for (int i = 0; i < allfiles.Length; i++)
                {
                    dateTimes[i] = File.GetCreationTime(allfiles[i]);
                }

                Array.Sort(dateTimes);
                Array.Reverse(dateTimes);
                for (int j = 0; j < allfiles.Length; j++)
                {
                    if (File.GetCreationTime(allfiles[j]) == dateTimes[1])
                    {
                        string.Concat("@", allfiles[j]);
                        File.Delete(allfiles[j]);
                        break;
                    }
                }
            }

            stringData = string.Concat(@"C:\Users\Admin\source\repos\ChefPovar\ChefPovar\Foodkataog\", stringData);
            File.WriteAllLines(stringData, loger);
        }
    }
}
