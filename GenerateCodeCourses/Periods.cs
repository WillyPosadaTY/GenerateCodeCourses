using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateCodeCourses
{
    internal class Periods
    {
        string year;
        string type;
        string number;
        int maxPeriod;

        public Periods()
        {
            this.year = "";
            this.type = "";
            this.number = "";
            this.maxPeriod = 0;
        }
        public Periods(string year, string type, string number)
        {
            this.year = year;
            this.type = type;
            this.number = number;
            this.maxPeriod = 0;
        }

        public int validateYear(string year)
        {

            int result = -1;
            if (year.Length == 4)
            {
                if (int.TryParse(year, out result))
                {
                    if (2021 <= Convert.ToInt32(year) && Convert.ToInt32(year) <= 2023)
                    {
                        return result;
                    }
                    return -1;
                }
                return -1;
            }
            return -1;
        }

        public char validateType(string type)
        {
            if (type.Length == 1)
            {
                if (type.Equals("S"))
                {
                    setMaxPeriod(2);
                    return 'S';
                }
                else if (type.Equals("Q"))
                {
                    setMaxPeriod(3);
                    return 'Q';
                }
                else if (type.Equals("M"))
                {
                    setMaxPeriod(10);
                    return 'M';
                }
                return 'N';
            }
            return 'N';
        }
        public int validateNumber(string number, int maxPer)
        {
            int results = -1;
            if (int.TryParse(number, out results))
            {
                if (Convert.ToInt32(number) > 0 && Convert.ToInt32(number) <= maxPer)
                {
                    return Convert.ToInt32(number);
                }
                else
                {
                    return -1;
                }
            }
            return -1;
        }

        private void setMaxPeriod(int number)
        {
            this.maxPeriod = number;
        }

        public int getMaxPeriod()
        {
            return this.maxPeriod;
        }
    }
    
}
