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
        Boolean equals = false;
        string num1 = ""; // display
        string operation_sign = "";
        string memory = "";

        public frmCalculator()
        {
            InitializeComponent();
            btnMC.Enabled = false;
            btnMR.Enabled = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "1";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "1";
            }
            else if (equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "1";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "1";
            }

            operation = false;
            equals = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "2";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "2";
            }
            else if (equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "2";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "2";
            }
            operation = false;
            equals = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "3";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "3";
            }
            else if (equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "3";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "3";
            }
            operation = false;
            equals = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "0";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "0";
            }
            else if (equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "0";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "0";
            }
            operation = false;
            equals = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "4";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "4";
            }
            else if (equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "4";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "4";
            }
            operation = false;
            equals = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "5";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "5";
            }
            else if (equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "5";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "5";
            }
            operation = false;
            equals = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "6";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "6";
            }
            else if (equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "6";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "6";
            }
            operation = false;
            equals = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "7";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "7";
            }
            else if (equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "7";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "7";
            }
            operation = false;
            equals = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "8";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "8";
            }
            else if (equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "8";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "8";
            }
            operation = false;
            equals = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "9";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "9";
            }
            else if (equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "9";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "9";
            }
            operation = false;
            equals = false;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if ((txtDisp1.Text == "0" && txtDisp1.Text != null) || (operation) || (equals))
            {
                txtDisp2.Clear();
                txtDisp1.Text = "0.";
            }
            else if (txtDisp1.Text.Contains("."))
            {
                txtDisp1.Text = txtDisp1.Text;
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + ".";
            }
            equals = false;
            operation = false;
        }

        //  ------- B A S I C    A R I T H M E T I C S 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (operation_sign == "+")
            //{
            //    txtDisp2.Text = txtDisp2.Text;
            //}
            //else if (operation_sign != "")
            //{
            //    operation_sign = "+";
            //    txtDisp2.Text =

            //}
            ////else
            {
                operation = true;
                txtDisp2.Clear();
                operation_sign = "+";
                num1 = txtDisp1.Text;
                txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "+";
                
                
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            operation = true;
            txtDisp2.Clear();
            operation_sign = "-";
            num1 = txtDisp1.Text;
            txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operation = true;
            txtDisp2.Clear();
            operation_sign = "*";
            num1 = txtDisp1.Text;
            txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "*";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operation = true;
            txtDisp2.Clear();
            operation_sign = "/";
            num1 = txtDisp1.Text;
            txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "/";
        }
        //-------- E N D  O F  B A S I C  A R I T H M E T I C S
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (operation_sign == "+")
            {
                equals = true;

                txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "=";
                txtDisp1.Text = (float.Parse(num1) + float.Parse(txtDisp1.Text)).ToString();
            }
            else if (operation_sign == "-")
            {
                equals = true;

                txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "=";
                txtDisp1.Text = (float.Parse(num1) - float.Parse(txtDisp1.Text)).ToString();
            }
            else if (operation_sign == "*")
            {
                equals = true;

                txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "=";
                txtDisp1.Text = (float.Parse(num1) * float.Parse(txtDisp1.Text)).ToString();
            }
            else if (operation_sign == "/")
            {
                equals = true;

                txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "=";
                txtDisp1.Text = (float.Parse(num1) / float.Parse(txtDisp1.Text)).ToString();
            }
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

        //---------- A D D I T I O N A L  O P E R A T I O N S
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtDisp1.Text.Length > 0)
            {
                txtDisp1.Text = txtDisp1.Text.Remove(txtDisp1.Text.Length - 1, 1);
            }
            else if ((txtDisp1.Text.Length == 0) || txtDisp1.Text == "0")
            {
                txtDisp1.Text = "0";
            }
        }

        private void btn1overX_Click(object sender, EventArgs e)
        {
            if (txtDisp1.Text == "0")
            {
                txtDisp1.Text = "Cannot divide by zero";
                txtDisp2.Text = "1/(0)";
            }
            else
            {
                num1 = txtDisp1.Text;
                txtDisp1.Text = (1 / float.Parse(num1)).ToString();
                txtDisp2.Text = "1 /" + "(" + num1 + ")";
            }
            operation = true;
            equals = false;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            num1 = txtDisp1.Text;
            txtDisp1.Text = ((float.Parse(num1)) * (float.Parse(num1))).ToString();
            txtDisp2.Text = "sqr( " + num1 + " )";

            operation = true;
            equals = false;
        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            num1 = txtDisp1.Text;
            txtDisp1.Text = (Math.Sqrt(float.Parse(num1))).ToString();
            txtDisp2.Text = "√( " + num1 + " )";

            operation = true;
            equals = false;
        }
        //--------- M E M O R Y   B U T T O N S 
        private void btnMS_Click(object sender, EventArgs e)
        {
            btnMC.Enabled = true;
            btnMR.Enabled = true;
            memory = txtDisp1.Text;
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {
            btnMC.Enabled = true;
            btnMR.Enabled = true;
            memory = (float.Parse(memory) - float.Parse(txtDisp1.Text)).ToString();
        }
    }
}
