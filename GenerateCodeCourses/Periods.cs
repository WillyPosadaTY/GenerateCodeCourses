using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateCodeCourses
{
    internal class Periods
    {
        string period;
        string year;
        char type;
        int number;
        int maxPeriod;
        private readonly string PERIOD_SEMESTER_TYPE = "S";
        private readonly string PERIOD_QUARTER_TYPE = "Q";
        private readonly string PERIOD_MONTH_TYPE = "M";

        public Periods(string period)
        {
            this.period = period;
        }


        public bool validatePeriod()
        {
            string[] prueba = new string[2];
            if (this.period.Split((PERIOD_MONTH_TYPE))[0].Length == 4)
            {
                prueba = this.period.Split(PERIOD_MONTH_TYPE);
                this.type = Char.Parse(PERIOD_MONTH_TYPE);
            }
            else if(this.period.Split(PERIOD_QUARTER_TYPE)[0].Length == 4)
            {
                prueba = this.period.Split(PERIOD_QUARTER_TYPE);
                this.type = Char.Parse(PERIOD_QUARTER_TYPE);
            }
            else if(this.period.Split(PERIOD_SEMESTER_TYPE)[0].Length == 4)
            {
                prueba = this.period.Split(PERIOD_SEMESTER_TYPE);
                this.type = Char.Parse(PERIOD_SEMESTER_TYPE);
                
            }
            this.type = validateType();
            this.year = prueba[0];
            this.year = validateYear().ToString();
            if(this.year != "-1")
            {
                if(int.TryParse(prueba[1] , out number))
                {
                    this.number = validateNumber();
                    if(this.number > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        private int validateYear()
        {

            int result = -1;
            if (this.year.ToString().Length == 4)
            {
                if (this.year.ToString().Length == 4)
                {
                    if (int.TryParse(this.year, out result))
                    {
                        if (2021 <= Convert.ToInt32(this.year) && Convert.ToInt32(this.year) <= 2023)
                        {
                            return result;
                        }
                        return -1;
                    }
                    return -1;
                }
            }
            return -1;
        }

        private char validateType()
        {
            
            if (this.type.Equals(Char.Parse(PERIOD_SEMESTER_TYPE)))
            {
                setMaxPeriod(2);
                return Char.Parse(PERIOD_SEMESTER_TYPE);
            }
            else if (this.type.Equals(Char.Parse(PERIOD_QUARTER_TYPE)))
            {
                setMaxPeriod(3);
                return Char.Parse(PERIOD_QUARTER_TYPE);
            }
            else if (this.type.Equals(Char.Parse(PERIOD_MONTH_TYPE)))
            {

                setMaxPeriod(10);
                return Char.Parse(PERIOD_MONTH_TYPE);
            }

            return 'N';
        }
        private int validateNumber()
        {
            if (Convert.ToInt32(this.number) > 0 && Convert.ToInt32(this.number) <= getMaxPeriod())
            {
                return Convert.ToInt32(number);
            }
            else
            {
                return -1;
            }
            
        }

        public Periods selectPeriod(List<Periods> period, int position)
        {
            return period[position];
        }


        private void setMaxPeriod(int number)
        {
            this.maxPeriod = number;
        }

        public int getMaxPeriod()
        {
            return this.maxPeriod;
        }
        public string getPeriod()
        {
            return this.period;
        }
    }
    
}
