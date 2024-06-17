using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_GiaiPtBac1Bac2
{
    internal class PTBac2:PTBac1
    {
        public string GiaiPTBac2(double a, double b, double c)
        {   
            if (a == 0)
                return GiaiPTBac1(b, c);
            else
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                    return "Phương trình vô nghiệm";
                else if (delta == 0)
                    return "Phương trình có nghiệm kép x1 = x2 = " + (-b / (2 * a));
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    return $"Phương trình có 2 nghiệm:\n x1 = {x1:F2} \n x2 = {x2:F2}";
                }    
            }
        }
    }
}