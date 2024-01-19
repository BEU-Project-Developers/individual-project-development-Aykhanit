using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DiagnostiCenter
{
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Computer\Documents\DiagnosticDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Tests Obj = new Tests();
            Obj.Show();
            this.Hide();
        }

        private void populate()
        {
            Con.Open();
            string Query = "select * from PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PatientDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(PatNameTb.Text=="" || PatAgeTb.Text=="" || PatGenCb.SelectedIndex== -1 || PatPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PatientTbl values('" + PatNameTb.Text + "'," + PatAgeTb.Text + ",'" + PatGenCb.SelectedItem.ToString() + "','" + PatPhoneTb.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Saved Successfully");
                    Con.Close();
                    populate();
                    reset(); 
                }
                catch(Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
                
            }
            
        }

        int key = 0;
        private void PatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatNameTb.Text = PatientDGV.SelectedRows[0].Cells[1].Value.ToString();
            PatAgeTb.Text = PatientDGV.SelectedRows[0].Cells[2].Value.ToString();
            PatGenCb.SelectedItem = PatientDGV.SelectedRows[0].Cells[3].Value.ToString();
            PatPhoneTb.Text = PatientDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (PatNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatientDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void reset()
        {
            PatNameTb.Text = "";
            PatAgeTb.Text = "";
            PatPhoneTb.Text = "";
            PatGenCb.SelectedIndex = -1;
            key = 0;
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Patient to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from PatientTbl where PatId="+key+";", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Deleted Successfully");
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

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (PatNameTb.Text == "" || PatAgeTb.Text == "" || PatGenCb.SelectedIndex == -1 || PatPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Query = "update PatientTbl set PatName = '" + PatNameTb.Text + "', Age=" + PatAgeTb.Text + ", Sex='" + PatGenCb.SelectedItem.ToString() + "', Phone='" + PatPhoneTb.Text + "' where PatId="+key+";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Updated Successfully"); 
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

        private void label5_Click(object sender, EventArgs e)
        {
            Invoices Obj = new Invoices();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DashBoard Obj = new DashBoard();
            Obj.Show();
            this.Hide();
        }
    }
}
