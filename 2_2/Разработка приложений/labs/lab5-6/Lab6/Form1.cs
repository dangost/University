using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Lab6
{
    public partial class Form1 : Form
    {
        Color color;
        Unit unit;
        private Dictionary<CheckBox, NumericUpDown> checkbox;
        private double start = 1, end = 3, accuracy, result;
        int iter;
        int timer;

        public double Start
        {
            get => start;
            set
            {
                if (value < End)
                    start = value;
                else
                {
                    startInput.Text = Start.ToString();
                    MessageBox.Show("Введите правильное значение");
                }
            }
        }
        public double End
        {
            get => end;
            set
            {
                if (value > Start)
                    end = value;
                else
                {
                    endInput.Text = End.ToString();
                }
            }
        }

        public double Accuracy
        {
            get => accuracy;
            set
            {
                if (value < 1 && value > 0)
                    accuracy = value;
                else
                {
                    accuracyInput.Text = Accuracy.ToString();
                    MessageBox.Show("Введите правильное значение");
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            checkbox = new Dictionary<CheckBox, NumericUpDown> { { animCheckBox, delayNumInput }, { roundCheckBox, roundNumInput } };
            ColorSelection frm2 = new ColorSelection();
            DialogResult dr = frm2.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                frm2.Close();
            }
            else if (dr == DialogResult.OK)
            {
                color = frm2.GetColor();
                chart.Series["Function"].Color = frm2.GetColor();
                frm2.Close();
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickCheckBox = sender as CheckBox;
            foreach (KeyValuePair<CheckBox, NumericUpDown> check in checkbox)
            {
                if (check.Key == clickCheckBox)
                {
                    check.Value.Enabled = check.Key.Checked;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<CheckBox, NumericUpDown> check in checkbox)
            {
                check.Value.Enabled = check.Key.Checked;
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            accuracy = 0.001;
            timer = 1;
            Accuracy = Convert.ToDouble(accuracyInput.Text);
            Start = Convert.ToDouble(startInput.Text);
            End = Convert.ToDouble(endInput.Text);
            chart.Series[1].Points.Clear();

            if (halfDivRadioButton.Checked)
            {
                unit = new HalfDivision(Start, End, Accuracy);
            }
            else if (NewtonRadioButton.Checked)
            {
                unit = new Newton(Start, End, Accuracy);
            }
            else
            {
                unit = new Iteration(Start, End, Accuracy);
            }
            if (animCheckBox.Checked)
            {
                timer = (int)delayNumInput.Value;
            }

            unit.BuildLine(chart);
            result = unit.Computation();
            unit.Drow(chart, timer);
            iter = unit.Iter;

            if (roundCheckBox.Checked)
            {
                result = Math.Round(result, (int)roundNumInput.Value);
            }

            chart.Series["Function"].LegendText = "Функция (" + iter + " итераций)                     x=" + result.ToString();
            resultLable.Text = "x=" + result.ToString();
        }
    }
}
