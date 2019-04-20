using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Ismaylova.Task_2
{
    class Student : Man
    {
        private int _start;
        private int _course;
        private int _groupId; 
        public Student(string name, int age, double weight, double height, int start, int course, int group) : base(name, age, weight, height)
        {
            _start = start;
            _course = course;
            _groupId = group;
        }      
        public int Start {
            get
            {
                return _start;
            }
            set
            {
                _start = value;
            }
        }
        public int Course
        {
            get
            {
                return _course;
            }
            set
            {
                _course = value;
            }
        }
        public int GroupId
        {
            get
            {
                return _groupId;
            }
            set
            {
                _groupId = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $" Поступил в:{Start} Курс:{Course} Группа:{GroupId}";
        }
    }
}
