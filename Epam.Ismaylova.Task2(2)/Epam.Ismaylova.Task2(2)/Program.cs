using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Ismaylova.Task2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Author> authors = new List <Author>() { new Author("Иван", "Бунин", new DateTime(1870, 10, 26)) };
           foreach (var a in authors)
            {
                Console.WriteLine(a);
            }
            Book book = new Book(authors, "На край света", 2, "ABC", new DateTime(2019, 04, 20), new DateTime(1897, 01, 01));
            Console.WriteLine(book);
        }
    }
}
