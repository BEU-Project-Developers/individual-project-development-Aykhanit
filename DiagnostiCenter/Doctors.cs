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
                    SqlCommand cmd = new SqlCommand("insert into DoctorTbl values('" + DocNameTb.Text + "','" + DocDOB.Value.Date.ToString("MM.dd.yyyy") + "','" + DocPhoneTb.Text + "','" + DocAddressTb.Text + "','"+DesignationCb.SelectedItem.ToString()+"','"+DocJoinDate.Value.Date.ToString("MM.dd.yyyy") +"')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Saved Successfully");
                    Con.Close();
                    populate();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Doctor to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from DoctorTbl where DocId=" + key + ";", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Deleted Successfully");
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

        int key = 0;
        private void DOCDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocNameTb.Text = DOCDGV.SelectedRows[0].Cells[1].Value.ToString();
            DocDOB.Text = DOCDGV.SelectedRows[0].Cells[2].Value.ToString();
            DocPhoneTb.Text = DOCDGV.SelectedRows[0].Cells[3].Value.ToString();
            DocAddressTb.Text = DOCDGV.SelectedRows[0].Cells[4].Value.ToString();
            DesignationCb.SelectedItem = DOCDGV.SelectedRows[0].Cells[5].Value.ToString();
            DocJoinDate.Text = DOCDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (DocNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DOCDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (DocNameTb.Text == "" || DocPhoneTb.Text == "" || DesignationCb.SelectedIndex == -1 || DocAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Query = "update DoctorTbl set DocName = '" + DocNameTb.Text + "', DOCDOB='" + DocDOB.Value.Date + "', DOCPHONE='" + DocPhoneTb.Text + "', DOCADD='" + DocAddressTb.Text + "', Designation='"+DesignationCb.SelectedItem.ToString()+"', JoinDate='"+DocJoinDate.Value.Date+"' where DocID=" + key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Updated Successfully");
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
