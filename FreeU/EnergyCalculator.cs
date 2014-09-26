using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeU
{
	class EnergyCalculator
	{
		bool started = false;
		DateTime t1;
		DateTime t2;
		private double consumedEnergy = 0;
		private double cost = 0;

		double voltage = 220;

		//Adds current reading
		public void addCurrentReading(double reading)
		{
			if (!started)
			{
				started = true;
				t1 = DateTime.Now;
				consumedEnergy = 0;
			}
			t2 = DateTime.Now;
			TimeSpan diff = t2.Subtract(t1);
			consumedEnergy += (diff.TotalMilliseconds / 1000 / 60 / 60) * (reading / 1000) * voltage;
			t1 = DateTime.Now;
		}

		public double getConsumedPower()
		{ return consumedEnergy; }
		public double getCost()
		{ return cost; }

	}
}
