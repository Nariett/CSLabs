using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    [Serializable]
    public class Date
    {
        public DateTime _data;
        public Date(DateTime data)
        {
            this._data = data;
        }
        public Date()
        {
            this._data = new DateTime(2009, 01, 01);
        }
        public override string ToString()
        {
            return $"{_data:dd/mm/yyyy}";
        }
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        {
                            return _data.Day;
                        }
                    case 1:
                        {
                            return _data.Month;
                        }
                    case 2:
                        {
                            return _data.Year;
                        }
                    default:
                        {
                            return 0;
                        }
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        {
                            this._data = new DateTime(_data.Year, _data.Month, value);
                            break;
                        }
                    case 1:
                        {
                            this._data = new DateTime(_data.Year, value, _data.Day);
                            break;
                        }
                    case 2:
                        {
                            this._data = new DateTime(value, _data.Month, _data.Day);
                            break;
                        }
                    default:
                        {
                            this._data = _data;
                            break;
                        }
                }
            }
        }

        public DateTime pastData()
        {
            int day = _data.Day;
            int month = _data.Month;
            int year = _data.Year;
            day--;
            if (day == 0)
            {
                day = 30;
                month--;
            }
            if (month == 0)
            {
                month = 12;
                year--;
            }
            return new DateTime(year, month, day);
        }
        public DateTime nextData()
        {
            int day = _data.Day;
            int month = _data.Month;
            int year = _data.Year;
            day++;
            if (day > 30)
            {
                day = 1;
                month++;
            }
            if (month > 12)
            {
                month = 1;
                year++;
            }
            return new DateTime(year, month, day);
        }
        public int lastDay()
        {
            return 30 - _data.Day;
        }

    }
}
