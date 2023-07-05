using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discrete
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

        private void txtBox_inputTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            /* Declare 2 string variables and get their values from textbox1 and textbox2 */
            string firstNumber, secondNumber;
            firstNumber = txtBox_inputOne.Text;
            secondNumber = txtBox_inputTwo.Text;
            input_Validation(firstNumber, secondNumber); // Input validations, return error message if input is invalid (ex. letters)
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            txtBox_inputOne.Text = "";
            txtBox_inputTwo.Text = "";
            lbl_proving.Text = "";
            lbl_steps.Text = "";
        }

        private int euclidean_Algorithm(int a, int b)
        {
            int r, d;

            r = a % b; // var r will hold value of a % b
            d = a / b; // var d will hold value of a / b

            string step = $"Divide {a} by {b}, and get the result {d} with remainder {r}. \n{a} = {d} * {b} + {r}"; // steps
            lbl_steps.Text += step + Environment.NewLine; // Environment.NewLine adds a line break between each step
            if (r == 0)
                return b;
            else
            {
                a = b;
                b = r;
                return euclidean_Algorithm(a, b); // Recursive function until the result is 0
            }
        }

        private void input_Validation(string fNumber, string sNumber)
        {
            if (int.TryParse(fNumber, out int firstNum) && int.TryParse(sNumber, out int secondNum))
            {
                // Both inputs are valid integers
                lbl_proving.Text = (euclidean_Algorithm(firstNum, secondNum).ToString());
            }
            else
            {
                // Invalid input(s)
                txtBox_inputOne.Text = "";
                txtBox_inputTwo.Text = "";
                MessageBox.Show("Please enter valid integer values.");
            }
        }
    }
}
