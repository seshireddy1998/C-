using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(Username.Text=="seshireddy" && Password.Text=="2016cse264")
            {
                Form2 f = new Form2();
                MessageBox.Show("LOGIN SUCCESSFUL");
                f.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("LOGIN UNSUCCESSFUL");
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
