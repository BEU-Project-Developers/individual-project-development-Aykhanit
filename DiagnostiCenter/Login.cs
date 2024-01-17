using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagnostiCenter
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Unametb.Text = "";
            PasswordTb.Text = "";

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if(Unametb.Text=="" ||  PasswordTb.Text=="")
            {
                MessageBox.Show( "Enter UserName and Password");
            }
            else
            {
                if(Unametb.Text=="Admin" || PasswordTb.Text=="Password")
                {
                    Patients Obj=new Patients();
                    Obj.Show();
                    this.Hide();
                }else
                {
                    MessageBox.Show("Wrong Username or Password");
                    Unametb.Text = "";
                    PasswordTb.Text = "";
                }
            }
        }
    }
}
