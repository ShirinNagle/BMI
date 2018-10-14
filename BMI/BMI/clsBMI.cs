using System;
using System.Collections.Generic;
using System.Text;

namespace BMI
{
    public class clsBMI
    {
        public clsBMI()
        {

        }

        public double calculate(double h, double w)
        {
            double myBMI = 0;
            myBMI = Math.Round(w / (h * h), 2);

            return myBMI;
        }
    }
}
