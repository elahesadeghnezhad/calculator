using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamrin2.calculator
{
    public partial class form1 : Form
    {
        double x, y, z;
        //x is the first number,is the second number and z is the result
        string op;
        Boolean flag;
        public form1()
        {
            InitializeComponent();
        }

        private void operators(object sender, MouseEventArgs e)
        {

            x = Convert.ToDouble(textBox_display.Text);
            op = ((Button)sender).Text;
            label_history.Text += ((Button)sender).Text;
            flag = true;
        }

        private void textBox_display_TextChanged(object sender, EventArgs e)
        {
            button_point.Enabled = !textBox_display.Text.Contains(".");
            button_backspase.Enabled = Convert.ToBoolean(textBox_display.Text.Length);
        }

        private void button_backspase_Click(object sender, EventArgs e)
        {
            if (textBox_display.TextLength > 0)
            {
                textBox_display.Text = textBox_display.Text.Substring(0, textBox_display.Text.Length - 1);
                label_history.Text = label_history.Text.Substring(0, label_history.Text.Length - 1);
            }
        }

        private void form1_Load(object sender, EventArgs e)
        {
            textBox_display_TextChanged(null, null);
        }

        private void form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Button temp = new Button();
            temp.Text = e.KeyChar.ToString();
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                numbers(temp, null);
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
                operators(temp, null);
            else if (e.KeyChar == '=')
                button_Equal_Click(null, null);
            else if (e.KeyChar == '.' && textBox_display.Text.Contains(".") == false)
                numbers(temp, null);
            else if (e.KeyChar == '\b')
                button_backspase_Click(null, null);
            foreach (Button x in panel1.Controls)
                if (x.Text == e.KeyChar.ToString())
                {
                    x.Focus();
                    x.ForeColor = Color.Red;
                }
                else
                    x.ForeColor = Color.Black;
        }

        private void form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Equal_Click(null, null);
                button_Equal.Focus();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_display.Text = "";
            label_history.Text = "";
        }

        private void SmartOperators(object sender, EventArgs e)
        {
            operators(sender, null);
            switch (op)
            {
                case "10^x":
                    z = Math.Pow(10, x);
                    label_history.Text = Convert.ToString("10 ^" + x + "=" + z);
                    break;
                case "1/x":
                    z = 1 / x;
                    label_history.Text = Convert.ToString("1 / " + x + "=" + z);
                    break;
                case "sqrt x":
                    z = Math.Sqrt(x);
                    label_history.Text = Convert.ToString("sqrt " + x + "=" + z);
                    break;
                case "log(x)":
                    z = Math.Log(x, 10);
                    label_history.Text = Convert.ToString("log(" + x + ") =" + z);
                    break;
                case "ln(x)":
                    z = Math.Log(x);
                    label_history.Text = Convert.ToString("ln(" + x + ") =" + z);
                    break;
            }
            textBox_display.Text = z.ToString();
        }

        private void button_onoff_Click(object sender, EventArgs e)
        {
            panel1.Enabled = !panel1.Enabled;
            if (button_onoff.Text == "on")
            {
                button_onoff.Text = "off";
                button_onoff.BackColor = Color.Red;
                this.KeyPreview = true;
            }
            else
            {
                button_onoff.Text = "on";
                button_onoff.BackColor = Color.LimeGreen;
                this.KeyPreview = false;
            }

        }

        private void button_Equal_Click(object sender, MouseEventArgs e)
        {
            y = Convert.ToDouble(textBox_display.Text);
            switch (op)
            {
                case "+":
                    z = x + y;
                    break;
                case "-":
                    z = x - y;
                    break;
                case "*":
                    z = x * y;
                    break;
                case "/":
                    z = x / y;
                    break;
                case "^":
                    z = Math.Pow(x, y);
                    break;
            }
            textBox_display.Text = z.ToString();
            label_history.Text += "=" + z.ToString();
        }
        private void numbers(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                textBox_display.Text = "";
                flag = false;
            }
            textBox_display.Text += ((Button)sender).Text;
            label_history.Text += ((Button)sender).Text;
        }
    }
}

