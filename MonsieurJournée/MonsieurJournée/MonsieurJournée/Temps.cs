using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsieurJournée
{
    internal class Temps
    {
        int hour;
        int minute;
        int day;
        int month;
        int year;
        public Temps()
        {
            hour = 8;
            minute = 00;
            day = 14;
            month = 12;
            year = 2022;
        }

        public bool AddHour (int _hour)
        {
            if (_hour > 0)
            {
                hour += _hour;
            while(hour > 24)
            {
                hour -= 24;
                day++;
            }
            return true;
        }
            else
            return false;
        }
        public bool AddMinute(int _minute)
        {
            if (_minute > 0)
            {
                minute += _minute;
                while (minute > 60)
                {
                    hour -= 60;
                    day++;
                }
                return true;
            }
            else
            return false;
        }

        private void ChangeDate()
        {
            while(day >30)
            {
                day -= 30;
                month++;
            }
            while(month > 12)
            {
                month -= 12;
                year++;
            }
        }

    }
}
