using lab_4.Integrals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    public partial class Lab4Form : Form
    {
        MegaIntegral integral1;
        MegaIntegral integral2;
        MegaIntegral integral1Area;
        MegaIntegral integral2Area;
        MutualAreaIntegals mutualAreaIntegals;

        MegaIntegral.Func func1;
        MegaIntegral.Func func2;

        public Lab4Form()
        {
            InitializeComponent();
            func1 = Math.Sin;
            func2 = Math.Sin;
        }



        private void ReDrawGraph(object sender, EventArgs e)
        {
            bool bottom_flag1 = double.TryParse(f1_bottomBox.Text, out double bottom1);
            bool top_flag1 = double.TryParse(f1_topBox.Text, out double top1);
            bool step_flag1 = double.TryParse(f1_stepBox.Text, out double step1);

            bool bottom_flag2 = double.TryParse(f2_bottomBox.Text, out double bottom2);
            bool top_flag2 = double.TryParse(f2_topBox.Text, out double top2);
            bool step_flag2 = double.TryParse(f2_stepBox.Text, out double step2);

            if (bottom_flag1 && top_flag1 && step_flag1 &&
                bottom_flag2 && top_flag2 && step_flag2)
            {

                integral1 = new MegaIntegral(ref chart1, "Функция (1)", func1, bottom1, top1, step1);

                integral1.DrawFunc();

                integral2 = new MegaIntegral(ref chart1, "Функция (2)", func2, bottom2, top2, step2);

                integral2.DrawFunc();

                if (integral1Area == null)
                {
                    integral1Area = new MegaIntegral(ref chart1, "Вычисляемая Площадь (1)", func1, bottom1, top1, step1);
                }
                else
                {
                    integral1Area.Function = func1;
                    integral1Area.Bottom = bottom1;
                    integral1Area.Top = top1;
                    integral1Area.Step = step1;
                }

                integral1Area.DrawFunc();

                if (integral2Area == null)
                {
                    integral2Area = new MegaIntegral(ref chart1, "Вычисляемая Площадь (2)", func2, bottom2, top2, step2);
                }
                else
                {
                    integral2Area.Function = func2;
                    integral2Area.Bottom = bottom2;
                    integral2Area.Top = top2;
                    integral2Area.Step = step2;
                }

                integral2Area.DrawFunc();

                mutualAreaIntegals = new MutualAreaIntegals(ref chart1,
                    "Общая площадь (1)", func1,
                    "Общая площадь (2)", func2,
                    bottom1, top1, step1,
                    bottom2, top2, step2);

                mutualAreaIntegals.DrawMutualArea();

                label7.Text = string.Format("Интеграл (1) = {0:0.00000}", integral1Area.CalcArea());
                label8.Text = string.Format("Интеграл (2) = {0:0.00000}", integral2Area.CalcArea());
                label9.Text = string.Format("Сумма = {0:0.00000}", integral1Area.CalcArea() + integral2Area.CalcArea());
                label10.Text = string.Format("Разность (1-2) = {0:0.00000}", integral1Area.CalcArea() - integral2Area.CalcArea());
                label11.Text = string.Format("Разность (2-1) = {0:0.00000}", integral2Area.CalcArea() - integral1.CalcArea());
            }
        }

        private double Pow2(double x) => Math.Pow(x, 2);
        private double Pow3(double x) => Math.Pow(x, 3);

        #region Выбор первой функции

        private void F1sin_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            func1 = Math.Sin;
            ReDrawGraph(sender, e);
        }

        private void F1cos_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            func1 = Math.Cos;
            ReDrawGraph(sender, e);
        }

        private void F1abs_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            func1 = Math.Abs;
            ReDrawGraph(sender, e);
        }

        private void F1exp_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            func1 = Math.Exp;
            ReDrawGraph(sender, e);
        }

        private void F1pow2_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            func1 = Pow2;
            ReDrawGraph(sender, e);
        }

        private void F1pow3_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            func1 = Pow3;
            ReDrawGraph(sender, e);
        }
        #endregion

        #region Выбор второй функции

        private void F2sin_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            func2 = Math.Sin;
            ReDrawGraph(sender, e);
        }

        private void F2cos_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            func2 = Math.Cos;
            ReDrawGraph(sender, e);
        }

        private void F2abs_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            func2 = Math.Abs;
            ReDrawGraph(sender, e);
        }

        private void F2exp_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            func2 = Math.Exp;
            ReDrawGraph(sender, e);
        }

        private void F2pow2_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            func2 = Pow2;
            ReDrawGraph(sender, e);
        }

        private void F2pow3_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            func2 = Pow3;
            ReDrawGraph(sender, e);
        }

        #endregion

        #region Выбор площади первой функции

        private void F1trMod_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (integral1Area != null)
            {
                integral1Area.SetModTRAPEZOID_METHOD();
                ReDrawGraph(sender, e);

            }
        }

        private void F1lrMod_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (integral1Area != null)
            {
                integral1Area.SetModLEFT_RECTANGLE_METHOD();
                ReDrawGraph(sender, e);
            }
        }

        private void F1rrMod_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (integral1Area != null)
            {
                integral1Area.SetModRIGHT_RECTANGLE_METHOD();
                ReDrawGraph(sender, e);
            }
        }

        private void F1mrMod_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (integral1Area != null)
            {
                integral1Area.SetModMIDDLE_RECTANGLE_METHOD();
                ReDrawGraph(sender, e);
            }
        }

        #endregion

        #region Выбор площади второй функции

        private void F2trMod_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (integral2Area != null)
            {
                integral2Area.SetModTRAPEZOID_METHOD();
                ReDrawGraph(sender, e);

            }
        }

        private void F2lrMod_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (integral2Area != null)
            {
                integral2Area.SetModLEFT_RECTANGLE_METHOD();
                ReDrawGraph(sender, e);

            }
        }

        private void F2rrMod_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (integral2Area != null)
            {
                integral2Area.SetModRIGHT_RECTANGLE_METHOD();
                ReDrawGraph(sender, e);

            }
        }

        private void F2mrMod_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (integral2Area != null)
            {
                integral2Area.SetModMIDDLE_RECTANGLE_METHOD();
                ReDrawGraph(sender, e);

            }
        }

        #endregion
    }
}
