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
            decimal a, b, c;
            string result="";
            
            try
            {
                a = Convert.ToDecimal((textBoxA.Text).Replace('.',','));
                c = Convert.ToDecimal((textBoxC.Text).Replace('.',','));
                b = Convert.ToDecimal((textBoxB.Text).Replace('.',','));
                if ((a <= 0) || (b <= 0) || (c <= 0))
                {
                    result = "Значения длин должны быть больше нуля";
                }
                else
                {
                    Triangle newTriangle = new Triangle(a, b, c);
                    if (newTriangle.Exists())
                    {
                        result = newTriangle.Type;
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
    }
}