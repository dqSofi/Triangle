using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleType
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
                    decimal[] allSides = new decimal[3] {A, B, C};
                    FindSqrs(allSides, out decimal sqrMax, out decimal sqrSum);
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

        public Triangle()
        {
            A = 0;
            B = 0;
            C = 0;
            Type = "";
        }

        public bool Exists()
        {
            return ((A + B > C) && (C + B > A) && (A + C > B));
        }

        public void FindSqrs(decimal[] allSides,out decimal sqrOfMaxSide, out decimal sumOfSidesSqrs)
        {
            sqrOfMaxSide = allSides.Max() * allSides.Max();
            sumOfSidesSqrs = allSides[0] * allSides[0] + allSides[1] * allSides[1] + allSides[2] * allSides[2] - sqrOfMaxSide;
        }

        public string CalculateType(decimal sqrMax, decimal sqrSum)
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
