using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeU
{
	class Lecture
	{
		String[] Date = new String[3];
		String[] Time = new String[2];
		String Place;
		String Lecturer;

		DateTime dateTime;

		public Lecture(String line)
		{
			char[] sep = { ',' };
			String[] data = line.Split(sep);
			this.Date = data[0].Split(new char[] { '-' });
			this.Time = data[1].Split(new char[] { ':' });
			this.Place = data[2];
			this.Lecturer = data[3];

			try
			{
				dateTime = new DateTime(int.Parse(Date[0]), int.Parse(Date[1]), int.Parse(Date[2]), int.Parse(Time[0]), int.Parse(Time[1]), 0);
			}
			catch (Exception e) { }
		}
		public string ToString()
		{
			return dateTime.ToString() + " at " + Place + " by " + Lecturer;
		}
	}

}
