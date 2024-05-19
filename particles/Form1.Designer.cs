namespace particles
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
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.x1 = new System.Windows.Forms.TrackBar();
            this.y1 = new System.Windows.Forms.TrackBar();
            this.x2 = new System.Windows.Forms.TrackBar();
            this.y2 = new System.Windows.Forms.TrackBar();
            this.s1 = new System.Windows.Forms.TrackBar();
            this.s2 = new System.Windows.Forms.TrackBar();
            this.x3 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.y3 = new System.Windows.Forms.TrackBar();
            this.s3 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 18);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(1041, 642);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // x1
            // 
            this.x1.AccessibleDescription = "";
            this.x1.AccessibleName = "";
            this.x1.Location = new System.Drawing.Point(1118, 34);
            this.x1.Maximum = 1040;
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(205, 45);
            this.x1.TabIndex = 1;
            this.x1.Value = 260;
            this.x1.Scroll += new System.EventHandler(this.x1_Scroll);
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(1118, 85);
            this.y1.Maximum = 641;
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(205, 45);
            this.y1.TabIndex = 2;
            this.y1.Value = 321;
            this.y1.Scroll += new System.EventHandler(this.y1_Scroll);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(1118, 199);
            this.x2.Maximum = 1040;
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(205, 45);
            this.x2.TabIndex = 3;
            this.x2.Value = 420;
            this.x2.Scroll += new System.EventHandler(this.x2_Scroll);
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(1118, 250);
            this.y2.Maximum = 641;
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(205, 45);
            this.y2.TabIndex = 4;
            this.y2.Value = 321;
            this.y2.Scroll += new System.EventHandler(this.y2_Scroll);
            // 
            // s1
            // 
            this.s1.Location = new System.Drawing.Point(1118, 135);
            this.s1.Maximum = 600;
            this.s1.Minimum = 4;
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(205, 45);
            this.s1.TabIndex = 5;
            this.s1.Value = 100;
            this.s1.Scroll += new System.EventHandler(this.s1_Scroll);
            // 
            // s2
            // 
            this.s2.Location = new System.Drawing.Point(1118, 301);
            this.s2.Maximum = 600;
            this.s2.Minimum = 4;
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(205, 45);
            this.s2.TabIndex = 6;
            this.s2.Value = 100;
            this.s2.Scroll += new System.EventHandler(this.s2_Scroll);
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(1118, 375);
            this.x3.Maximum = 1040;
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(205, 45);
            this.x3.TabIndex = 7;
            this.x3.Value = 781;
            this.x3.Scroll += new System.EventHandler(this.x3_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1205, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Область 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1205, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Область 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1205, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Область 3";
            // 
            // y3
            // 
            this.y3.Location = new System.Drawing.Point(1118, 426);
            this.y3.Maximum = 641;
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(205, 45);
            this.y3.TabIndex = 11;
            this.y3.Value = 321;
            this.y3.Scroll += new System.EventHandler(this.y3_Scroll);
            // 
            // s3
            // 
            this.s3.Location = new System.Drawing.Point(1118, 477);
            this.s3.Maximum = 600;
            this.s3.Minimum = 4;
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(205, 45);
            this.s3.TabIndex = 12;
            this.s3.Value = 100;
            this.s3.Scroll += new System.EventHandler(this.s3_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1098, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1098, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1085, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(1101, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(1101, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(1088, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Size";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(1098, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(1098, 426);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(1088, 477);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Size";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Location = new System.Drawing.Point(1169, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Изменить цвета";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1118, 580);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(205, 45);
            this.trackBar1.TabIndex = 24;
            this.trackBar1.Value = 30;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(1166, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Рассеянность потока";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(1118, 631);
            this.trackBar2.Maximum = 50;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(205, 45);
            this.trackBar2.TabIndex = 26;
            this.trackBar2.Value = 5;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(1169, 612);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Размер частиц";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(1059, 532);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Антигравитон";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox2.Location = new System.Drawing.Point(1059, 556);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 17);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "Гравитация";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1335, 666);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.s3);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar x1;
        private System.Windows.Forms.TrackBar y1;
        private System.Windows.Forms.TrackBar x2;
        private System.Windows.Forms.TrackBar y2;
        private System.Windows.Forms.TrackBar s1;
        private System.Windows.Forms.TrackBar s2;
        private System.Windows.Forms.TrackBar x3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar y3;
        private System.Windows.Forms.TrackBar s3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

