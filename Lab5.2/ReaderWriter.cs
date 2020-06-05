using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2
{
    public class ReaderWriter
    {
        public List<string> readDataFromFile()
        {
            List<string> lines = new List<string>();
            string line;
            StreamReader file = new StreamReader("E:text.txt", Encoding.GetEncoding(1251));
            while ((line = file.ReadLine()) != null)
            {
                lines.Add(line);
            }

            file.Close();
            return lines;
        }

        public void saveList(List<WorkDay> workDays)
        {
            using (StreamWriter save = new StreamWriter("E:text.txt", false, Encoding.GetEncoding(1251)))
            {
                string str = null;

                foreach (var workDay in workDays)
                {
                    str = workDay.Date.ToString("dd/MM/yyyy") + "," + workDay.OrdersCount.ToString() + "," + workDay.PizzaOfTheDay;
                    save.WriteLine(str);
                }
            }
        }
    }
}
