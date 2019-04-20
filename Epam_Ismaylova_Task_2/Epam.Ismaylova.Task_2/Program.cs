using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Ismaylova.Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            Man man = reader.Read();
            reader.Out(man.ToString());

        }
    }
}
