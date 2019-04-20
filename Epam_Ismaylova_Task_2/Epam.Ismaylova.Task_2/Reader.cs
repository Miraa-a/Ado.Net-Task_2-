using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Epam.Ismaylova.Task_2
{
    public class Reader  {

         private const string FileIn = "input.txt";
         private const string FileOut = "output.txt";  
        public Man Read()
        {
            List<string> coordinates = new List<string>();
           
            using (StreamReader reader = new StreamReader(FileIn))
            {
                Man s;
                string[] fromFile = reader.ReadToEnd().Split(new[] { ' ', '\r', '\n', ';' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(item => item.Trim())
                    .Where(item => !string.IsNullOrEmpty(item)).ToArray();
                foreach (var t in fromFile)
                {
                    coordinates.Add(t);
                }
                if (coordinates.Count() == 4)
                {
                    s = new Man(coordinates[0], int.Parse(coordinates[1]), double.Parse(coordinates[2]), double.Parse(coordinates[3]));
                }
                else
                {
                    s = new Student(coordinates[0], int.Parse(coordinates[1]), double.Parse(coordinates[2]), double.Parse(coordinates[3]),
                int.Parse(coordinates[4]), int.Parse(coordinates[5]), int.Parse(coordinates[6]));
                }
              return s;
            } 
        
        }
        public void Out(string s)
        {
            using (StreamWriter fileOut = new StreamWriter(FileOut))
            {
                fileOut.WriteLine(s);
            }
        }
    }
}
