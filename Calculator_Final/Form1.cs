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
        oopClass calc = new oopClass();
        public frmCalculator()
        {
            InitializeComponent();
            btnMC.Enabled = false;
            btnMR.Enabled = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (calc.operation || calc.memory_on)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "1";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "1";
            }
            else if (calc.equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "1";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "1";
            }
            calc.operation = false;
            calc.equals = false;
            calc.memory_on = false;
            calc.percent = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (calc.operation || calc.memory_on)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "2";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "2";
            }
            else if (calc.equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "2";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "2";
            }
            calc.operation = false;
            calc.equals = false;
            calc.memory_on = false;
            calc.percent = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (calc.operation || calc.memory_on)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "3";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "3";
            }
            else if (calc.equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "3";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "3";
            }
            calc.operation = false;
            calc.equals = false;
            calc.memory_on = false;
            calc.percent = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (calc.operation || calc.memory_on)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "0";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "0";
            }
            else if (calc.equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "0";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "0";
            }
            calc.operation = false;
            calc.equals = false;
            calc.memory_on = false;
            calc.percent = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (calc.operation || calc.memory_on)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "4";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "4";
            }
            else if (calc.equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "4";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "4";
            }
            calc.operation = false;
            calc.equals = false;
            calc.memory_on = false;
            calc.percent = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (calc.operation || calc.memory_on)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "5";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "5";
            }
            else if (calc.equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "5";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "5";
            }
            calc.operation = false;
            calc.equals = false;
            calc.memory_on = false;
            calc.percent = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (calc.operation || calc.memory_on)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "6";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "6";
            }
            else if (calc.equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "6";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "6";
            }
            calc.operation = false;
            calc.equals = false;
            calc.memory_on = false;
            calc.percent = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (calc.operation || calc.memory_on)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "7";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "7";
            }
            else if (calc.equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "7";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "7";
            }
            calc.operation = false;
            calc.equals = false;
            calc.memory_on = false;
            calc.percent = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (calc.operation || calc.memory_on)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "8";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "8";
            }
            else if (calc.equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "8";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "8";
            }
            calc.operation = false;
            calc.equals = false;
            calc.memory_on = false;
            calc.percent = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (calc.operation || calc.memory_on)
            {
                txtDisp1.Text = "";
                txtDisp1.Text = "9";
            }
            else if (txtDisp1.Text == "0" && txtDisp1.Text != null)
            {
                txtDisp1.Text = "9";
            }
            else if (calc.equals)
            {
                txtDisp2.Clear();
                txtDisp1.Text = "";
                txtDisp1.Text = "9";
            }
            else
            {
                txtDisp1.Text = txtDisp1.Text + "9";
            }
            calc.operation = false;
            calc.equals = false;
            calc.memory_on = false;
            calc.percent = false;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if ((txtDisp1.Text == "0" && txtDisp1.Text != null) || (calc.operation) || (calc.equals))
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
            calc.equals = false;
            calc.operation = false;
            calc.memory_on = false;
            calc.percent = false;
        }

        //  ------- B A S I C    A R I T H M E T I C S 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            calc.operation = true;
            txtDisp2.Clear();
            calc.operation_sign = "+";
            calc.num1 = txtDisp1.Text;
            txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "+";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            calc.operation = true;
            txtDisp2.Clear();
            calc.operation_sign = "-";
            calc.num1 = txtDisp1.Text;
            txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calc.operation = true;
            txtDisp2.Clear();
            calc.operation_sign = "*";
            calc.num1 = txtDisp1.Text;
            txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "×";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            calc.operation = true;
            txtDisp2.Clear();
            calc.operation_sign = "/";
            calc.num1 = txtDisp1.Text;
            txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "÷";
        }
        //-------- E N D  O F  B A S I C  A R I T H M E T I C S
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (calc.operation_sign == "+")
            {
                if (calc.percent)
                {
                    txtDisp1.Text = (float.Parse(calc.num1) + float.Parse(txtDisp1.Text)).ToString();
                }
                else if ((calc.equals) && (txtDisp2.Text.Contains("+")))
                {
                    string[] nums = txtDisp2.Text.Split('+', '=');
                    btnAdd.PerformClick();
                   
                    txtDisp2.Text = txtDisp1.Text + "+" + nums[1] + "=";
                    txtDisp1.Text = (float.Parse(calc.num1) + float.Parse(nums[1])).ToString();
                }
                else
                {
                    txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "=";
                    txtDisp1.Text = (float.Parse(calc.num1) + float.Parse(txtDisp1.Text)).ToString();
                }
                calc.equals = true;
            }
            else if (calc.operation_sign == "-")
            {
                if (calc.percent)
                { 
                    txtDisp1.Text = (float.Parse(calc.num1) - float.Parse(txtDisp1.Text)).ToString();
                }
                else if ((calc.equals) && (txtDisp2.Text.Contains("-")))
                {
                    string[] nums = txtDisp2.Text.Split('-', '=');
                    btnSubtract.PerformClick();

                    txtDisp2.Text = txtDisp1.Text + "-" + nums[1] + "=";
                    txtDisp1.Text = (float.Parse(calc.num1) - float.Parse(nums[1])).ToString();
                }
                else
                {
                    txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "=";
                    txtDisp1.Text = (float.Parse(calc.num1) - float.Parse(txtDisp1.Text)).ToString();
                }
                calc.equals = true;
            }
            else if (calc.operation_sign == "*")
            {
                if (calc.percent)
                {
                    txtDisp1.Text = (float.Parse(calc.num1) * float.Parse(txtDisp1.Text)).ToString();
                }
                else if ((calc.equals) && (txtDisp2.Text.Contains("×")))
                {
                    string[] nums = txtDisp2.Text.Split('×', '=');
                    btnMultiply.PerformClick();

                    txtDisp2.Text = txtDisp1.Text + "×" + nums[1] + "=";
                    txtDisp1.Text = (float.Parse(calc.num1) * float.Parse(nums[1])).ToString();
                }
                else
                {
                    txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "=";
                    txtDisp1.Text = (float.Parse(calc.num1) * float.Parse(txtDisp1.Text)).ToString();
                }
                calc.equals = true;
            }
            else if (calc.operation_sign == "/")
            {
                if (calc.percent)
                {
                    txtDisp1.Text = (float.Parse(calc.num1) / float.Parse(txtDisp1.Text)).ToString();
                }
                else if ((calc.equals) && (txtDisp2.Text.Contains("÷")))
                {
                    string[] nums = txtDisp2.Text.Split('÷', '=');
                    btnDivision.PerformClick();

                    txtDisp2.Text = txtDisp1.Text + "÷" + nums[1] + "=";
                    txtDisp1.Text = (float.Parse(calc.num1) / float.Parse(nums[1])).ToString();
                }
                else
                {
                    txtDisp2.Text = txtDisp2.Text + txtDisp1.Text + "=";
                    txtDisp1.Text = (float.Parse(calc.num1) / float.Parse(txtDisp1.Text)).ToString();
                }
                calc.equals = true;
            } 
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = "0";
            txtDisp2.Clear();
            calc.operation = false;
            calc.operation_sign = "";
            calc.equals = false;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = "0";
            calc.operation = false;
            calc.operation_sign = "";
            calc.equals = false;
        }

        //---------- A D D I T I O N A L  O P E R A T I O N S
        private void btnDel_Click(object sender, EventArgs e)
        {
            if ((txtDisp1.Text.Length > 1) && (!calc.equals))
            {
                txtDisp1.Text = txtDisp1.Text.Remove(txtDisp1.Text.Length - 1, 1);
            }
            else if (calc.equals)
            {
                txtDisp2.Clear();
            }
            else if ((txtDisp1.Text.Length == 1) || txtDisp1.Text == "0")
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
                calc.num1 = txtDisp1.Text;
                txtDisp1.Text = (1 / float.Parse(calc.num1)).ToString();
                txtDisp2.Text = "1 /" + "(" + calc.num1 + ")";
            }
            calc.operation = true;
            calc.equals = false;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            calc.num1 = txtDisp1.Text;
            txtDisp1.Text = ((float.Parse(calc.num1)) * (float.Parse(calc.num1))).ToString();
            txtDisp2.Text = "sqr( " + calc.num1 + " )";

            calc.operation = true;
            calc.equals = false;
        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            calc.num1 = txtDisp1.Text;
            txtDisp1.Text = (Math.Sqrt(float.Parse(calc.num1))).ToString();
            txtDisp2.Text = "√( " + calc.num1 + " )";

            calc.operation = true;
            calc.equals = false;
        }
        //--------- M E M O R Y   B U T T O N S 
        private void btnMS_Click(object sender, EventArgs e)
        {
            btnMC.Enabled = true;
            btnMR.Enabled = true;
            calc.memory = txtDisp1.Text;
            calc.memory_on = true;
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {
            if (calc.memory == "")
            {
                calc.memory = (0 - (float.Parse(txtDisp1.Text))).ToString();
            }
            else
            {
                calc.memory = (float.Parse(calc.memory) - float.Parse(txtDisp1.Text)).ToString();
            }
            btnMC.Enabled = true;
            btnMR.Enabled = true;
            calc.memory_on = true;
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            calc.memory = "";
            btnMC.Enabled = false;
            btnMR.Enabled = false;
            calc.memory_on = true;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = calc.memory;
            calc.memory_on = true;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            if (calc.memory == "")
            {
                calc.memory = (0 + (float.Parse(txtDisp1.Text))).ToString();
            }
            else
            {
                calc.memory = (float.Parse(calc.memory) + float.Parse(txtDisp1.Text)).ToString();
            }
            btnMC.Enabled = true;
            btnMR.Enabled = true;
            calc.memory_on = true;
        }
      
        private void btnPerc_Click(object sender, EventArgs e)
        {
            if (calc.operation_sign == "+")
            {
                txtDisp2.Text = calc.num1 + "+" + ((float.Parse(txtDisp1.Text) / 100) * (float.Parse(calc.num1))).ToString();
                txtDisp1.Text = ((float.Parse(txtDisp1.Text) / 100) * (float.Parse(calc.num1))).ToString();
                calc.percent = true;
            }
            else if (calc.operation_sign == "-")
            {
                txtDisp2.Text = calc.num1 + "-" + ((float.Parse(txtDisp1.Text) / 100) * (float.Parse(calc.num1))).ToString();
                txtDisp1.Text = ((float.Parse(txtDisp1.Text) / 100) * (float.Parse(calc.num1))).ToString();
                calc.percent = true;
            }
            else if (calc.operation_sign == "*")
            {
                txtDisp2.Text = calc.num1 + " * " + ((float.Parse(txtDisp1.Text) / 100)).ToString();
                txtDisp1.Text = (float.Parse(txtDisp1.Text) / 100).ToString();
                calc.percent = true;
            }
            else if (calc.operation_sign == "/")
            {
                txtDisp2.Text = calc.num1 + " / " + ((float.Parse(txtDisp1.Text) / 100)).ToString();
                txtDisp1.Text = (float.Parse(txtDisp1.Text) / 100).ToString();
                calc.percent = true;
            }
        }

        private void btnNeg_Click(object sender, EventArgs e)
        {
            txtDisp1.Text = (-1 * float.Parse(txtDisp1.Text)).ToString();
        }
    }
}
