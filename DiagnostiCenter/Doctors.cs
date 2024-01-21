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
        //calls the Patients form when clicked Patients label in the form
        private void label3_Click(object sender, EventArgs e)
        {
            Patients Obj = new Patients();
            Obj.Show();
            this.Hide();
        }

        //calls the Tests form when clicked Tests label in the form
        private void label4_Click(object sender, EventArgs e)
        {
            Tests Obj = new Tests();
            Obj.Show();
            this.Hide();
        }
        //connect the database
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Computer\Documents\DiagnosticDb.mdf;Integrated Security=True;Connect Timeout=30");


        //the method retrieves data from table and fill DataSet with data. Also connect DataSet table to DOCDGV(data grid view) for showing in the form.
        private void populate()
        {
            Con.Open();//    // Open database connection
            string Query = "select * from DoctorTbl";// Construct SQL query to retrieve all doctors
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);//Create data adapter and command builder to enable updates
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();//Create dataset to hold retrieved data
            sda.Fill(ds);// Fill dataset with query results
            DOCDGV.DataSource = ds.Tables[0];// Assign first table in dataset as data source for DataGridView
            Con.Close();//close database connection
        }

        // creates method to clear input fields, preparing for a new entry
        private void reset()
        {
            DocNameTb.Text = "";
            DocPhoneTb.Text = "";
            DocAddressTb.Text = "";
            DesignationCb.SelectedIndex = -1;
        }

        //save the entered data without missing information. Also it handles the possible errors with try/catch method.
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
                    Con.Open();//opens database connection
                    SqlCommand cmd = new SqlCommand("insert into DoctorTbl values('" + DocNameTb.Text + "','" + DocDOB.Value.Date.ToString("MM.dd.yyyy") + "','" + DocPhoneTb.Text + "','" + DocAddressTb.Text + "','"+DesignationCb.SelectedItem.ToString()+"','"+DocJoinDate.Value.Date.ToString("MM.dd.yyyy") +"')", Con);
                    cmd.ExecuteNonQuery();//executes an SQL query that doesn't return any rows of data.
                    MessageBox.Show("Doctor Saved Successfully");
                    Con.Close();//closes database connection
                    populate();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        //delete selected row or data from table
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

        //calls the reset method when click ResetBtn
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        int key = 0;

        //the code populate automatically input fields with selected row data
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
                    // Construct SQL query using parameters 
                    string Query = "update DoctorTbl set DocName = '" + DocNameTb.Text + "', DOCDOB='" + DocDOB.Value.Date + "', DOCPHONE='" + DocPhoneTb.Text + "', DOCADD='" + DocAddressTb.Text + "', Designation='"+DesignationCb.SelectedItem.ToString()+"', JoinDate='"+DocJoinDate.Value.Date+"' where DocID=" + key + ";";
                    Con.Open();//opens database connection
                    SqlCommand cmd = new SqlCommand(Query, Con);//Creates a SqlCommand object and executes the query to perform the update in the database.
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Updated Successfully");
                    Con.Close();//Closes database connection:
                    populate();////Refresh displayed data
                    reset();//// Clear input fields
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

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();//exits application when Log Out label clicked.
        }
    }
}
