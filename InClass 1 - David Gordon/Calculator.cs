using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double num1 = 0;
        double num2 = 0;
        double sum = 0;
        string operation = "null";

        public Calculator()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            lblInput.Text += (sender as Button).Text;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            operation = (sender as Button).Text;

            num1 = Convert.ToDouble(lblInput.Text);

            lblInput.Text = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            lblInput.Text = null;
            num1 = 0;
            num2 = 0;
        }

        private void btnClearE_Click(object sender, EventArgs e)
        {
            string text = lblInput.Text;
            lblInput.Text = lblInput.Text.Substring(0, (text.Length - 1));
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(lblInput.Text);

            switch(operation)
            {
                case "+":
                    sum = num1 + num2;
                    break;
                case "-":
                    sum = num1 - num2;
                    break;
                case "*":
                    sum = num1 * num2;
                    break;
                case "/":
                    sum = num1 / num2;
                    break;
            }

            txtOutput.Text = sum.ToString();
            lblInput.Text = null;
        }
    }
}
