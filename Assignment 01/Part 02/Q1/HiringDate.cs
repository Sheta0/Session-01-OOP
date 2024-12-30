using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01.Part_02.Q1
{
	internal class HiringDate
	{
		private int day;
		private int month;
		private int year;

		public int Year
		{
			get { return year; }
			set 
			{
				if (value < 1900 || value > 2025)
				{
					throw new ArgumentOutOfRangeException("Year must be between 1900 and 2025");
				}
				year = value; 
			}
		}


		public int Month
		{
			get { return month; }
			set 
			{
				if (value < 1 || value > 12)
				{
					throw new ArgumentOutOfRangeException("Month must be between 1 and 12");
				}
				else
				{
					month = value;
				}

			}
		}

		public int Day
		{
			get { return day; }
			set 
			{ 
				if (value < 1 || value > 31)
				{
					throw new ArgumentOutOfRangeException("Day must be between 1 and 31");
				} else
				{
					day = value;
				}
			}
		}

        public HiringDate(int _day, int _month, int _year)
        {
			Day = _day;
			Month = _month;
            Year = _year;
        }

        public override string ToString()
        {
			return $"{Day}/{Month}/{Year}";
        }
    }
}
