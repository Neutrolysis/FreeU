using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeU
{
	class SensorsUnit
	{
		int FIRE_ALARM_MIN_TEMP;
		int FIRE_ALARM_MIN_SMOKE;

		public double temp, smoke, humidity,power;

		public SensorsUnit()
		{
			this.FIRE_ALARM_MIN_TEMP = Properties.Settings.Default.FIRE_ALARM_MIN_TEMP;
			this.FIRE_ALARM_MIN_SMOKE = Properties.Settings.Default.FIRE_ALARM_MIN_SMOKE;
		}

		public bool thereIsFire()
		{
			return temp >= FIRE_ALARM_MIN_SMOKE || smoke >= FIRE_ALARM_MIN_TEMP;
		}
	}
}
