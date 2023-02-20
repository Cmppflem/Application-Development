using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Sorting_and_Searching
{
    public partial class Form1 : Form
    {
        int[] Player_Goals = new int[11]; //global array for player numbers 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            int i;
            

            Player_Goals[0] = 9;
            Player_Goals[1] = 4;
            Player_Goals[2] = 20;
            Player_Goals[3] = 8;
            Player_Goals[4] = 3;
            Player_Goals[5] = 10;
            Player_Goals[6] = 14;
            Player_Goals[7] = 11;
            Player_Goals[8] = 18;
            Player_Goals[9] = 1;
            Player_Goals[10] = 5;
            
            for (i = 0; i < 11; i++)
            {
                textBox1.Text = textBox1.Text + Player_Goals[i] + "\r\n";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int temp = 0;
            int i;
            

            for (i = 1; i < Player_Goals.Length; i++)
            

            {
                for (int sort = 0; sort < Player_Goals.Length - 1; sort++)
                {
                    
                    if (Player_Goals[sort] > Player_Goals[sort + 1])
                    {
                        temp = Player_Goals[sort + 1];
                        Player_Goals[sort + 1] = Player_Goals[sort];
                        Player_Goals[sort] = temp;
                    }
                }
            }

            for (i = 0; i < 11; i++)
            {
                textBox2.Text = textBox2.Text + Player_Goals[i] + "\r\n";
        }





        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int i;
            int GoalsScored = 0;
            bool found = false;

            for (i = 0; i< 11; i++)
            {
             if (Player_Goals[i] == int.Parse(txtSearch.Text))
                {
                    found = true;
                    GoalsScored = i +1;
                }
            }
            if (found == true)
            {
                txtFound.Text = "Found The Amount of Goals Scored By Player; " + GoalsScored ;
            }
            else
            {
                txtFound.Text = "Player Goals Score Not Found";
            }

        }

        private void txtFound_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}