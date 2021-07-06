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
        Boolean operation = false;
        string num1 = "";
        string operation_sign = "";

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "1";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "1";
            }

            operation = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
            }

            txtDisp1.Text = txtDisp1.Text + "2";
            operation = false; 
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
            }

            txtDisp1.Text = txtDisp1.Text + "3";
            operation = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
            }

            txtDisp1.Text = txtDisp1.Text + "0";
            operation = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
            }

            txtDisp1.Text = txtDisp1.Text + "4";
            operation = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
            }

            txtDisp1.Text = txtDisp1.Text + "5";
            operation = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
            }

            txtDisp1.Text = txtDisp1.Text + "6";
            operation = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
            }

            txtDisp1.Text = txtDisp1.Text + "7";
            operation = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = txtDisp1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
            }

            txtDisp1.Text = txtDisp1.Text + "9";
            operation = false;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = txtDisp1.Text + ".";
        }

        //operations
        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = true;
            operation_sign = "+";
            num1 = txtDisp1.Text;
            txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "+";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            operation = true;

            txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "=";
            txtDisp1.Text = (float.Parse(num1) + float.Parse(txtDisp1.Text)).ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = "0";
            txtDisp2.Clear();
            operation = false;
            operation_sign = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = "0";
            operation = false;
            operation_sign = "";
        }
    }
}
