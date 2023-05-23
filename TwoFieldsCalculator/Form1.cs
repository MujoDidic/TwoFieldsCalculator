using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoFieldsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            float num1, num2, totalNum = 0;

            bool divWithNull = false;

            num1 = Convert.ToSingle(numOneBox.Text);

            num2 = Convert.ToSingle(numTwoBox.Text);

            if (rBtnAddition.Checked == true)
                totalNum = num1 + num2;

            if (rBtnSubtraction.Checked == true)
                totalNum = num1 - num2;

            if (rBtnMultiply.Checked == true)
                totalNum = num1 * num2;

            if (rBtnDivide.Checked == true)
            {
                if (num2 == 0)
                    divWithNull = true;
                else
                    totalNum = num1 / num2;
            }

            if (divWithNull == true)
                totalVisible.Text = "Not defined";
            else
                totalVisible.Text = Convert.ToString(totalNum);
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
