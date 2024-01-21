using System;
using System.Windows.Forms;

namespace DiagnostiCenter
{
    partial class Invoices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoices));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PatientCb = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PatientNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DelDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.PhoneTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PrintBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SaveInvoiceBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label10 = new System.Windows.Forms.Label();
            this.TestDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ReferedCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TestIdCb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TestNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TotalLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TestDGV)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Crimson;
            this.label16.Location = new System.Drawing.Point(697, 389);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 34);
            this.label16.TabIndex = 27;
            this.label16.Text = "Tests List";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Crimson;
            this.label15.Location = new System.Drawing.Point(431, -1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(219, 34);
            this.label15.TabIndex = 6;
            this.label15.Text = "Doctors Details";
            // 
            // PatientCb
            // 
            this.PatientCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientCb.FormattingEnabled = true;
            this.PatientCb.Location = new System.Drawing.Point(228, 107);
            this.PatientCb.Name = "PatientCb";
            this.PatientCb.Size = new System.Drawing.Size(180, 31);
            this.PatientCb.TabIndex = 17;
            this.PatientCb.SelectionChangeCommitted += new System.EventHandler(this.PatientCb_SelectionChangeCommitted);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label13.Location = new System.Drawing.Point(224, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 23);
            this.label13.TabIndex = 16;
            this.label13.Text = "Patient ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label12.Location = new System.Drawing.Point(433, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Patient Name";
            // 
            // PatientNameTb
            // 
            this.PatientNameTb.BackColor = System.Drawing.Color.White;
            this.PatientNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientNameTb.Enabled = false;
            this.PatientNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameTb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.PatientNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.PatientNameTb.HintText = "";
            this.PatientNameTb.isPassword = false;
            this.PatientNameTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.PatientNameTb.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.PatientNameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PatientNameTb.LineThickness = 3;
            this.PatientNameTb.Location = new System.Drawing.Point(437, 95);
            this.PatientNameTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PatientNameTb.Name = "PatientNameTb";
            this.PatientNameTb.Size = new System.Drawing.Size(242, 43);
            this.PatientNameTb.TabIndex = 11;
            this.PatientNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DelDate
            // 
            this.DelDate.CalendarFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DelDate.Location = new System.Drawing.Point(569, 192);
            this.DelDate.Name = "DelDate";
            this.DelDate.Size = new System.Drawing.Size(155, 32);
            this.DelDate.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(711, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Phone";
            // 
            // PhoneTb
            // 
            this.PhoneTb.BackColor = System.Drawing.Color.White;
            this.PhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTb.Enabled = false;
            this.PhoneTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.PhoneTb.HintForeColor = System.Drawing.Color.Empty;
            this.PhoneTb.HintText = "";
            this.PhoneTb.isPassword = false;
            this.PhoneTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.PhoneTb.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.PhoneTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PhoneTb.LineThickness = 3;
            this.PhoneTb.Location = new System.Drawing.Point(715, 95);
            this.PhoneTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(242, 44);
            this.PhoneTb.TabIndex = 0;
            this.PhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PrintBtn
            // 
            this.PrintBtn.ActiveBorderThickness = 1;
            this.PrintBtn.ActiveCornerRadius = 20;
            this.PrintBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.PrintBtn.ActiveForecolor = System.Drawing.Color.White;
            this.PrintBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.PrintBtn.BackColor = System.Drawing.SystemColors.Control;
            this.PrintBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PrintBtn.BackgroundImage")));
            this.PrintBtn.ButtonText = "Print";
            this.PrintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.PrintBtn.IdleBorderThickness = 1;
            this.PrintBtn.IdleCornerRadius = 20;
            this.PrintBtn.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.PrintBtn.IdleForecolor = System.Drawing.Color.White;
            this.PrintBtn.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.PrintBtn.Location = new System.Drawing.Point(1162, 699);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(5);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(179, 56);
            this.PrintBtn.TabIndex = 25;
            this.PrintBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveInvoiceBtn
            // 
            this.SaveInvoiceBtn.ActiveBorderThickness = 1;
            this.SaveInvoiceBtn.ActiveCornerRadius = 20;
            this.SaveInvoiceBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.SaveInvoiceBtn.ActiveForecolor = System.Drawing.Color.White;
            this.SaveInvoiceBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.SaveInvoiceBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SaveInvoiceBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveInvoiceBtn.BackgroundImage")));
            this.SaveInvoiceBtn.ButtonText = "Save Invoice";
            this.SaveInvoiceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveInvoiceBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveInvoiceBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.SaveInvoiceBtn.IdleBorderThickness = 1;
            this.SaveInvoiceBtn.IdleCornerRadius = 20;
            this.SaveInvoiceBtn.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveInvoiceBtn.IdleForecolor = System.Drawing.Color.White;
            this.SaveInvoiceBtn.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveInvoiceBtn.Location = new System.Drawing.Point(679, 319);
            this.SaveInvoiceBtn.Margin = new System.Windows.Forms.Padding(5);
            this.SaveInvoiceBtn.Name = "SaveInvoiceBtn";
            this.SaveInvoiceBtn.Size = new System.Drawing.Size(188, 56);
            this.SaveInvoiceBtn.TabIndex = 24;
            this.SaveInvoiceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveInvoiceBtn.Click += new System.EventHandler(this.SaveInvoiceBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.ActiveBorderThickness = 1;
            this.AddBtn.ActiveCornerRadius = 20;
            this.AddBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.AddBtn.ActiveForecolor = System.Drawing.Color.White;
            this.AddBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.AddBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.ButtonText = "Add Test";
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddBtn.IdleBorderThickness = 1;
            this.AddBtn.IdleCornerRadius = 20;
            this.AddBtn.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.AddBtn.IdleForecolor = System.Drawing.Color.White;
            this.AddBtn.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.AddBtn.Location = new System.Drawing.Point(876, 449);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(149, 56);
            this.AddBtn.TabIndex = 23;
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.Location = new System.Drawing.Point(565, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Delivery Date";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // TestDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TestDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TestDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TestDGV.BackgroundColor = System.Drawing.Color.White;
            this.TestDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TestDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TestDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TestDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TestDGV.ColumnHeadersHeight = 28;
            this.TestDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TestDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.TestDGV.EnableHeadersVisualStyles = false;
            this.TestDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TestDGV.Location = new System.Drawing.Point(241, 513);
            this.TestDGV.Name = "TestDGV";
            this.TestDGV.RowHeadersVisible = false;
            this.TestDGV.RowHeadersWidth = 51;
            this.TestDGV.RowTemplate.Height = 24;
            this.TestDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TestDGV.Size = new System.Drawing.Size(913, 234);
            this.TestDGV.TabIndex = 28;
            this.TestDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.TestDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TestDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TestDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TestDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TestDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TestDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TestDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TestDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TestDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TestDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TestDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TestDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.TestDGV.ThemeStyle.ReadOnly = false;
            this.TestDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TestDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TestDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TestDGV.ThemeStyle.RowsStyle.Height = 24;
            this.TestDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TestDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Description";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cost";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ReferedCb);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.PatientCb);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.PatientNameTb);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.DelDate);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.PhoneTb);
            this.panel4.Location = new System.Drawing.Point(241, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1100, 249);
            this.panel4.TabIndex = 22;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // ReferedCb
            // 
            this.ReferedCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferedCb.FormattingEnabled = true;
            this.ReferedCb.Location = new System.Drawing.Point(300, 192);
            this.ReferedCb.Name = "ReferedCb";
            this.ReferedCb.Size = new System.Drawing.Size(180, 31);
            this.ReferedCb.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(296, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Referred by";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 802);
            this.panel1.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(17, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(184, 23);
            this.label18.TabIndex = 13;
            this.label18.Text = "Diagnostic Center";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Crimson;
            this.label17.Location = new System.Drawing.Point(61, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 23);
            this.label17.TabIndex = 13;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(72, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(61, 80);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 710);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "Logout";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(19, 412);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 41);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(67, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dashboard";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(17, 347);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(65, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Test Invoice";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 284);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tests";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 221);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Patients";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(70, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 2);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Doctors";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(673, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 34);
            this.label2.TabIndex = 21;
            this.label2.Text = "Test Invoice";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1371, 10);
            this.panel2.TabIndex = 20;
            // 
            // TestIdCb
            // 
            this.TestIdCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestIdCb.FormattingEnabled = true;
            this.TestIdCb.Location = new System.Drawing.Point(353, 469);
            this.TestIdCb.Name = "TestIdCb";
            this.TestIdCb.Size = new System.Drawing.Size(180, 31);
            this.TestIdCb.TabIndex = 30;
            this.TestIdCb.SelectionChangeCommitted += new System.EventHandler(this.TestIdCb_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label11.Location = new System.Drawing.Point(349, 435);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "Patient ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label14.Location = new System.Drawing.Point(574, 435);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 23);
            this.label14.TabIndex = 32;
            this.label14.Text = "Patient Name";
            // 
            // TestNameTb
            // 
            this.TestNameTb.BackColor = System.Drawing.Color.White;
            this.TestNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TestNameTb.Enabled = false;
            this.TestNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNameTb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TestNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.TestNameTb.HintText = "";
            this.TestNameTb.isPassword = false;
            this.TestNameTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.TestNameTb.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.TestNameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TestNameTb.LineThickness = 3;
            this.TestNameTb.Location = new System.Drawing.Point(578, 462);
            this.TestNameTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TestNameTb.Name = "TestNameTb";
            this.TestNameTb.Size = new System.Drawing.Size(242, 43);
            this.TestNameTb.TabIndex = 31;
            this.TestNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.ForeColor = System.Drawing.Color.Crimson;
            this.TotalLbl.Location = new System.Drawing.Point(725, 750);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(78, 34);
            this.TotalLbl.TabIndex = 33;
            this.TotalLbl.Text = "Total";
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 812);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TestNameTb);
            this.Controls.Add(this.TestIdCb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.SaveInvoiceBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.TestDGV);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoices";
            ((System.ComponentModel.ISupportInitialize)(this.TestDGV)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox PatientCb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PatientNameTb;
        private System.Windows.Forms.DateTimePicker DelDate;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PhoneTb;
        private Bunifu.Framework.UI.BunifuThinButton2 PrintBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveInvoiceBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBtn;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DataGridView TestDGV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ReferedCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TestIdCb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TestNameTb;
        private System.Windows.Forms.Label TotalLbl;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}