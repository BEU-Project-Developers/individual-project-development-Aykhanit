using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagnostiCenter
{
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
            populate();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Patients Obj = new Patients();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Tests Obj = new Tests();
            Obj.Show();
            this.Hide();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Computer\Documents\DiagnosticDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string Query = "select * from DoctorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DOCDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void reset()
        {
            DocNameTb.Text = "";
            DocPhoneTb.Text = "";
            DocAddressTb.Text = "";
            DesignationCb.SelectedIndex = -1;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (DocNameTb.Text == "" || DocPhoneTb.Text == "" || DesignationCb.SelectedIndex == -1 || DocAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DoctorTbl values('" + DocNameTb.Text + "','" + DocDOB.Value.Date + "','" + DocPhoneTb.Text + "','" + DocAddressTb.Text + "','"+DesignationCb.SelectedItem.ToString()+"','"+DocJoinDate.Value.Date+"')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Saved Successfully");
                    Con.Close();
                    populate();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
