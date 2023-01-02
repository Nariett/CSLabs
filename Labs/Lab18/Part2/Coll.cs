using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    [Serializable]
    internal class Coll
    {
        private string _name;
        private int _year;
        private double _mass;
        private double _price;
        private string _nameMan;
        public Coll(string name, int year, double mass, double price, string nameMan)
        {
            _name = name;
            _year = year;
            _mass = mass;
            _price = price;
            _nameMan = nameMan;
        }
        public double Price
        {
            get { return _price; }
        }
        public override string ToString()
        {
            return $"Название: {_name} Год: {_year} Масса (кг): {_mass} Цена: {_price} Имя владельца: {_nameMan}";
        }

    }
}
