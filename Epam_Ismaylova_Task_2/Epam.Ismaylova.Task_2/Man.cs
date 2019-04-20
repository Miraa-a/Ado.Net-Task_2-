using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Ismaylova.Task_2
{
   public class Man
    {
        private string _name;
        private int _age;
        private double _weight;
        private double _height;

        public Man(string name, int age, double weight, double height)
        {
            _name = name;
            _age = age;
            _weight = weight;
            _height = height;
        }
  
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }  
        public int Age {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
       
        public double Weight {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }
      
        public double Height {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
       
        public override string ToString()
        {
            return $"Имя:{Name} Возраст:{Age} Вес:{Weight} Рост:{Height}";

        }

    }
}
