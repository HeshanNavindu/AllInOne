using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllinOne
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gunasignup_Click(object sender, EventArgs e)
        {
            Signup sign = new Signup();
            sign.ShowDialog();
        }

        private void gunasignin_Click(object sender, EventArgs e)
        {
            Dashbord dash = new Dashbord();
            dash.ShowDialog();
        }
    }
}
