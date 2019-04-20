using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Ismaylova.Task2_2_
{
    class Book
    {
        private string _name;
        private int _numberOfPages;
        private string _publishingOffice;
        private DateTime _dateOfEdition;
        private DateTime _dateOfWriting;
        private List <Author> _author;
        public Book(List <Author> Author, string name, int pages, string publishingOffice, DateTime dateofEdition, DateTime dateofWriting)
        {
            _author = Author;
            _name = name;
            _numberOfPages = pages;
            _publishingOffice = publishingOffice;
            _dateOfEdition = dateofEdition;
            _dateOfWriting = dateofWriting;
        }
        public string Name { get { return _name; } set { _name = value; } }
        public int Pages { get { return _numberOfPages; } set { _numberOfPages = value; } }
        public string PublishingOffice { get { return _publishingOffice; } set { _publishingOffice = value; } }
        public DateTime DateOfEdition { get { return _dateOfEdition; } set { _dateOfEdition = value; } }
        public DateTime DateOfWriting { get { return _dateOfWriting; } set { _dateOfWriting = value; } }
     
        public override string ToString()
        { 
            return $"Название: {Name}\nИздательство: {PublishingOffice}\nДата написания: {DateOfWriting}\nДата издания: {DateOfEdition}\nКол-во страниц: {Pages}";
        }
    }
}
