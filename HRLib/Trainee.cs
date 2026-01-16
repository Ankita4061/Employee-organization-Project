using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class Trainee : Employee
    {
		private int noOfDays;

		public int NoDays
		{
			get { return noOfDays; }
			set { noOfDays = value; }
		}

		private double rate;

		public double Rate
		{
			get { return rate; }
			set { rate = value; }
		}

		#region constructor
		public Trainee(): base()
		{
			noOfDays = 0;
			rate = 1000;
		}

		public Trainee(int noOfDays, double rate, string name, string address  ) : base(name, address) 
		{ 
			this.noOfDays = noOfDays; this.rate = rate;
		}
        public sealed override double CalculateSalary()
        {
            return  rate*NoDays;
        }
        #endregion

        public override string ToString()
        {
            return $"{this.Name} with employee id {this.Id} is a trainee employee with salary {this.CalculateSalary()}";
        }
    }
}
