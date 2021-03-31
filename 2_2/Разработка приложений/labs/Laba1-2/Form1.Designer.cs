
namespace Laba1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MiddleRectangle_radioButton = new System.Windows.Forms.RadioButton();
            this.RightRectangle_radioButton = new System.Windows.Forms.RadioButton();
            this.LeftRectangle_radioButton = new System.Windows.Forms.RadioButton();
            this.Trapeze_radioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.a_textBox = new System.Windows.Forms.TextBox();
            this.b_textBox = new System.Windows.Forms.TextBox();
            this.step_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.start_button = new System.Windows.Forms.Button();
            this.upper_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lower_textBox = new System.Windows.Forms.TextBox();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MiddleRectangle_radioButton
            // 
            this.MiddleRectangle_radioButton.AutoSize = true;
            this.MiddleRectangle_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleRectangle_radioButton.Location = new System.Drawing.Point(4, 95);
            this.MiddleRectangle_radioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MiddleRectangle_radioButton.Name = "MiddleRectangle_radioButton";
            this.MiddleRectangle_radioButton.Size = new System.Drawing.Size(243, 21);
            this.MiddleRectangle_radioButton.TabIndex = 3;
            this.MiddleRectangle_radioButton.Text = "Метод средних прямоугольников";
            this.MiddleRectangle_radioButton.UseVisualStyleBackColor = true;
            // 
            // RightRectangle_radioButton
            // 
            this.RightRectangle_radioButton.AutoSize = true;
            this.RightRectangle_radioButton.Checked = true;
            this.RightRectangle_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightRectangle_radioButton.Location = new System.Drawing.Point(4, 28);
            this.RightRectangle_radioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RightRectangle_radioButton.Name = "RightRectangle_radioButton";
            this.RightRectangle_radioButton.Size = new System.Drawing.Size(237, 21);
            this.RightRectangle_radioButton.TabIndex = 2;
            this.RightRectangle_radioButton.TabStop = true;
            this.RightRectangle_radioButton.Text = "Метод правых прямоугольников";
            this.RightRectangle_radioButton.UseVisualStyleBackColor = true;
            this.RightRectangle_radioButton.CheckedChanged += new System.EventHandler(this.RightRectangle_radioButton_CheckedChanged);
            // 
            // LeftRectangle_radioButton
            // 
            this.LeftRectangle_radioButton.AutoSize = true;
            this.LeftRectangle_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftRectangle_radioButton.Location = new System.Drawing.Point(4, 60);
            this.LeftRectangle_radioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LeftRectangle_radioButton.Name = "LeftRectangle_radioButton";
            this.LeftRectangle_radioButton.Size = new System.Drawing.Size(229, 21);
            this.LeftRectangle_radioButton.TabIndex = 1;
            this.LeftRectangle_radioButton.Text = "Метод левых прямоугольников";
            this.LeftRectangle_radioButton.UseVisualStyleBackColor = true;
            // 
            // Trapeze_radioButton
            // 
            this.Trapeze_radioButton.AutoSize = true;
            this.Trapeze_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Trapeze_radioButton.Location = new System.Drawing.Point(4, 136);
            this.Trapeze_radioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Trapeze_radioButton.Name = "Trapeze_radioButton";
            this.Trapeze_radioButton.Size = new System.Drawing.Size(135, 21);
            this.Trapeze_radioButton.TabIndex = 0;
            this.Trapeze_radioButton.Text = "Метод трапеций";
            this.Trapeze_radioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нижняя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Верхняя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Шаг:";
            // 
            // a_textBox
            // 
            this.a_textBox.BackColor = System.Drawing.Color.White;
            this.a_textBox.Location = new System.Drawing.Point(4, 41);
            this.a_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.a_textBox.Name = "a_textBox";
            this.a_textBox.Size = new System.Drawing.Size(48, 20);
            this.a_textBox.TabIndex = 3;
            // 
            // b_textBox
            // 
            this.b_textBox.BackColor = System.Drawing.Color.White;
            this.b_textBox.Location = new System.Drawing.Point(94, 41);
            this.b_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_textBox.Name = "b_textBox";
            this.b_textBox.Size = new System.Drawing.Size(48, 20);
            this.b_textBox.TabIndex = 4;
            // 
            // step_textBox
            // 
            this.step_textBox.BackColor = System.Drawing.Color.White;
            this.step_textBox.Location = new System.Drawing.Point(185, 41);
            this.step_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.step_textBox.Name = "step_textBox";
            this.step_textBox.Size = new System.Drawing.Size(48, 20);
            this.step_textBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(38, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Функция:";
            // 
            // chart1
            // 
            chartArea3.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(335, 104);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series5.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkUpwardDiagonal;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series5.Color = System.Drawing.Color.LightSkyBlue;
            series5.LegendText = "Площадь";
            series5.Name = "Series2";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Yellow;
            series6.LegendText = "Функция";
            series6.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(571, 363);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.Silver;
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start_button.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_button.Location = new System.Drawing.Point(139, 447);
            this.start_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(116, 32);
            this.start_button.TabIndex = 8;
            this.start_button.Text = "Посчитать";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // upper_textBox
            // 
            this.upper_textBox.BackColor = System.Drawing.Color.White;
            this.upper_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upper_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upper_textBox.Location = new System.Drawing.Point(233, 10);
            this.upper_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.upper_textBox.Name = "upper_textBox";
            this.upper_textBox.ReadOnly = true;
            this.upper_textBox.Size = new System.Drawing.Size(22, 12);
            this.upper_textBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lower_textBox
            // 
            this.lower_textBox.BackColor = System.Drawing.Color.White;
            this.lower_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lower_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lower_textBox.Location = new System.Drawing.Point(208, 87);
            this.lower_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lower_textBox.Name = "lower_textBox";
            this.lower_textBox.ReadOnly = true;
            this.lower_textBox.Size = new System.Drawing.Size(22, 12);
            this.lower_textBox.TabIndex = 2;
            // 
            // result_textBox
            // 
            this.result_textBox.BackColor = System.Drawing.Color.White;
            this.result_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_textBox.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_textBox.Location = new System.Drawing.Point(382, 38);
            this.result_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.ReadOnly = true;
            this.result_textBox.Size = new System.Drawing.Size(242, 22);
            this.result_textBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RightRectangle_radioButton);
            this.groupBox1.Controls.Add(this.LeftRectangle_radioButton);
            this.groupBox1.Controls.Add(this.Trapeze_radioButton);
            this.groupBox1.Controls.Add(this.MiddleRectangle_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(45, 158);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(286, 184);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.a_textBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.b_textBox);
            this.groupBox2.Controls.Add(this.step_textBox);
            this.groupBox2.Location = new System.Drawing.Point(45, 348);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(286, 81);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(235, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(908, 490);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.lower_textBox);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.upper_textBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Лаб.раб. 1-2";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton MiddleRectangle_radioButton;
        private System.Windows.Forms.RadioButton RightRectangle_radioButton;
        private System.Windows.Forms.RadioButton LeftRectangle_radioButton;
        private System.Windows.Forms.RadioButton Trapeze_radioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox a_textBox;
        private System.Windows.Forms.TextBox b_textBox;
        private System.Windows.Forms.TextBox step_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.TextBox upper_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lower_textBox;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

