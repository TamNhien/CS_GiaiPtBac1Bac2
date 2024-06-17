using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_GiaiPtBac1Bac2
{
    internal class PTBac1
    {
        public string GiaiPTBac1(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                    return "Phương trình vô số nghiệm";
                else
                    return "Phương trình vô nghiệm";
            }
            else
                return $"Phương trình có nghiệm x = {-b / a}";
        }
    }
}