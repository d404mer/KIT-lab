using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3_2_PITPM
{
    public class PercentageCalculator
    {
        public double CalculatePercentage(double percentage, double number)
        {
            return (percentage / 100) * number; 
        }
    }
}
