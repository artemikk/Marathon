using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    public partial class Login_or_registration : Form
    {
        public Login_or_registration()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 cpt = new Form1();
            cpt.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login cpt = new Login();
            cpt.Show();
            this.Hide();
        }
    }
}
