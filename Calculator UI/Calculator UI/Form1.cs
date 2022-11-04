using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        int count = 0;
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       // string label2 = "";
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (label2.Text != "0")
                label2.Text = label2.Text + "0";

            else
                label2.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (label2.Text != "0")
                label2.Text = label2.Text + "1";

            else
                label2.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (label2.Text != "0")
                label2.Text = label2.Text + "2";

            else
                label2.Text = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (label2.Text != "0")
                label2.Text = label2.Text + "3";

            else
                label2.Text = "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (label2.Text != "0")
                label2.Text = label2.Text + "4";


            else
                label2.Text = "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (label2.Text != "0")
                label2.Text = label2.Text + "5";

            else
                label2.Text = "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (label2.Text != "0")
                label2.Text = label2.Text + "6";

            else
                label2.Text = "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (label2.Text != "0")
                label2.Text = label2.Text + "7";

            else
                label2.Text = "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (label2.Text != "0")
                label2.Text = label2.Text + "8";

            else
                label2.Text = "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (label2.Text != "0")
                label2.Text = label2.Text + "9";

            else
                label2.Text = "9";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (!label2.Text.Contains("."))
                label2.Text = label2.Text + ".";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(label2.Text.Contains("-"))
            {
                label2.Text = label2.Text.Trim('-');
            }

            else
            {
                label2.Text = '-' + label2.Text;
            }
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                label2.Text += "+";
                
            }

            else
            {
                label2.Text = label3.Text + "+";
                count = 0;
            }

            

        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var v = dt.Compute(label2.Text, "");
            label3.Text = v.ToString();
            count++;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                label2.Text += "-";

            }

            else
            {
                label2.Text = label3.Text + "-";
                count = 0;
            }

        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                label2.Text += "*";

            }

            else
            {
                label2.Text = label3.Text + "*";
                count = 0;
            }

        }

        private void btndevide_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                label2.Text += "/";

            }

            else
            {
                label2.Text = label3.Text + "/";
                count = 0;
            }

        }

        private void btnmode_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                label2.Text += "%";

            }

            else
            {
                label2.Text = label3.Text + "%";
                count = 0;
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
            label3.Text = "";
            count = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           

        }
    }

    }
    
    

