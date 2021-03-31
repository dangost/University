using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    public partial class Lab3Form : Form
    {
        
        RIntegral func1;
        RIntegral func2;       
        MutualAreaIntegals mutualArea;

        public Lab3Form()
        {
            InitializeComponent();
        }

        private void Lab3Form_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = chart1.Series["Func1"].Color; //серия графика 1й функции
            pictureBox4.BackColor = chart1.Series["Func2"].Color; //серия графика 2й функции
            pictureBox2.BackColor = chart1.Series["Func1Area"].Color; //серия графика площади 1й функции
            pictureBox3.BackColor = chart1.Series["Func2Area"].Color; //серия графика площади 2й фунцкии
            pictureBox5.BackColor = chart1.Series["MutualArea1"].Color; //серия графика общей площади
        }

        #region Выбор цветов

        private void SetFunc1Color_Button_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            chart1.Series["Func1"].Color = colorDialog1.Color;
            pictureBox1.BackColor = colorDialog1.Color;
        }

        private void SetFunc2Color_Button_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            chart1.Series["Func2"].Color = colorDialog1.Color;
            pictureBox4.BackColor = colorDialog1.Color;
        }

        private void SetFunc1AreaColor_Button_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            chart1.Series["Func1Area"].Color = colorDialog1.Color;
            pictureBox2.BackColor = colorDialog1.Color;
        }

        private void SetFunc2AreaColor_Button_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            chart1.Series["Func2Area"].Color = colorDialog1.Color;
            pictureBox3.BackColor = colorDialog1.Color;
        }

        private void MutualAreaColor_Button_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            chart1.Series["MutualArea1"].Color = colorDialog1.Color;
            pictureBox5.BackColor = colorDialog1.Color;
        }

        #endregion

        #region Рисование графиков

        private void DrawFunc1_Button_Click(object sender, EventArgs e)
        {

            bool flag1 = double.TryParse(textBox1.Text, out double bottom);
            bool flag2 = double.TryParse(textBox2.Text, out double top);
            bool flag3 = double.TryParse(textBox4.Text, out double step);



            if (func1 == null)
            { func1 = new RIntegral(bottom, top, step, chart1, "Func1", "Func1Area");
                func1.DrawFunction();
                func1.DrawArea(); }
      
        }

        private void DrawFunc2_Button_Click(object sender, EventArgs e)
        {
            bool flag1 = double.TryParse(textBox6.Text, out double bottom);
            bool flag2 = double.TryParse(textBox5.Text, out double top);
            bool flag3 = double.TryParse(textBox4.Text, out double step);

            if (flag1 && flag2 && flag3)
            {
                if (func2 == null)
                {
                    func2 = new RIntegral(bottom, top, step, chart1, "Func2", "Func2Area");
                    func2.DrawFunction();
                    func2.DrawArea();
                }
            }
        }

        private void DrawMutualArea_Button_Click(object sender, EventArgs e)
        {
            bool flag1 = double.TryParse(textBox1.Text, out double f1_bottom);
            bool flag3 = double.TryParse(textBox2.Text, out double f1_top);
            bool flag2 = double.TryParse(textBox6.Text, out double f2_bottom);
            bool flag4 = double.TryParse(textBox5.Text, out double f2_top);
            bool flag5 = double.TryParse(textBox4.Text, out double step);

            if (flag1 && flag2 && flag3 && flag4 && flag5)
            {
                if (mutualArea == null)
                {
                    mutualArea = new MutualAreaIntegals(chart1, "MutualArea1", f1_bottom, f1_top, f2_bottom, f2_top, step);

                    mutualArea.DrawFunc();
                }
            }
            else
            {
                MessageBox.Show("Заполните данные обоих графиков!!");
            }

        }

        #endregion

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            calcName_Label.Text = "Общая площадь:";
            if (mutualArea != null)
            { calcValue_Label.Text = mutualArea.CalcLeftRectanglesSquare().ToString(); }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            calcName_Label.Text = "Сумма:";
            if (func1 != null && func2 != null)
            { calcValue_Label.Text = (func1.CalculateArea() + func2.CalculateArea()).ToString(); }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            calcName_Label.Text = "Разность:";
            if (func1 != null && func2 != null) { calcValue_Label.Text = (Math.Abs(func1.CalculateArea()) - Math.Abs(func2.CalculateArea())).ToString(); }
        }

        private void CalcF1Area_Button_Click(object sender, EventArgs e)
        {
            if (func1 != null) {func1Area_Label.Text = func1.CalculateArea().ToString(); }
        }

        private void CalcF2Area_Button_Click(object sender, EventArgs e)
        {
            if (func2 != null) { func2Area_Label.Text = func2.CalculateArea().ToString(); }
        }
    }
}
