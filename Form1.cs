using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yaokecai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Button3_TextChanged(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x * y;
            this.labelResult.Text = z.ToString();
        }

        private void Button1_TextChanged(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x + y;
            this.labelResult.Text = z.ToString();
        }

        private void Button4_TextChanged(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x / y;
            this.labelResult.Text = z.ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x * y;
            this.labelResult.Text = z.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x + y;
            this.labelResult.Text = z.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x - y;
            this.labelResult.Text = z.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            
            if (y != 0)
            {
                var z = x / y;
                this.labelResult.Text = z.ToString();
            }
            else
            this.labelResult.Text = "0不能作为除数";
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);

            if (y != 0)
            {
                var z = x % y;
                this.labelResult.Text = z.ToString();
            }
            else
                this.labelResult.Text = "0不能作为除数";
        }
    }
}
