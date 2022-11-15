using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    internal struct Linear
    {
        double k;
        double b;

        public Linear(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            if (k == 0 && b == 0)
            { return "x - любое"; }
            else if (k == 0 && b != 0)
            { return "Решений нет"; }
            else
            {
                double x = (-b / k);
                return $"x = {x}";
            }
        }
    }
}
