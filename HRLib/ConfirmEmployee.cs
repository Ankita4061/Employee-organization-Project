using System;
using System.Collections.Generic;
using System.Text;


namespace HRLib
{
    public class ConfirmEmployee : Employee
    {
        #region properties and declaration
        private double basic;

        public double Basic
        {
            get { return basic; }
            set {
                if (value < 5000)
                {
                    throw new ExceptionOfSalary("amount is less than 5000");
                }
                basic = value; }
        }

        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }


        #endregion

        #region Constructor
        public ConfirmEmployee() :base()
        {
            designation = "trainee";
            basic = 80000;
        }
        public ConfirmEmployee(string designation, double basic, string name, string addres) : base(name, addres)
        {
            Designation = designation;
            Basic = basic;
        }
        #endregion

        public sealed override double CalculateSalary()
        {
            double hra;
            double conv;
            double PF;

            if (basic > 30000)
            {
                hra = 0.3 * basic;
                conv= 0.3 * basic;
                PF = 0.1 * basic;
            }
            else if(Basic >= 20000)
            {
                hra =0.2 * basic;
                conv =0.2 * basic;
                PF =0.1 * basic;
            }
            else
            {
                hra =0.1 * basic;
                conv = 0.1 * basic;
                PF = 0.1 * basic;

            }
            return basic + hra + conv - PF;
        }

        public override string ToString()
        {
            return $"{this.Name} with employee id {this.Id} is a confirmed employee with salary {this.CalculateSalary()}";
        }
    }
}
