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
                    FindMaxSqr(A, B, C, out sqrMax, out sqrSum);
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

        public void FindMaxSqr(decimal a, decimal b, decimal c, out decimal kvmax, out decimal kvsum)
        {
            decimal[] allSides = new decimal[3] {a,b,c};
            decimal sum = a * a + b * b + c * c;
            decimal max = allSides.Max()*allSides.Max();
            kvmax = max;
            kvsum = sum-max;
        }
    }
}
