
namespace Lab6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.roundCheckBox = new System.Windows.Forms.CheckBox();
            this.resultLable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.delayNumInput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.animCheckBox = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.accuracyInput = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.endInput = new System.Windows.Forms.TextBox();
            this.startInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NewtonRadioButton = new System.Windows.Forms.RadioButton();
            this.iterRadioButton = new System.Windows.Forms.RadioButton();
            this.halfDivRadioButton = new System.Windows.Forms.RadioButton();
            this.roundNumInput = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayNumInput)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundNumInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundCheckBox
            // 
            this.roundCheckBox.AutoSize = true;
            this.roundCheckBox.Location = new System.Drawing.Point(554, 418);
            this.roundCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundCheckBox.Name = "roundCheckBox";
            this.roundCheckBox.Size = new System.Drawing.Size(94, 17);
            this.roundCheckBox.TabIndex = 29;
            this.roundCheckBox.Text = "Округлять до";
            this.roundCheckBox.UseVisualStyleBackColor = true;
            // 
            // resultLable
            // 
            this.resultLable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.resultLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLable.Location = new System.Drawing.Point(302, 365);
            this.resultLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(105, 31);
            this.resultLable.TabIndex = 26;
            this.resultLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(194, 365);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Результат:";
            // 
            // chart
            // 
            this.chart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea5.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea5);
            legend5.Alignment = System.Drawing.StringAlignment.Center;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            legend5.TextWrapThreshold = 60;
            legend5.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.chart.Legends.Add(legend5);
            this.chart.Location = new System.Drawing.Point(187, 2);
            this.chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart.Name = "chart";
            this.chart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.Red;
            series9.Legend = "Legend1";
            series9.LegendText = "Функция()";
            series9.Name = "Function";
            series10.ChartArea = "ChartArea1";
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series10.IsVisibleInLegend = false;
            series10.LabelBorderWidth = 2;
            series10.Legend = "Legend1";
            series10.Name = "Series2";
            this.chart.Series.Add(series9);
            this.chart.Series.Add(series10);
            this.chart.Size = new System.Drawing.Size(580, 361);
            this.chart.TabIndex = 24;
            this.chart.Tag = "";
            this.chart.Text = "chart";
            // 
            // delayNumInput
            // 
            this.delayNumInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delayNumInput.Location = new System.Drawing.Point(73, 310);
            this.delayNumInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delayNumInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.delayNumInput.Name = "delayNumInput";
            this.delayNumInput.Size = new System.Drawing.Size(65, 21);
            this.delayNumInput.TabIndex = 23;
            this.delayNumInput.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Задержка";
            // 
            // animCheckBox
            // 
            this.animCheckBox.AutoSize = true;
            this.animCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animCheckBox.Location = new System.Drawing.Point(9, 286);
            this.animCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.animCheckBox.Name = "animCheckBox";
            this.animCheckBox.Size = new System.Drawing.Size(155, 19);
            this.animCheckBox.TabIndex = 21;
            this.animCheckBox.Text = "Анимировать процесс";
            this.animCheckBox.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.AutoSize = true;
            this.calculateButton.BackColor = System.Drawing.SystemColors.Info;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.calculateButton.Location = new System.Drawing.Point(8, 338);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(145, 40);
            this.calculateButton.TabIndex = 20;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // accuracyInput
            // 
            this.accuracyInput.Location = new System.Drawing.Point(5, 18);
            this.accuracyInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accuracyInput.Name = "accuracyInput";
            this.accuracyInput.Size = new System.Drawing.Size(141, 21);
            this.accuracyInput.TabIndex = 0;
            this.accuracyInput.Text = "0,001";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.accuracyInput);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(7, 150);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(150, 43);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Точность";
            // 
            // endInput
            // 
            this.endInput.Location = new System.Drawing.Point(77, 17);
            this.endInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endInput.Name = "endInput";
            this.endInput.Size = new System.Drawing.Size(57, 21);
            this.endInput.TabIndex = 6;
            this.endInput.Text = "10";
            // 
            // startInput
            // 
            this.startInput.Location = new System.Drawing.Point(15, 17);
            this.startInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startInput.Name = "startInput";
            this.startInput.Size = new System.Drawing.Size(57, 21);
            this.startInput.TabIndex = 5;
            this.startInput.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.endInput);
            this.groupBox2.Controls.Add(this.startInput);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(7, 101);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(150, 43);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Промежуток";
            // 
            // NewtonRadioButton
            // 
            this.NewtonRadioButton.AutoSize = true;
            this.NewtonRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewtonRadioButton.Location = new System.Drawing.Point(5, 63);
            this.NewtonRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewtonRadioButton.Name = "NewtonRadioButton";
            this.NewtonRadioButton.Size = new System.Drawing.Size(78, 19);
            this.NewtonRadioButton.TabIndex = 2;
            this.NewtonRadioButton.TabStop = true;
            this.NewtonRadioButton.Text = "Ньютона";
            this.NewtonRadioButton.UseVisualStyleBackColor = true;
            // 
            // iterRadioButton
            // 
            this.iterRadioButton.AutoSize = true;
            this.iterRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iterRadioButton.Location = new System.Drawing.Point(5, 41);
            this.iterRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iterRadioButton.Name = "iterRadioButton";
            this.iterRadioButton.Size = new System.Drawing.Size(83, 19);
            this.iterRadioButton.TabIndex = 1;
            this.iterRadioButton.TabStop = true;
            this.iterRadioButton.Text = "Итераций";
            this.iterRadioButton.UseVisualStyleBackColor = true;
            // 
            // halfDivRadioButton
            // 
            this.halfDivRadioButton.AutoSize = true;
            this.halfDivRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.halfDivRadioButton.Location = new System.Drawing.Point(5, 18);
            this.halfDivRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.halfDivRadioButton.Name = "halfDivRadioButton";
            this.halfDivRadioButton.Size = new System.Drawing.Size(154, 19);
            this.halfDivRadioButton.TabIndex = 0;
            this.halfDivRadioButton.TabStop = true;
            this.halfDivRadioButton.Text = "Половинного деления";
            this.halfDivRadioButton.UseVisualStyleBackColor = true;
            // 
            // roundNumInput
            // 
            this.roundNumInput.Location = new System.Drawing.Point(648, 418);
            this.roundNumInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundNumInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.roundNumInput.Name = "roundNumInput";
            this.roundNumInput.Size = new System.Drawing.Size(41, 20);
            this.roundNumInput.TabIndex = 28;
            this.roundNumInput.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewtonRadioButton);
            this.groupBox1.Controls.Add(this.iterRadioButton);
            this.groupBox1.Controls.Add(this.halfDivRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(7, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 85);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод нахождения";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 50);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(776, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roundCheckBox);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.delayNumInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.animCheckBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.roundNumInput);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Лабораторная 5-6";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayNumInput)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundNumInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox roundCheckBox;
        private System.Windows.Forms.Label resultLable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.NumericUpDown delayNumInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox animCheckBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox accuracyInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox endInput;
        private System.Windows.Forms.TextBox startInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton NewtonRadioButton;
        private System.Windows.Forms.RadioButton iterRadioButton;
        private System.Windows.Forms.RadioButton halfDivRadioButton;
        private System.Windows.Forms.NumericUpDown roundNumInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

