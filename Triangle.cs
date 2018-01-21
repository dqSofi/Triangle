using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        private decimal A { get; set; }
        private decimal B { get; set; }
        private decimal C { get; set; }
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
                    FindSqrs(allSides, out sqrMax, out sqrSum);
                    return CalculateType(sqrMax, sqrSum);
                }
            }
            private set
            {
                type = value;
            }
        }

        internal Triangle(decimal a, decimal b, decimal c)
        {
            A = a;
            B = b;
            C = c;
        }

        internal bool Exists()
        {
            return ((A + B > C) && (C + B > A) && (A + C > B));
        }

        private void FindSqrs(decimal[] allSides,out decimal sqrOfMaxSide, out decimal sumOfSidesSqrs)
        {
            sqrOfMaxSide = allSides.Max() * allSides.Max();
            sumOfSidesSqrs = allSides[0] * allSides[0] + allSides[1] * allSides[1] + allSides[2] * allSides[2] - sqrOfMaxSide;
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
