using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }

        private void resultClick(object sender, EventArgs e)
        {
            decimal a, b, c, max,mid,min,sqrMax,sqrSum;
            string result="";
            
            try
            {
                a = Convert.ToDecimal(ReplaceDots(textBoxA.Text));
                c = Convert.ToDecimal(ReplaceDots(textBoxC.Text));
                b = Convert.ToDecimal(ReplaceDots(textBoxB.Text));
                if ((a <= 0) || (b <= 0) || (c <= 0))
                {
                    result = "Значения длин должны быть больше нуля";
                }
                else
                {
                    if ((a + b > c) && (b + c > a) && (a + c > b))
                    {
                        if (a > b)
                        {
                            mid = a;
                            min = b;
                        }
                        else
                        {
                            min = a;
                            mid = b;
                        }
                        if (c > mid)
                        {
                            max = c;
                        }
                        else
                        {
                            max = mid;
                            mid = c;
                        }
                        sqrMax = max * max;
                        sqrSum = mid * mid + min * min;
                        if (sqrMax > sqrSum)
                        {
                            result = "Тупоугольный";
                        }
                        else if (sqrMax == sqrSum)
                        {
                            result = "Прямоугольный";
                        }
                        else if (sqrMax < sqrSum)
                        {
                            result = "Остроугольный";
                        }
                    }
                    else
                    {
                        result = "Треугольник не существует";
                    }
                }
            }
            catch (FormatException)
            {
                result = "Не все поля заполнены положительными числами";
            }
            catch
            {
                result = "Возникла ошибка";
            }
            
            textBoxRes.Text = result;
        }

        private string ReplaceDots(string text)
        {
            string textWithoutDots = "";
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.')
                {
                    textWithoutDots = textWithoutDots + ",";
                }
                else
                {
                    textWithoutDots = textWithoutDots + text[i];
                }
            }
            return textWithoutDots;
        }
    }
}


/*if ((a == b) || (b == c) || (a == c))
               {
                   if ((a == b) && (b == c))
                   {
                       result = "Треугольник равносторонний";
                   }
                   else
                   {
                       result = "Треугольник равнобедренный";
                   }
               }
               else
               {
                   result = "Треугольник простой";
               }*/

/*private decimal FindMaxSide(decimal a, decimal b, decimal c)
{
    if ((a > b) && (a > c))
    {
        return a;
    }
    else if ((b > c) && (b > a))
    {
        return b;
    }
    else if ((c > b) && (c > a))
    {
        return c;
    }
    else return 0;
}*/