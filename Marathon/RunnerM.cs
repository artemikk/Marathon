﻿using System;
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
    public partial class RunnerM : Form
    {
        public RunnerM()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login cpt = new Login();
            cpt.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login cpt = new Login();
            cpt.Show();
            this.Hide();
        }
    }
}
