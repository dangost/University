using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form1 : Form
    {

        private Integral integral;
        public Form1()
        {
            InitializeComponent();
            a_textBox.Text = "0";
            b_textBox.Text = "1";
            step_textBox.Text = "6";
            
        }
        private void start_button_Click(object sender, EventArgs e)
        {
            double a, b;
            int steps;
            if (!Parser(out a, out b, out steps))
            {
                return;
            }

            foreach (var radiobutton in groupBox1.Controls)
            {
                if ( ((RadioButton)radiobutton).Checked == true )
                {
                    integral = new Integral(a, b, steps, (double x) => (1) / (x + Math.Pow(Math.Cos(x), 0.5))) { Accurancy = 0.01f};

                    chart1.Series[0].Points.Clear();
                    chart1.Series[1].Points.Clear();
                    chart1.ChartAreas[0].AxisX.Maximum = b;
                    chart1.ChartAreas[0].AxisX.Minimum = a;
                    chart1.ChartAreas[0].AxisX.Interval = 0;

                    integral.DrawFunc(chart1);

                    switch (((RadioButton)radiobutton).Name)
                    {
                        case "Trapeze_radioButton":
                            result_textBox.Text = integral.TrapezeRectangle().ToString();
                            integral.DrawTrapezeRectangle(chart1);
                            break;

                        case "LeftRectangle_radioButton":
                            result_textBox.Text = integral.LeftRectangle().ToString();
                            integral.DrawLeftRectangle(chart1);
                            break;

                        case "RightRectangle_radioButton":
                            result_textBox.Text = integral.RightRectangle().ToString();
                            integral.DrawRightRectangle(chart1);
                            break;

                        case "MiddleRectangle_radioButton":
                            result_textBox.Text = integral.CentralRectangle().ToString();
                            integral.DrawCentralRectangle(chart1);
                            break;

                        default:
                            break;
                    }

                    upper_textBox.Text = b_textBox.Text;
                    lower_textBox.Text = a_textBox.Text;
                    break;
                }
            }
        }

        private bool Parser(out double a, out double b, out int steps) 
        {
            if (double.TryParse(a_textBox.Text, out a) && double.TryParse(b_textBox.Text, out b) && int.TryParse(step_textBox.Text, out steps))
            {
                return true;
            }
            else
            {
                a = 0;
                b = 0;
                steps = 0;
                return false;
            }
        }

        private void RightRectangle_radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
