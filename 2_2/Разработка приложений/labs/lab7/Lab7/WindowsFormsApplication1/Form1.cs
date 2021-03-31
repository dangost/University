using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Equation uravn;

        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            uravn = new EquationDaughter1(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), label19);
          
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series["Функция"].Points.Clear();
            label19.Text = "";
            
            try
            {
                uravn.A = Double.Parse(textBox1.Text);
                uravn.B = Double.Parse(textBox2.Text);
                uravn.H = Double.Parse(textBox3.Text);
                uravn.X0 = Double.Parse(textBox1.Text);
                uravn.Y0 = Double.Parse(textBox2.Text);
            } catch(Exception)
            {
                label19.Text = "Неверный ввод";
            }
            if (radioButton1.Checked)
            {
                uravn.Eiler_draw(chart1.Series["Функция"]);
                uravn.Eiler();
            }

            if (radioButton2.Checked)
            {
                uravn.usov_Eiler_draw(chart1.Series["Функция"]);
                uravn.usov_Eiler();
            }

            if (radioButton3.Checked)
            {
                uravn.Runge_Kutta_3_draw(chart1.Series["Функция"]);
                uravn.Runge_Kutta_3();
            }

            if (radioButton4.Checked)
            {
                uravn.Runge_Kutta_4_draw(chart1.Series["Функция"]);
                uravn.Runge_Kutta_4();
            }
            uravn.addData(dataGridView1);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            uravn = new EquationDaughter1(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), label19);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            uravn = new Equation(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), label19);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            uravn = new EquationDaughter2(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), label19);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}