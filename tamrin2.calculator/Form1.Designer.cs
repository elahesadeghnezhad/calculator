namespace tamrin2.calculator
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_backspase = new System.Windows.Forms.Button();
            this.button_ln = new System.Windows.Forms.Button();
            this.button_log = new System.Windows.Forms.Button();
            this.button_sqrt = new System.Windows.Forms.Button();
            this.button_11 = new System.Windows.Forms.Button();
            this.button_10 = new System.Windows.Forms.Button();
            this.button_Power = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_Times = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_Equal = new System.Windows.Forms.Button();
            this.button_point = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.label_history = new System.Windows.Forms.Label();
            this.textBox_display = new System.Windows.Forms.TextBox();
            this.button_onoff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_clear);
            this.panel1.Controls.Add(this.button_backspase);
            this.panel1.Controls.Add(this.button_ln);
            this.panel1.Controls.Add(this.button_log);
            this.panel1.Controls.Add(this.button_sqrt);
            this.panel1.Controls.Add(this.button_11);
            this.panel1.Controls.Add(this.button_10);
            this.panel1.Controls.Add(this.button_Power);
            this.panel1.Controls.Add(this.button_plus);
            this.panel1.Controls.Add(this.button_minus);
            this.panel1.Controls.Add(this.button_Times);
            this.panel1.Controls.Add(this.button_divide);
            this.panel1.Controls.Add(this.button_Equal);
            this.panel1.Controls.Add(this.button_point);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(13, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 263);
            this.panel1.TabIndex = 0;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(193, 12);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(55, 36);
            this.button_clear.TabIndex = 23;
            this.button_clear.Text = "&C";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_backspase
            // 
            this.button_backspase.Location = new System.Drawing.Point(132, 12);
            this.button_backspase.Margin = new System.Windows.Forms.Padding(4);
            this.button_backspase.Name = "button_backspase";
            this.button_backspase.Size = new System.Drawing.Size(55, 36);
            this.button_backspase.TabIndex = 22;
            this.button_backspase.Text = "<---";
            this.button_backspase.UseVisualStyleBackColor = true;
            this.button_backspase.Click += new System.EventHandler(this.button_backspase_Click);
            // 
            // button_ln
            // 
            this.button_ln.Location = new System.Drawing.Point(71, 12);
            this.button_ln.Margin = new System.Windows.Forms.Padding(4);
            this.button_ln.Name = "button_ln";
            this.button_ln.Size = new System.Drawing.Size(55, 36);
            this.button_ln.TabIndex = 21;
            this.button_ln.Text = "ln(x)";
            this.button_ln.UseVisualStyleBackColor = true;
            this.button_ln.Click += new System.EventHandler(this.SmartOperators);
            // 
            // button_log
            // 
            this.button_log.Location = new System.Drawing.Point(10, 12);
            this.button_log.Margin = new System.Windows.Forms.Padding(4);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(55, 36);
            this.button_log.TabIndex = 20;
            this.button_log.Text = "log(x)";
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.SmartOperators);
            // 
            // button_sqrt
            // 
            this.button_sqrt.Location = new System.Drawing.Point(193, 52);
            this.button_sqrt.Margin = new System.Windows.Forms.Padding(4);
            this.button_sqrt.Name = "button_sqrt";
            this.button_sqrt.Size = new System.Drawing.Size(55, 36);
            this.button_sqrt.TabIndex = 19;
            this.button_sqrt.Text = "sqrt x";
            this.button_sqrt.UseVisualStyleBackColor = true;
            this.button_sqrt.Click += new System.EventHandler(this.SmartOperators);
            // 
            // button_11
            // 
            this.button_11.Location = new System.Drawing.Point(132, 52);
            this.button_11.Margin = new System.Windows.Forms.Padding(4);
            this.button_11.Name = "button_11";
            this.button_11.Size = new System.Drawing.Size(55, 36);
            this.button_11.TabIndex = 18;
            this.button_11.Text = "1/x";
            this.button_11.UseVisualStyleBackColor = true;
            this.button_11.Click += new System.EventHandler(this.SmartOperators);
            // 
            // button_10
            // 
            this.button_10.Location = new System.Drawing.Point(71, 52);
            this.button_10.Margin = new System.Windows.Forms.Padding(4);
            this.button_10.Name = "button_10";
            this.button_10.Size = new System.Drawing.Size(55, 36);
            this.button_10.TabIndex = 17;
            this.button_10.Text = "10^x";
            this.button_10.UseVisualStyleBackColor = true;
            this.button_10.Click += new System.EventHandler(this.SmartOperators);
            // 
            // button_Power
            // 
            this.button_Power.Location = new System.Drawing.Point(10, 52);
            this.button_Power.Margin = new System.Windows.Forms.Padding(4);
            this.button_Power.Name = "button_Power";
            this.button_Power.Size = new System.Drawing.Size(55, 36);
            this.button_Power.TabIndex = 16;
            this.button_Power.Text = "^";
            this.button_Power.UseVisualStyleBackColor = true;
            this.button_Power.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operators);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(193, 92);
            this.button_plus.Margin = new System.Windows.Forms.Padding(4);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(55, 36);
            this.button_plus.TabIndex = 15;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operators);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(193, 135);
            this.button_minus.Margin = new System.Windows.Forms.Padding(4);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(55, 36);
            this.button_minus.TabIndex = 14;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operators);
            // 
            // button_Times
            // 
            this.button_Times.Location = new System.Drawing.Point(193, 178);
            this.button_Times.Margin = new System.Windows.Forms.Padding(4);
            this.button_Times.Name = "button_Times";
            this.button_Times.Size = new System.Drawing.Size(55, 36);
            this.button_Times.TabIndex = 13;
            this.button_Times.Text = "*";
            this.button_Times.UseVisualStyleBackColor = true;
            this.button_Times.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operators);
            // 
            // button_divide
            // 
            this.button_divide.Location = new System.Drawing.Point(193, 220);
            this.button_divide.Margin = new System.Windows.Forms.Padding(4);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(55, 36);
            this.button_divide.TabIndex = 12;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operators);
            // 
            // button_Equal
            // 
            this.button_Equal.Location = new System.Drawing.Point(132, 220);
            this.button_Equal.Margin = new System.Windows.Forms.Padding(4);
            this.button_Equal.Name = "button_Equal";
            this.button_Equal.Size = new System.Drawing.Size(55, 36);
            this.button_Equal.TabIndex = 11;
            this.button_Equal.Text = "=";
            this.button_Equal.UseVisualStyleBackColor = true;
            this.button_Equal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Equal_Click);
            // 
            // button_point
            // 
            this.button_point.Location = new System.Drawing.Point(10, 220);
            this.button_point.Margin = new System.Windows.Forms.Padding(4);
            this.button_point.Name = "button_point";
            this.button_point.Size = new System.Drawing.Size(55, 36);
            this.button_point.TabIndex = 10;
            this.button_point.Text = ".";
            this.button_point.UseVisualStyleBackColor = true;
            this.button_point.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(132, 178);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(132, 92);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 36);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(71, 92);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 36);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(10, 92);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 36);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(132, 135);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 36);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(71, 135);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(10, 135);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(71, 178);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(10, 178);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button0.Location = new System.Drawing.Point(71, 220);
            this.button0.Margin = new System.Windows.Forms.Padding(4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(55, 36);
            this.button0.TabIndex = 0;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            // 
            // label_history
            // 
            this.label_history.AutoSize = true;
            this.label_history.Location = new System.Drawing.Point(19, 9);
            this.label_history.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_history.Name = "label_history";
            this.label_history.Size = new System.Drawing.Size(0, 16);
            this.label_history.TabIndex = 1;
            // 
            // textBox_display
            // 
            this.textBox_display.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_display.Location = new System.Drawing.Point(22, 42);
            this.textBox_display.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_display.Name = "textBox_display";
            this.textBox_display.ReadOnly = true;
            this.textBox_display.Size = new System.Drawing.Size(238, 22);
            this.textBox_display.TabIndex = 2;
            this.textBox_display.TextChanged += new System.EventHandler(this.textBox_display_TextChanged);
            // 
            // button_onoff
            // 
            this.button_onoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_onoff.ForeColor = System.Drawing.Color.White;
            this.button_onoff.Location = new System.Drawing.Point(145, 72);
            this.button_onoff.Margin = new System.Windows.Forms.Padding(4);
            this.button_onoff.Name = "button_onoff";
            this.button_onoff.Size = new System.Drawing.Size(116, 36);
            this.button_onoff.TabIndex = 3;
            this.button_onoff.Text = "on";
            this.button_onoff.UseVisualStyleBackColor = false;
            this.button_onoff.Click += new System.EventHandler(this.button_onoff_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 377);
            this.Controls.Add(this.button_onoff);
            this.Controls.Add(this.textBox_display);
            this.Controls.Add(this.label_history);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form1";
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numbers);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_Times;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_Equal;
        private System.Windows.Forms.Button button_point;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Label label_history;
        private System.Windows.Forms.TextBox textBox_display;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_backspase;
        private System.Windows.Forms.Button button_ln;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.Button button_sqrt;
        private System.Windows.Forms.Button button_11;
        private System.Windows.Forms.Button button_10;
        private System.Windows.Forms.Button button_Power;
        private System.Windows.Forms.Button button_onoff;
    }
}

