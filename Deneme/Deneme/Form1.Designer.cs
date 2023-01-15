namespace Deneme
{
    partial class Form1
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
            this.gbSelectColumns = new System.Windows.Forms.GroupBox();
            this.cbCompany = new System.Windows.Forms.CheckBox();
            this.cbIssue = new System.Windows.Forms.CheckBox();
            this.cbProduct = new System.Windows.Forms.CheckBox();
            this.gbSelectThread = new System.Windows.Forms.GroupBox();
            this.nudThread = new System.Windows.Forms.NumericUpDown();
            this.btnCalistir = new System.Windows.Forms.Button();
            this.gbSelectSampleRate = new System.Windows.Forms.GroupBox();
            this.nudSelectRate = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbComplaintIDTable = new System.Windows.Forms.CheckBox();
            this.cbCompanyTable = new System.Windows.Forms.CheckBox();
            this.cbZIPCodeTable = new System.Windows.Forms.CheckBox();
            this.cbIssueTable = new System.Windows.Forms.CheckBox();
            this.cbStateTable = new System.Windows.Forms.CheckBox();
            this.cbProductTable = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combSearchAs = new System.Windows.Forms.ComboBox();
            this.combComplaintID = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.threadSonucTxt = new System.Windows.Forms.Label();
            this.dgvTable2 = new Code4Bugs.SimpleDataGridViewPaging.DataGridViewPaging();
            this.gbSelectColumns.SuspendLayout();
            this.gbSelectThread.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThread)).BeginInit();
            this.gbSelectSampleRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectRate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSelectColumns
            // 
            this.gbSelectColumns.Controls.Add(this.cbCompany);
            this.gbSelectColumns.Controls.Add(this.cbIssue);
            this.gbSelectColumns.Controls.Add(this.cbProduct);
            this.gbSelectColumns.Location = new System.Drawing.Point(12, 12);
            this.gbSelectColumns.Name = "gbSelectColumns";
            this.gbSelectColumns.Size = new System.Drawing.Size(114, 90);
            this.gbSelectColumns.TabIndex = 0;
            this.gbSelectColumns.TabStop = false;
            this.gbSelectColumns.Text = "Select Columns";
            // 
            // cbCompany
            // 
            this.cbCompany.AutoSize = true;
            this.cbCompany.Location = new System.Drawing.Point(6, 65);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(70, 17);
            this.cbCompany.TabIndex = 0;
            this.cbCompany.Text = "Company";
            this.cbCompany.UseVisualStyleBackColor = true;
            // 
            // cbIssue
            // 
            this.cbIssue.AutoSize = true;
            this.cbIssue.Location = new System.Drawing.Point(6, 42);
            this.cbIssue.Name = "cbIssue";
            this.cbIssue.Size = new System.Drawing.Size(51, 17);
            this.cbIssue.TabIndex = 0;
            this.cbIssue.Text = "Issue";
            this.cbIssue.UseVisualStyleBackColor = true;
            // 
            // cbProduct
            // 
            this.cbProduct.AutoSize = true;
            this.cbProduct.Location = new System.Drawing.Point(6, 19);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(63, 17);
            this.cbProduct.TabIndex = 0;
            this.cbProduct.Text = "Product";
            this.cbProduct.UseVisualStyleBackColor = true;
            // 
            // gbSelectThread
            // 
            this.gbSelectThread.Controls.Add(this.nudThread);
            this.gbSelectThread.Location = new System.Drawing.Point(132, 12);
            this.gbSelectThread.Name = "gbSelectThread";
            this.gbSelectThread.Size = new System.Drawing.Size(130, 90);
            this.gbSelectThread.TabIndex = 0;
            this.gbSelectThread.TabStop = false;
            this.gbSelectThread.Text = "Select Thread Count";
            // 
            // nudThread
            // 
            this.nudThread.Location = new System.Drawing.Point(6, 39);
            this.nudThread.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThread.Name = "nudThread";
            this.nudThread.Size = new System.Drawing.Size(120, 20);
            this.nudThread.TabIndex = 0;
            this.nudThread.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnCalistir
            // 
            this.btnCalistir.Location = new System.Drawing.Point(18, 108);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(108, 35);
            this.btnCalistir.TabIndex = 1;
            this.btnCalistir.Text = "Çalıştır";
            this.btnCalistir.UseVisualStyleBackColor = true;
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_ClickAsync);
            // 
            // gbSelectSampleRate
            // 
            this.gbSelectSampleRate.Controls.Add(this.nudSelectRate);
            this.gbSelectSampleRate.Location = new System.Drawing.Point(268, 12);
            this.gbSelectSampleRate.Name = "gbSelectSampleRate";
            this.gbSelectSampleRate.Size = new System.Drawing.Size(130, 90);
            this.gbSelectSampleRate.TabIndex = 0;
            this.gbSelectSampleRate.TabStop = false;
            this.gbSelectSampleRate.Text = "Select Sample Rate";
            // 
            // nudSelectRate
            // 
            this.nudSelectRate.DecimalPlaces = 1;
            this.nudSelectRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSelectRate.Location = new System.Drawing.Point(6, 39);
            this.nudSelectRate.Name = "nudSelectRate";
            this.nudSelectRate.Size = new System.Drawing.Size(120, 20);
            this.nudSelectRate.TabIndex = 0;
            this.nudSelectRate.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbComplaintIDTable);
            this.groupBox1.Controls.Add(this.cbCompanyTable);
            this.groupBox1.Controls.Add(this.cbZIPCodeTable);
            this.groupBox1.Controls.Add(this.cbIssueTable);
            this.groupBox1.Controls.Add(this.cbStateTable);
            this.groupBox1.Controls.Add(this.cbProductTable);
            this.groupBox1.Location = new System.Drawing.Point(404, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Columns";
            // 
            // cbComplaintIDTable
            // 
            this.cbComplaintIDTable.AutoSize = true;
            this.cbComplaintIDTable.Checked = true;
            this.cbComplaintIDTable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbComplaintIDTable.Location = new System.Drawing.Point(75, 65);
            this.cbComplaintIDTable.Name = "cbComplaintIDTable";
            this.cbComplaintIDTable.Size = new System.Drawing.Size(83, 17);
            this.cbComplaintIDTable.TabIndex = 0;
            this.cbComplaintIDTable.Text = "ComplaintID";
            this.cbComplaintIDTable.UseVisualStyleBackColor = true;
            // 
            // cbCompanyTable
            // 
            this.cbCompanyTable.AutoSize = true;
            this.cbCompanyTable.Checked = true;
            this.cbCompanyTable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCompanyTable.Location = new System.Drawing.Point(6, 65);
            this.cbCompanyTable.Name = "cbCompanyTable";
            this.cbCompanyTable.Size = new System.Drawing.Size(70, 17);
            this.cbCompanyTable.TabIndex = 0;
            this.cbCompanyTable.Text = "Company";
            this.cbCompanyTable.UseVisualStyleBackColor = true;
            // 
            // cbZIPCodeTable
            // 
            this.cbZIPCodeTable.AutoSize = true;
            this.cbZIPCodeTable.Checked = true;
            this.cbZIPCodeTable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbZIPCodeTable.Location = new System.Drawing.Point(75, 42);
            this.cbZIPCodeTable.Name = "cbZIPCodeTable";
            this.cbZIPCodeTable.Size = new System.Drawing.Size(68, 17);
            this.cbZIPCodeTable.TabIndex = 0;
            this.cbZIPCodeTable.Text = "ZIPCode";
            this.cbZIPCodeTable.UseVisualStyleBackColor = true;
            // 
            // cbIssueTable
            // 
            this.cbIssueTable.AutoSize = true;
            this.cbIssueTable.Checked = true;
            this.cbIssueTable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIssueTable.Location = new System.Drawing.Point(6, 42);
            this.cbIssueTable.Name = "cbIssueTable";
            this.cbIssueTable.Size = new System.Drawing.Size(51, 17);
            this.cbIssueTable.TabIndex = 0;
            this.cbIssueTable.Text = "Issue";
            this.cbIssueTable.UseVisualStyleBackColor = true;
            // 
            // cbStateTable
            // 
            this.cbStateTable.AutoSize = true;
            this.cbStateTable.Checked = true;
            this.cbStateTable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStateTable.Location = new System.Drawing.Point(75, 19);
            this.cbStateTable.Name = "cbStateTable";
            this.cbStateTable.Size = new System.Drawing.Size(51, 17);
            this.cbStateTable.TabIndex = 0;
            this.cbStateTable.Text = "State";
            this.cbStateTable.UseVisualStyleBackColor = true;
            // 
            // cbProductTable
            // 
            this.cbProductTable.AutoSize = true;
            this.cbProductTable.Checked = true;
            this.cbProductTable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbProductTable.Location = new System.Drawing.Point(6, 19);
            this.cbProductTable.Name = "cbProductTable";
            this.cbProductTable.Size = new System.Drawing.Size(63, 17);
            this.cbProductTable.TabIndex = 0;
            this.cbProductTable.Text = "Product";
            this.cbProductTable.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combSearchAs);
            this.groupBox2.Controls.Add(this.combComplaintID);
            this.groupBox2.Location = new System.Drawing.Point(586, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 90);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Complaint ID";
            // 
            // combSearchAs
            // 
            this.combSearchAs.FormattingEnabled = true;
            this.combSearchAs.Items.AddRange(new object[] {
            "Product",
            "Issue",
            "Company",
            "ComplaintID"});
            this.combSearchAs.Location = new System.Drawing.Point(6, 32);
            this.combSearchAs.Name = "combSearchAs";
            this.combSearchAs.Size = new System.Drawing.Size(121, 21);
            this.combSearchAs.TabIndex = 0;
            this.combSearchAs.SelectedIndexChanged += new System.EventHandler(this.combSearchAs_SelectedIndexChanged);
            // 
            // combComplaintID
            // 
            this.combComplaintID.FormattingEnabled = true;
            this.combComplaintID.Location = new System.Drawing.Point(6, 59);
            this.combComplaintID.Name = "combComplaintID";
            this.combComplaintID.Size = new System.Drawing.Size(121, 21);
            this.combComplaintID.TabIndex = 0;
            this.combComplaintID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.threadSonucTxt);
            this.panel1.Location = new System.Drawing.Point(732, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 131);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sonuçlar:";
            // 
            // threadSonucTxt
            // 
            this.threadSonucTxt.AutoSize = true;
            this.threadSonucTxt.Location = new System.Drawing.Point(62, 10);
            this.threadSonucTxt.Name = "threadSonucTxt";
            this.threadSonucTxt.Size = new System.Drawing.Size(0, 13);
            this.threadSonucTxt.TabIndex = 0;
            // 
            // dgvTable2
            // 
            this.dgvTable2.AutoHideNavigator = true;
            this.dgvTable2.DataSource = null;
            this.dgvTable2.DbRequestHandler = null;
            this.dgvTable2.Location = new System.Drawing.Point(12, 149);
            this.dgvTable2.MaxRecords = 50;
            this.dgvTable2.Name = "dgvTable2";
            this.dgvTable2.NavigatorHorizontal = Code4Bugs.SimpleDataGridViewPaging.NavigatorHorizontal.Default;
            this.dgvTable2.Size = new System.Drawing.Size(1294, 369);
            this.dgvTable2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 530);
            this.Controls.Add(this.dgvTable2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalistir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbSelectSampleRate);
            this.Controls.Add(this.gbSelectThread);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSelectColumns);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSelectColumns.ResumeLayout(false);
            this.gbSelectColumns.PerformLayout();
            this.gbSelectThread.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudThread)).EndInit();
            this.gbSelectSampleRate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectRate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelectColumns;
        private System.Windows.Forms.CheckBox cbCompany;
        private System.Windows.Forms.CheckBox cbIssue;
        private System.Windows.Forms.CheckBox cbProduct;
        private System.Windows.Forms.GroupBox gbSelectThread;
        private System.Windows.Forms.NumericUpDown nudThread;
        private System.Windows.Forms.Button btnCalistir;
        private System.Windows.Forms.GroupBox gbSelectSampleRate;
        private System.Windows.Forms.NumericUpDown nudSelectRate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbComplaintIDTable;
        private System.Windows.Forms.CheckBox cbCompanyTable;
        private System.Windows.Forms.CheckBox cbZIPCodeTable;
        private System.Windows.Forms.CheckBox cbIssueTable;
        private System.Windows.Forms.CheckBox cbStateTable;
        private System.Windows.Forms.CheckBox cbProductTable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox combComplaintID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label threadSonucTxt;
        private Code4Bugs.SimpleDataGridViewPaging.DataGridViewPaging dgvTable2;
        private System.Windows.Forms.ComboBox combSearchAs;
        private System.Windows.Forms.Label label1;
    }
}

