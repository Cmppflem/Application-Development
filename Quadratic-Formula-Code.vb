using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double a, b, c, x, x1, x2;


            a = double.Parse(txtA.Text);

            b = double.Parse(txtB.Text);

            c = double.Parse(txtC.Text);

            x = (b * b) - (4 * a * c);


            x1 = (-b + Math.Sqrt(x)) / (2 * a);

            x2 = (-b - Math.Sqrt(x)) / (2 * a);

            lb_Answer1.Text = x1.ToString();
            lb_Answer2.Text = x2.ToString();                                                                                                                
            
    }
    }
}