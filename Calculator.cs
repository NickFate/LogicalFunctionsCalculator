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
            Input.Text += " " + a.Text;
        }

        private void EquallyButton_Click(object sender, EventArgs e)
        {
            label1.Text = parser.GetAnswer(Input.Text);
        }

        private void FalseButton_Click(object sender, EventArgs e)
        {
            Buttons(sender);
        }
    }
}
