using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class ExceptionOfSalary : Exception
    {
        public ExceptionOfSalary(string msg) : base(msg)
        {

        }
    }
}
