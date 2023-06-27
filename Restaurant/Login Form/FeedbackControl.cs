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
    public partial class FeedbackControl : UserControl
    {
        public FeedbackControl()
        {
            InitializeComponent();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int flag = 1;
        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == -1)
            {
                Bitmap b = new Bitmap(@"C:\icons8-star-52.PNG");
                gunaAdvenceButton6.Image = b;
            }
            else
            {
                Bitmap b2 = new Bitmap(@"C:\icons8-star-50.PNG");
                gunaAdvenceButton6.Image = b2;

            }
        }
        
        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == -1)
            {
                Bitmap b = new Bitmap(@"C:\icons8-star-52.PNG");
                gunaAdvenceButton6.Image = b;
            }
            else
            {
                Bitmap b2 = new Bitmap(@"C:\icons8-star-50.PNG");
                gunaAdvenceButton6.Image = b2;

            }
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == -1)
            {
                Bitmap b = new Bitmap(@"C:\icons8-star-52.PNG");
                gunaAdvenceButton6.Image = b;
            }
            else
            {
                Bitmap b2 = new Bitmap(@"C:\icons8-star-50.PNG");
                gunaAdvenceButton6.Image = b2;

            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == -1)
            {
                Bitmap b = new Bitmap(@"C:\icons8-star-52.PNG");
                gunaAdvenceButton6.Image = b;
            }
            else
            {
                Bitmap b2 = new Bitmap(@"C:\icons8-star-50.PNG");
                gunaAdvenceButton6.Image = b2;

            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == -1)
            {
                Bitmap b = new Bitmap(@"C:\icons8-star-52.PNG");
                gunaAdvenceButton6.Image = b;
            }
            else
            {
                Bitmap b2 = new Bitmap(@"C:\icons8-star-50.PNG");
                gunaAdvenceButton6.Image = b2;

            }
        }
    }
}
