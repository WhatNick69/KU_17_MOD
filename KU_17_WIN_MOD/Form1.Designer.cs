﻿namespace KU_17_WIN_MOD
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonBrute = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OnlyFirstData = new System.Windows.Forms.CheckBox();
            this.OnlyTime = new System.Windows.Forms.CheckBox();
            this.buttonDPLL = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonGreedy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFormula = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelNumTrue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNumComb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBoxRes = new System.Windows.Forms.RichTextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelNumChars = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrute
            // 
            this.buttonBrute.Location = new System.Drawing.Point(510, 19);
            this.buttonBrute.Name = "buttonBrute";
            this.buttonBrute.Size = new System.Drawing.Size(137, 26);
            this.buttonBrute.TabIndex = 0;
            this.buttonBrute.Text = "Алгоритм перебора";
            this.buttonBrute.UseVisualStyleBackColor = true;
            this.buttonBrute.Click += new System.EventHandler(this.buttonBrute_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OnlyFirstData);
            this.groupBox1.Controls.Add(this.OnlyTime);
            this.groupBox1.Controls.Add(this.buttonDPLL);
            this.groupBox1.Controls.Add(this.buttonRandom);
            this.groupBox1.Controls.Add(this.buttonGreedy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxFormula);
            this.groupBox1.Controls.Add(this.buttonBrute);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            // 
            // OnlyFirstData
            // 
            this.OnlyFirstData.AutoSize = true;
            this.OnlyFirstData.Location = new System.Drawing.Point(15, 98);
            this.OnlyFirstData.Name = "OnlyFirstData";
            this.OnlyFirstData.Size = new System.Drawing.Size(158, 17);
            this.OnlyFirstData.TabIndex = 10;
            this.OnlyFirstData.Text = "только Первый ресультат";
            this.OnlyFirstData.UseVisualStyleBackColor = true;
            // 
            // OnlyTime
            // 
            this.OnlyTime.AutoSize = true;
            this.OnlyTime.Location = new System.Drawing.Point(15, 121);
            this.OnlyTime.Name = "OnlyTime";
            this.OnlyTime.Size = new System.Drawing.Size(170, 17);
            this.OnlyTime.TabIndex = 9;
            this.OnlyTime.Text = "только время и комбинации";
            this.OnlyTime.UseVisualStyleBackColor = true;
            // 
            // buttonDPLL
            // 
            this.buttonDPLL.Location = new System.Drawing.Point(510, 115);
            this.buttonDPLL.Name = "buttonDPLL";
            this.buttonDPLL.Size = new System.Drawing.Size(137, 26);
            this.buttonDPLL.TabIndex = 8;
            this.buttonDPLL.Text = "DPLL";
            this.buttonDPLL.UseVisualStyleBackColor = true;
            this.buttonDPLL.Click += new System.EventHandler(this.buttonDPLL_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(510, 83);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(137, 26);
            this.buttonRandom.TabIndex = 7;
            this.buttonRandom.Text = "Random алгоритм";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonGreedy
            // 
            this.buttonGreedy.Location = new System.Drawing.Point(510, 51);
            this.buttonGreedy.Name = "buttonGreedy";
            this.buttonGreedy.Size = new System.Drawing.Size(137, 26);
            this.buttonGreedy.TabIndex = 6;
            this.buttonGreedy.Text = "Жадный алгоритм";
            this.buttonGreedy.UseVisualStyleBackColor = true;
            this.buttonGreedy.Click += new System.EventHandler(this.buttonGreedy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Формула:";
            // 
            // textBoxFormula
            // 
            this.textBoxFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFormula.Location = new System.Drawing.Point(108, 19);
            this.textBoxFormula.Name = "textBoxFormula";
            this.textBoxFormula.Size = new System.Drawing.Size(396, 26);
            this.textBoxFormula.TabIndex = 0;
            this.textBoxFormula.Text = "b | a & b & -c | d & a";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelNumTrue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelNumComb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.richTextBoxRes);
            this.groupBox2.Controls.Add(this.labelTime);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.LabelNumChars);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 205);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // labelNumTrue
            // 
            this.labelNumTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumTrue.Location = new System.Drawing.Point(585, 56);
            this.labelNumTrue.Name = "labelNumTrue";
            this.labelNumTrue.Size = new System.Drawing.Size(64, 20);
            this.labelNumTrue.TabIndex = 8;
            this.labelNumTrue.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(304, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Количество истинных результатов:";
            // 
            // labelNumComb
            // 
            this.labelNumComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumComb.Location = new System.Drawing.Point(585, 26);
            this.labelNumComb.Name = "labelNumComb";
            this.labelNumComb.Size = new System.Drawing.Size(64, 20);
            this.labelNumComb.TabIndex = 6;
            this.labelNumComb.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(424, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Кол-во комбинаций:";
            // 
            // richTextBoxRes
            // 
            this.richTextBoxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxRes.Location = new System.Drawing.Point(34, 97);
            this.richTextBoxRes.Name = "richTextBoxRes";
            this.richTextBoxRes.ReadOnly = true;
            this.richTextBoxRes.Size = new System.Drawing.Size(613, 108);
            this.richTextBoxRes.TabIndex = 4;
            this.richTextBoxRes.Text = "";
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(174, 56);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(122, 20);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Время в секундах:";
            // 
            // LabelNumChars
            // 
            this.LabelNumChars.AutoSize = true;
            this.LabelNumChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumChars.Location = new System.Drawing.Point(174, 26);
            this.LabelNumChars.Name = "LabelNumChars";
            this.LabelNumChars.Size = new System.Drawing.Size(18, 20);
            this.LabelNumChars.TabIndex = 1;
            this.LabelNumChars.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число переменных:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(639, 395);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Beta";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(718, 73);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(461, 339);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(839, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "All test!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(718, 462);
            this.progressBar1.MarqueeAnimationSpeed = 80;
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(461, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(718, 433);
            this.progressBar2.Maximum = 50;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(461, 23);
            this.progressBar2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1205, 497);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAT-Solver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFormula;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxRes;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelNumChars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumTrue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNumComb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonDPLL;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonGreedy;
        private System.Windows.Forms.CheckBox OnlyFirstData;
        private System.Windows.Forms.CheckBox OnlyTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}

