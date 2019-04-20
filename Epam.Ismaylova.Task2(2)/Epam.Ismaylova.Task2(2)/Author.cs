using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Ismaylova.Task2_2_
{
    class Author
    {
        private string _firstName;
        private string _secondName;
        private  DateTime _dateOfBirth;
        public Author(string FirstName, string SecondName, DateTime DateOfBirth)
        {
            _firstName = FirstName;
            _secondName = SecondName;
            _dateOfBirth = DateOfBirth;
        }
        public string FirstName { get { return _firstName; }set { _firstName = value; } }
        public string SecondName { get { return _secondName; } set { _secondName = value; } }
        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }
        public override string ToString()
        {
            return $"{FirstName} {SecondName} {DateOfBirth.ToShortDateString()}";
        }
    }
}
