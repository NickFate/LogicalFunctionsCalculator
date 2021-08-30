using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicalFunctionsCalculator
{
    public partial class Calculator : Form
    {

        private Classes.Parser parser = new Classes.Parser();

        public Calculator()
        {
            InitializeComponent();
        }

        private void TrueButton_Click(object sender, EventArgs e)
        {
            Buttons(sender);
        }

        private void Buttons(object sender)
        {
            Button a = sender as Button;
            Input.Text += a.Text + " ";
        }

        private void EquallyButton_Click(object sender, EventArgs e)
        {
            label1.Text = parser.GetAnswer(Input.Text);
        }

        private void FalseButton_Click(object sender, EventArgs e)
        {
            Buttons(sender);
        }

        private void NOTButton_Click(object sender, EventArgs e)
        {
            Buttons(sender);
        }

        private void XORButton_Click(object sender, EventArgs e)
        {
            Buttons(sender);
        }

        private void ANDButton_Click(object sender, EventArgs e)
        {
            Buttons(sender);
        }

        private void ORButton_Click(object sender, EventArgs e)
        {
            Buttons(sender);
        }

        private void IMPButton_Click(object sender, EventArgs e)
        {
            Buttons(sender);
        }

        private void EQVButton_Click(object sender, EventArgs e)
        {
            Buttons(sender);
        }

        private void SCSButton_Click(object sender, EventArgs e)
        {
            Buttons(sender);
        }

        private void PARButton_Click(object sender, EventArgs e)
        {
            Buttons(sender);
        }

        private void CButton_Click(object sender, EventArgs e) // можно оптимизировать
        {
            string[] ms = new string[] { "true ", "false ", "or ", "xor ", "and ", "not ", " eqv", "imp ", "scs ", "par " };

            foreach (string i in ms)
            {
                if (Input.Text.EndsWith(i))
                {
                    string ext = Input.Text.Substring(0, Input.Text.Length - i.Length);
                    Input.Text = ext;

                    break;
                }
            }
        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            Input.Text = "";
        }
    }
}
