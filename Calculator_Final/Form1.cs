using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Final
{
    public partial class frmCalculator : Form
    {
        double solver = 0;
        // solver will be the on to collect the numbers and then solve the equations later on 

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = txtDisp1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = txtDisp1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = txtDisp1.Text + "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = txtDisp1.Text + "0";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = txtDisp1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = txtDisp1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = txtDisp1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = txtDisp1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = txtDisp1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = txtDisp1.Text + "9";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = txtDisp1.Text + ".";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "+";
            txtDisp1.Clear();
        }

    }
}
