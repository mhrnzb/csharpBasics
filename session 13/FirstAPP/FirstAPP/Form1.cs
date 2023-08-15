using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstAPP
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "")
            {
                lblHello.ForeColor = Color.Green;
                lblHello.Text = "Hello " + txtName.Text;

            }
            else
            {
                lblHello.ForeColor = Color.Red;
                lblHello.Text = "please enter your name ";
            }


            //MessageBox.Show("hello" + txtName.Text);
            
        }
    }
}
