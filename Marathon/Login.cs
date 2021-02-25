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
    public partial class Login : Form
    {
        public static DataBase db = new DataBase();
        public static User USR { get; set; }
        public static Login LOG { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }
            User usr = db.Users.Find(textBox1.Text);

            if ((usr != null) && (usr.Password == textBox2.Text))
            {

                USR = usr;
                LOG = this;


                if (usr.RoleId == "A")
                {
                    AdminM am = new AdminM();
                    am.Show();
                    this.Close();
                }
                else if (usr.RoleId == "R")
                {
                    RunnerM rm = new RunnerM();
                    rm.Show();
                    this.Close();
                }
            else
                {
                    MessageBox.Show("Вы уже авторизованы в системе");
                    if (USR.RoleId == "A")
                    {
                        AdminM am = new AdminM();
                        am.Show();
                        this.Close();
                    }
                    else if (USR.RoleId == "R")
                    {
                        RunnerM rm = new RunnerM();
                        rm.Show();
                        this.Close();
                    }
                    else if (USR.RoleId == "C")
                    {
                        CoordinatorM cm = new CoordinatorM();
                        cm.Show();
                        this.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_or_registration cpt = new Login_or_registration();
            cpt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 cpt = new Form1();
            cpt.Show();
            this.Hide();
        }
    }
}
