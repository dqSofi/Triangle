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
    public partial class TriangleTypeForm : Form
    {
        public TriangleTypeForm()
        {
            InitializeComponent();
        }

        private void resultClick(object sender, EventArgs e)
        {
            string result="";
            try
            {
                Triangle newTriangle = ReadAllSides();
                    if (newTriangle.Exists())
                    {
                        result = newTriangle.Type;
                    }
                    else
                    {
                        result = "Треугольник не существует";
                    }
            }
            catch (FormatException)
            {
                result = "Не все поля заполнены положительными числами";
            }
            catch (ZeroSideException)
            {
                result = "Значения длин должны быть больше нуля";
            }
            catch
            {
                result = "Возникла ошибка";
            }
            textBoxRes.Text = result;
        }

        private Triangle ReadAllSides()
        {
            decimal a, b, c;
            a = Convert.ToDecimal((textBoxA.Text).Replace('.', ','));
            c = Convert.ToDecimal((textBoxC.Text).Replace('.', ','));
            b = Convert.ToDecimal((textBoxB.Text).Replace('.', ','));
            if ((a <= 0) || (b <= 0) || (c <= 0))
            {
                throw new ZeroSideException();
            }
            return  new Triangle(a, b, c);
        }
    }
}