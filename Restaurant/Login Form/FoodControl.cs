using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class FoodControl : UserControl
    {
        public FoodControl()
        {
            InitializeComponent();
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FoodControl_Click(object sender, EventArgs e)
        {
            if (gunaGradientButton1_valid.Visible == false)
            {
                gunaGradientButton1_valid.Visible = true;
                gunaLinePanel1_valid.Visible = true;
            }
            else
            {
                gunaGradientButton1_valid.Visible = false;
                gunaLinePanel1_valid.Visible = false;
            }
        }

        private void gunaLinePanel1_valid_Click(object sender, EventArgs e)
        {
            if (gunaGradientButton1_valid.Visible == false)
            {
                gunaGradientButton1_valid.Visible = true;
                gunaLinePanel1_valid.Visible = true;
            }
            else
            {
                gunaGradientButton1_valid.Visible = false;
                gunaLinePanel1_valid.Visible = false;
            } 
        }
    }
}
