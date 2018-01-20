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
                    decimal max, mid, min, sqrMax, sqrSum;
                    if (A > B)
                    {
                        mid = A;
                        min = B;
                    }
                    else
                    {
                        min = A;
                        mid = B;
                    }
                    if (C > mid)
                    {
                        max = C;
                    }
                    else
                    {
                        max = mid;
                        mid = C;
                    }
                    sqrMax = max * max;
                    sqrSum = mid * mid + min * min;
                    if (sqrMax > sqrSum)
                    {
                        return "Тупоугольный";
                    }
                    else if (sqrMax == sqrSum)
                    {
                        return "Прямоугольный";
                    }
                    else if (sqrMax < sqrSum)
                    {
                        return "Остроугольный";
                    }
                    else { return ""; }
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
            return ((A + B > C) && (A + B > C) && (A + C > B));
        }
    }
}
