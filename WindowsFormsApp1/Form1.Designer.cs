﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.button21 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Graph = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Filters = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.rDivisorTb = new System.Windows.Forms.TextBox();
            this.bDivisorTb = new System.Windows.Forms.TextBox();
            this.gDivisorTb = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Drawing = new System.Windows.Forms.TabPage();
            this.canvasPb = new System.Windows.Forms.PictureBox();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.Graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Drawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPb)).BeginInit();
            this.SuspendLayout();
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(1350, 44);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(211, 38);
            this.button21.TabIndex = 19;
            this.button21.Text = "Clear canvas";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Midpoint Line Algorithm",
            "Midpoint Circle Algorith",
            "Xiaolin Wu Line Aliasing",
            "Xiaolin Wu Circle Aliasing",
            "Midpoint Line Algorithm with set thickness",
            "Supersampling"});
            this.comboBox4.Location = new System.Drawing.Point(1350, 128);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(211, 24);
            this.comboBox4.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1350, 176);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1347, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Set thickness";
            // 
            // Graph
            // 
            this.Graph.Controls.Add(this.button13);
            this.Graph.Controls.Add(this.button4);
            this.Graph.Controls.Add(this.label4);
            this.Graph.Controls.Add(this.label3);
            this.Graph.Controls.Add(this.textBox2);
            this.Graph.Controls.Add(this.textBox1);
            this.Graph.Controls.Add(this.button12);
            this.Graph.Controls.Add(this.button11);
            this.Graph.Controls.Add(this.button5);
            this.Graph.Controls.Add(this.button3);
            this.Graph.Controls.Add(this.button2);
            this.Graph.Controls.Add(this.chart1);
            this.Graph.Controls.Add(this.pictureBox3);
            this.Graph.Location = new System.Drawing.Point(4, 25);
            this.Graph.Name = "Graph";
            this.Graph.Padding = new System.Windows.Forms.Padding(3);
            this.Graph.Size = new System.Drawing.Size(1302, 646);
            this.Graph.TabIndex = 1;
            this.Graph.Text = "Graph";
            this.Graph.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Enabled = false;
            this.button13.Location = new System.Drawing.Point(290, 855);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(259, 33);
            this.button13.TabIndex = 28;
            this.button13.Text = "Delete point";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(290, 929);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(259, 70);
            this.button4.TabIndex = 26;
            this.button4.Text = "Apply filter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 826);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Y-Axis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 826);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "X-Axis";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 860);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 22);
            this.textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 860);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 22);
            this.textBox1.TabIndex = 22;
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Location = new System.Drawing.Point(116, 855);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(150, 33);
            this.button12.TabIndex = 21;
            this.button12.Text = "Add point";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(7, 892);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(259, 33);
            this.button11.TabIndex = 20;
            this.button11.Text = "Apply changes";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(7, 929);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(259, 33);
            this.button5.TabIndex = 19;
            this.button5.Text = "Edit chart";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 966);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 33);
            this.button3.TabIndex = 18;
            this.button3.Text = "Clear chart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 966);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Generate Chart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 6);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1769, 777);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            this.chart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.singapur2;
            this.pictureBox3.Location = new System.Drawing.Point(669, 860);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(478, 149);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // Filters
            // 
            this.Filters.Controls.Add(this.label11);
            this.Filters.Controls.Add(this.comboBox3);
            this.Filters.Controls.Add(this.textBox4);
            this.Filters.Controls.Add(this.rDivisorTb);
            this.Filters.Controls.Add(this.bDivisorTb);
            this.Filters.Controls.Add(this.gDivisorTb);
            this.Filters.Controls.Add(this.textBox3);
            this.Filters.Controls.Add(this.label10);
            this.Filters.Controls.Add(this.button20);
            this.Filters.Controls.Add(this.label9);
            this.Filters.Controls.Add(this.label8);
            this.Filters.Controls.Add(this.label7);
            this.Filters.Controls.Add(this.button19);
            this.Filters.Controls.Add(this.button18);
            this.Filters.Controls.Add(this.label6);
            this.Filters.Controls.Add(this.comboBox2);
            this.Filters.Controls.Add(this.button17);
            this.Filters.Controls.Add(this.button16);
            this.Filters.Controls.Add(this.button15);
            this.Filters.Controls.Add(this.label5);
            this.Filters.Controls.Add(this.button14);
            this.Filters.Controls.Add(this.label1);
            this.Filters.Controls.Add(this.button9);
            this.Filters.Controls.Add(this.comboBox1);
            this.Filters.Controls.Add(this.button10);
            this.Filters.Controls.Add(this.button1);
            this.Filters.Controls.Add(this.label2);
            this.Filters.Controls.Add(this.button6);
            this.Filters.Controls.Add(this.button7);
            this.Filters.Controls.Add(this.button8);
            this.Filters.Controls.Add(this.pictureBox1);
            this.Filters.Controls.Add(this.pictureBox2);
            this.Filters.Location = new System.Drawing.Point(4, 25);
            this.Filters.Name = "Filters";
            this.Filters.Padding = new System.Windows.Forms.Padding(3);
            this.Filters.Size = new System.Drawing.Size(1302, 646);
            this.Filters.TabIndex = 0;
            this.Filters.Text = "Filters";
            this.Filters.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(782, 619);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "Set dither matrix";
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox3.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "6"});
            this.comboBox3.Location = new System.Drawing.Point(785, 639);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(192, 24);
            this.comboBox3.TabIndex = 36;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(425, 803);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 22);
            this.textBox4.TabIndex = 35;
            // 
            // rDivisorTb
            // 
            this.rDivisorTb.Location = new System.Drawing.Point(422, 740);
            this.rDivisorTb.Name = "rDivisorTb";
            this.rDivisorTb.Size = new System.Drawing.Size(42, 22);
            this.rDivisorTb.TabIndex = 28;
            // 
            // bDivisorTb
            // 
            this.bDivisorTb.Location = new System.Drawing.Point(515, 740);
            this.bDivisorTb.Name = "bDivisorTb";
            this.bDivisorTb.Size = new System.Drawing.Size(37, 22);
            this.bDivisorTb.TabIndex = 27;
            // 
            // gDivisorTb
            // 
            this.gDivisorTb.Location = new System.Drawing.Point(470, 740);
            this.gDivisorTb.Name = "gDivisorTb";
            this.gDivisorTb.Size = new System.Drawing.Size(39, 22);
            this.gDivisorTb.TabIndex = 26;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(422, 639);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 22);
            this.textBox3.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 782);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Number of Colors";
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(571, 790);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(192, 35);
            this.button20.TabIndex = 32;
            this.button20.Text = "Median Cut Quantization";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(515, 720);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "B div";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 720);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "G div";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 720);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "R div";
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(571, 734);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(192, 35);
            this.button19.TabIndex = 25;
            this.button19.Text = "Uniform Color Quantization";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(571, 633);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(192, 35);
            this.button18.TabIndex = 24;
            this.button18.Text = "Ordered dithering";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 670);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Number of gray levels";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox2.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"});
            this.comboBox2.Location = new System.Drawing.Point(422, 689);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(130, 24);
            this.comboBox2.TabIndex = 22;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(571, 683);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(192, 35);
            this.button17.TabIndex = 21;
            this.button17.Text = "Random dithering";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(17, 773);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(192, 35);
            this.button16.TabIndex = 20;
            this.button16.Text = "Average dithering";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(215, 733);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(192, 33);
            this.button15.TabIndex = 19;
            this.button15.Text = "Set new picture";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 619);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Set value of gamma";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(215, 773);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(192, 35);
            this.button14.TabIndex = 16;
            this.button14.Text = "Gamma corecction";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Original image";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(215, 680);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(192, 33);
            this.button9.TabIndex = 1;
            this.button9.Text = "Apply convolution filter";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Items.AddRange(new object[] {
            "Blur",
            "Gaussisan smoothing",
            "Sharpener",
            "Mean Removal",
            "Edge detectection",
            "Emobss"});
            this.comboBox1.Location = new System.Drawing.Point(17, 685);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(17, 734);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 33);
            this.button10.TabIndex = 14;
            this.button10.Text = "Clear";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 734);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Grayscale";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1301, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Processed image";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 635);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 33);
            this.button6.TabIndex = 7;
            this.button6.Text = "inverse";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(119, 635);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(186, 33);
            this.button7.TabIndex = 8;
            this.button7.Text = "brightness correction";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(311, 635);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(96, 33);
            this.button8.TabIndex = 9;
            this.button8.Text = "contrast";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(855, 557);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(889, 49);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(855, 557);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Drawing);
            this.tabControl1.Controls.Add(this.Filters);
            this.tabControl1.Controls.Add(this.Graph);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1310, 675);
            this.tabControl1.TabIndex = 18;
            // 
            // Drawing
            // 
            this.Drawing.Controls.Add(this.canvasPb);
            this.Drawing.Location = new System.Drawing.Point(4, 25);
            this.Drawing.Name = "Drawing";
            this.Drawing.Padding = new System.Windows.Forms.Padding(3);
            this.Drawing.Size = new System.Drawing.Size(1302, 646);
            this.Drawing.TabIndex = 2;
            this.Drawing.Text = "Drawing";
            this.Drawing.UseVisualStyleBackColor = true;
            // 
            // canvasPb
            // 
            this.canvasPb.BackColor = System.Drawing.Color.Turquoise;
            this.canvasPb.Location = new System.Drawing.Point(7, 7);
            this.canvasPb.Name = "canvasPb";
            this.canvasPb.Size = new System.Drawing.Size(1298, 639);
            this.canvasPb.TabIndex = 1;
            this.canvasPb.TabStop = false;
            this.canvasPb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            // 
            // button22
            // 
            this.button22.Enabled = false;
            this.button22.Location = new System.Drawing.Point(1350, 228);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(211, 37);
            this.button22.TabIndex = 3;
            this.button22.Text = "Perform Clipping";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(1350, 294);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(211, 37);
            this.button23.TabIndex = 23;
            this.button23.Text = "Generate Clip";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(1350, 368);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(211, 37);
            this.button24.TabIndex = 24;
            this.button24.Text = "Enter draw polygon mode";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(1350, 432);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(211, 37);
            this.button25.TabIndex = 25;
            this.button25.Text = "Generate polygon";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(1350, 495);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(211, 37);
            this.button26.TabIndex = 26;
            this.button26.Text = "Fill polygon";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 703);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Graph.ResumeLayout(false);
            this.Graph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Filters.ResumeLayout(false);
            this.Filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Drawing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvasPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage Graph;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage Filters;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox rDivisorTb;
        private System.Windows.Forms.TextBox bDivisorTb;
        private System.Windows.Forms.TextBox gDivisorTb;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.TabPage Drawing;
        private System.Windows.Forms.PictureBox canvasPb;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
    }
}

