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
    public partial class Invoices : Form
    {
        public Invoices()
        {
            InitializeComponent();
            GetPatId();
            GetDocId();
            GetTestId();
        }
        private void label10_Click(object sender, EventArgs e)
        {
            
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Computer\Documents\DiagnosticDb.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void GetPatId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PatId from PatientTbl", Con);// Create SQL command to retrieve patient IDs
            SqlDataReader rdr;
            rdr=cmd.ExecuteReader(); //Executes the query using ExecuteReader(), which returns a SqlDataReader object to efficiently read data row by row.
            DataTable dt = new DataTable();//Creates a DataTable object to hold the retrieved patient IDs.
            dt.Columns.Add("PatId", typeof(int));//Explicitly add column for clarity
            dt.Load(rdr);//// Load data from reader into table
            PatientCb.ValueMember = "PatId";// Set unique value member
            PatientCb.DataSource = dt;//// Bind data source for display
            Con.Close();
        }
        private void GetTestId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TestId from TestTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TestId", typeof(int));
            dt.Load(rdr);
            TestIdCb.ValueMember = "TestId";
            TestIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetDocId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select DocName from DoctorTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DocName", typeof(string));
            dt.Load(rdr);
            ReferedCb.ValueMember = "DocName";
            ReferedCb.DataSource = dt;
            Con.Close();
        }
        private void GetPatData()
        {
            Con.Open();
            string mysql = "select * from PatientTbl where PatId=" + PatientCb.SelectedValue.ToString() + "";
            SqlCommand cmd= new SqlCommand(mysql, Con);
            DataTable dt=new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatientNameTb.Text= dr["PatName"].ToString();
                PhoneTb.Text = dr["Phone"].ToString();
            }
            Con.Close();
        }
        int Cost;
        private void GetTestData()
        {
            Con.Open();
            string mysql = "select * from TestTbl where TestId=" + TestIdCb.SelectedValue.ToString() + "";//// Construct SQL query based on selected test ID
            //Create command and data adapter
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();//// Create data table to hold retrieved data
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);// Fill data table with query results
            foreach (DataRow dr in dt.Rows)
            {
                TestNameTb.Text = dr["TestDesc"].ToString();
                Cost = Convert.ToInt32(dr["TestCost"].ToString());
            }
            Con.Close();
        }
        private void reset()
        {
            PatientNameTb.Text = "";
            PhoneTb.Text = "";
            TotalLbl.Text = "Total";
            Grdtotal = 0;
        }
        private void SaveInvoiceBtn_Click(object sender, EventArgs e)
        {
            if (PatientCb.SelectedIndex == -1 || ReferedCb.SelectedIndex == -1 || TotalLbl.Text == "Total")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into InvoiceTbl values(" + PatientCb.SelectedValue.ToString() + ",'" + PatientNameTb.Text + "','" + PhoneTb.Text + "','" + DelDate.Value.Date.ToString("MM.dd.yyyy") + "','"+ReferedCb.SelectedValue.ToString()+"',"+Grdtotal+")", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Invoice Saved Successfully");
                    Con.Close();
                    reset();
                   
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }

            }
        }

        private void PatientCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPatData();
        }

        private void TestIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTestData();
        }

        int n = 0,Grdtotal=0;

        private void label1_Click(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
            Obj.Show();
            this.Hide();
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

        private void label6_Click(object sender, EventArgs e)
        {
            DashBoard Obj = new DashBoard();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        { 
            if (TestNameTb.Text == "")
            {
                MessageBox.Show("Select The Test");
            }
            else
            {
                DataGridViewRow newRow= new DataGridViewRow();
                newRow.CreateCells(TestDGV);
                newRow.Cells[0].Value = n+1;
                newRow.Cells[1].Value=TestNameTb.Text;
                newRow.Cells[2].Value = Cost;
                TestDGV.Rows.Add(newRow);
                n++;
                Grdtotal=Grdtotal+Cost;
                TotalLbl.Text = "Total: "+Grdtotal;
            }
        }
    }
}
