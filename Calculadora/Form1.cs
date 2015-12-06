using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            text_Num1.Text = "";
            text_Num2.Text = "";
            lbl_result2.Text = "";
        }

        private void bt_clear2_Click(object sender, EventArgs e)
        {
            if (text_Num2.Text == "")
            {
                text_Num1.Text = "";
            }
            else text_Num2.Text = "";
        }

        private void bt_plus_Click_1(object sender, EventArgs e)
        {
            double num1, num2, result;

            if ((text_Num1.Text == "") || (text_Num2.Text == ""))
            {
                MessageBox.Show(" Please, enter a number !");
            }
            else
            {
                num1 = Convert.ToDouble(text_Num1.Text);
                num2 = Convert.ToDouble(text_Num2.Text);
                result = num1 + num2;
                lbl_result2.Text = result.ToString();
            }
        }

        private void bt_minus_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            if ((text_Num1.Text == "") || (text_Num2.Text == ""))
            {
                MessageBox.Show(" Please, enter a number !");
            }
            else {
                num1 = Convert.ToDouble(text_Num1.Text);
                num2 = Convert.ToDouble(text_Num2.Text);
                result = num1 - num2;
                lbl_result2.Text = result.ToString();
            }
        }

        private void bt_mult_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            if ((text_Num1.Text == "") || (text_Num2.Text == ""))
            {
                MessageBox.Show(" Please, enter a number !");
            }
            else {
                num1 = Convert.ToDouble(text_Num1.Text);
                num2 = Convert.ToDouble(text_Num2.Text);
                result = num1 * num2;
                lbl_result2.Text = result.ToString();
            }
        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            if ((text_Num1.Text == "") || (text_Num2.Text == ""))
            {
                MessageBox.Show(" Please, enter a number !");
            }
            else {
                num1 = Convert.ToDouble(text_Num1.Text);
                num2 = Convert.ToDouble(text_Num2.Text);
                result = num1 / num2;
                lbl_result2.Text = result.ToString();
            }
        }

        private void bt_sqrt_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            if ((text_Num1.Text == "") && (text_Num2.Text == ""))
            {
                MessageBox.Show(" Please, enter a number !");
            }
            else if (text_Num1.Text == "")
            {
                num2 = Convert.ToDouble(text_Num2.Text);
                result = Math.Sqrt(num2);
                lbl_result2.Text = result.ToString();
            }
            else
            {
                num1 = Convert.ToDouble(text_Num1.Text);
                result = Math.Sqrt(num1);
                lbl_result2.Text = result.ToString();
            }
        }

        private void bt_log_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            if ((text_Num1.Text == "") && (text_Num2.Text == ""))
            {
                MessageBox.Show(" Please, enter a number !");
            }
            else if (text_Num2.Text == "")
            {
                num1 = Convert.ToDouble(text_Num1.Text);
                result = Math.Log(num1);
                lbl_result2.Text = result.ToString();
            }
            else if (text_Num1.Text == "")
            {
                num2 = Convert.ToDouble(text_Num2.Text);
                result = Math.Log(num2);
                lbl_result2.Text = result.ToString();
            }
            else
            {
                num1 = Convert.ToDouble(text_Num1.Text);
                num2 = Convert.ToDouble(text_Num2.Text);
                result = Math.Log(num1, num2);
                lbl_result2.Text = result.ToString();
            }
        }

        private void bt_sin_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            if ((text_Num1.Text == "") && (text_Num2.Text == ""))
            {
                MessageBox.Show(" Please, enter a number !");
            }
            else if (text_Num1.Text == "")
            {
                num2 = Convert.ToDouble(text_Num2.Text);
                result = Math.Sin(num2);
                lbl_result2.Text = result.ToString();
            }
            else
            {
                num1 = Convert.ToDouble(text_Num1.Text);
                result = Math.Sin(num1);
                lbl_result2.Text = result.ToString();
            }
        }

        private void bt_cos_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            if ((text_Num1.Text == "") && (text_Num2.Text == ""))
            {
                MessageBox.Show(" Please, enter a number !");
            }
            else if (text_Num1.Text == "")
            {
                num2 = Convert.ToDouble(text_Num2.Text);
                result = Math.Cos(num2);
                lbl_result2.Text = result.ToString();
            }
            else
            {
                num1 = Convert.ToDouble(text_Num1.Text);
                result = Math.Cos(num1);
                lbl_result2.Text = result.ToString();
            }
        }

        private void bt_tan_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            if ((text_Num1.Text == "") && (text_Num2.Text == ""))
            {
                MessageBox.Show(" Please, enter a number !");
            }
            else if (text_Num1.Text == "")
            {
                num2 = Convert.ToDouble(text_Num2.Text);
                result = Math.Tan(num2);
                lbl_result2.Text = result.ToString();
            }
            else
            {
                num1 = Convert.ToDouble(text_Num1.Text);
                result = Math.Tan(num1);
                lbl_result2.Text = result.ToString();
            }
        }

        private void bt_xry_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            if ((text_Num1.Text == "") && (text_Num2.Text == ""))
            {
                MessageBox.Show(" Please, enter a number !");
            }
            else if ((text_Num1.Text == "") || (text_Num2.Text == ""))
            {
                MessageBox.Show(" Please, enter another number !");
            }
            else
            {
                num1 = Convert.ToDouble(text_Num1.Text);
                num2 = Convert.ToDouble(text_Num2.Text);
                result = Math.Pow(num1, num2);
                lbl_result2.Text = result.ToString();
            }
        }
    }
}
