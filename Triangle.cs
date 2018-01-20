using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        decimal A { get; set; }
        decimal B { get; set; }
        decimal C { get; set; }
        string type;

        public string Type {
            get
            {
                if (type != null)
                {
                    return type;
                }
                else
                {
                    decimal sqrMax, sqrSum;
                    decimal[] allSides = new decimal[3] {A, B, C};
                    FindMaxSqr(allSides, out sqrMax, out sqrSum);
                    return CalculateType(sqrMax, sqrSum);
                }
            }
            private set
            {
                type = value;
            }
        }

        public Triangle(decimal a, decimal b, decimal c)
        {
            A = a;
            B = b;
            C = c;
        }

        internal bool Exists()
        {
            return ((A + B > C) && (C + B > A) && (A + C > B));
        }

        public void FindMaxSqr(decimal[] allSides,out decimal kvmax, out decimal kvsum)
        {
            decimal sum = allSides[1] * allSides[1] + allSides[2] * allSides[2] + allSides[3] * allSides[3];
            decimal max = allSides.Max()*allSides.Max();
            kvmax = max;
            kvsum = sum-max;
        }

        private static string CalculateType(decimal sqrMax, decimal sqrSum)
        {
            if (sqrMax > sqrSum)
            {
                return "Тупоугольный";
            }
            else if (sqrMax == sqrSum)
            {
                return "Прямоугольный";
            }
            else
            {
                return "Остроугольный";
            }
        }
    }
}
