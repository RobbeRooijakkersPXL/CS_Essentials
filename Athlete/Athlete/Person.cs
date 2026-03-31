using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athlete
{
    internal class Person
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private int _lapTime;

		public int LapTime
		{
			get { return _lapTime; }
			set { _lapTime = value; }
		}


	}
}
