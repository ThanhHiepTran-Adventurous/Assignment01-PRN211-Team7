namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbRoleID = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtRoleID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSortNameDesc = new System.Windows.Forms.Button();
            this.txtsearchid = new System.Windows.Forms.TextBox();
            this.txtTypeSearchMemberName = new System.Windows.Forms.TextBox();
            this.lbFindMemberById = new System.Windows.Forms.Label();
            this.lbFindMemberName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.cbxCountry = new System.Windows.Forms.ComboBox();
            this.lbFilterCity = new System.Windows.Forms.Label();
            this.lbFilterCountry = new System.Windows.Forms.Label();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.lbCountry);
            this.groupBox1.Controls.Add(this.lbCity);
            this.groupBox1.Controls.Add(this.lbRoleID);
            this.groupBox1.Controls.Add(this.lbPassword);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtRoleID);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtMemberName);
            this.groupBox1.Controls.Add(this.lbMemberName);
            this.groupBox1.Controls.Add(this.txtMemberID);
            this.groupBox1.Controls.Add(this.lbMemberID);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infomation Member";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLoad.Location = new System.Drawing.Point(657, 266);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(116, 44);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(470, 266);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 44);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNew.Location = new System.Drawing.Point(269, 266);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(116, 44);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(540, 164);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 13;
            this.lbEmail.Text = "Email";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(540, 114);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 12;
            this.lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(540, 60);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 11;
            this.lbCity.Text = "City";
            // 
            // lbRoleID
            // 
            this.lbRoleID.AutoSize = true;
            this.lbRoleID.Location = new System.Drawing.Point(16, 219);
            this.lbRoleID.Name = "lbRoleID";
            this.lbRoleID.Size = new System.Drawing.Size(58, 20);
            this.lbRoleID.TabIndex = 10;
            this.lbRoleID.Text = "Role ID";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(16, 161);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 9;
            this.lbPassword.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(693, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(267, 27);
            this.txtEmail.TabIndex = 8;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(693, 107);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(267, 27);
            this.txtCountry.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(693, 53);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(267, 27);
            this.txtCity.TabIndex = 6;
            // 
            // txtRoleID
            // 
            this.txtRoleID.Location = new System.Drawing.Point(131, 212);
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.Size = new System.Drawing.Size(222, 27);
            this.txtRoleID.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(131, 158);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(222, 27);
            this.txtPassword.TabIndex = 4;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(131, 104);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(222, 27);
            this.txtMemberName.TabIndex = 3;
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(16, 107);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(109, 20);
            this.lbMemberName.TabIndex = 2;
            this.lbMemberName.Text = "Member Name";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(131, 50);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(222, 27);
            this.txtMemberID.TabIndex = 1;
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(16, 53);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(80, 20);
            this.lbMemberID.TabIndex = 0;
            this.lbMemberID.Text = "MemberID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSortNameDesc);
            this.groupBox2.Controls.Add(this.txtsearchid);
            this.groupBox2.Controls.Add(this.txtTypeSearchMemberName);
            this.groupBox2.Controls.Add(this.lbFindMemberById);
            this.groupBox2.Controls.Add(this.lbFindMemberName);
            this.groupBox2.Location = new System.Drawing.Point(12, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find By Id and Name";
            // 
            // btnSortNameDesc
            // 
            this.btnSortNameDesc.Location = new System.Drawing.Point(402, 106);
            this.btnSortNameDesc.Name = "btnSortNameDesc";
            this.btnSortNameDesc.Size = new System.Drawing.Size(126, 29);
            this.btnSortNameDesc.TabIndex = 5;
            this.btnSortNameDesc.Text = "SortNameDesc";
            this.btnSortNameDesc.UseVisualStyleBackColor = true;
            this.btnSortNameDesc.Click += new System.EventHandler(this.btnSortNameDesc_Click);
            // 
            // txtsearchid
            // 
            this.txtsearchid.Location = new System.Drawing.Point(124, 103);
            this.txtsearchid.Name = "txtsearchid";
            this.txtsearchid.Size = new System.Drawing.Size(222, 27);
            this.txtsearchid.TabIndex = 4;
            this.txtsearchid.TextChanged += new System.EventHandler(this.txtsearchid_TextChanged);
            // 
            // txtTypeSearchMemberName
            // 
            this.txtTypeSearchMemberName.Location = new System.Drawing.Point(124, 48);
            this.txtTypeSearchMemberName.Name = "txtTypeSearchMemberName";
            this.txtTypeSearchMemberName.Size = new System.Drawing.Size(222, 27);
            this.txtTypeSearchMemberName.TabIndex = 3;
            this.txtTypeSearchMemberName.TextChanged += new System.EventHandler(this.txtTypeSearchMemberName_TextChanged);
            // 
            // lbFindMemberById
            // 
            this.lbFindMemberById.AutoSize = true;
            this.lbFindMemberById.Location = new System.Drawing.Point(16, 106);
            this.lbFindMemberById.Name = "lbFindMemberById";
            this.lbFindMemberById.Size = new System.Drawing.Size(84, 20);
            this.lbFindMemberById.TabIndex = 2;
            this.lbFindMemberById.Text = "Member ID";
            // 
            // lbFindMemberName
            // 
            this.lbFindMemberName.AutoSize = true;
            this.lbFindMemberName.Location = new System.Drawing.Point(16, 48);
            this.lbFindMemberName.Name = "lbFindMemberName";
            this.lbFindMemberName.Size = new System.Drawing.Size(109, 20);
            this.lbFindMemberName.TabIndex = 1;
            this.lbFindMemberName.Text = "Member Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxCity);
            this.groupBox3.Controls.Add(this.cbxCountry);
            this.groupBox3.Controls.Add(this.lbFilterCity);
            this.groupBox3.Controls.Add(this.lbFilterCountry);
            this.groupBox3.Location = new System.Drawing.Point(656, 385);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 148);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter By City And Country";
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Items.AddRange(new object[] {
            "Đà Nẵng",
            "Ninh Thuận",
            "Tiền Giang",
            "Osaka",
            "Kuala Lumpur",
            "Luang Prabang"});
            this.cbxCity.Location = new System.Drawing.Point(194, 84);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(152, 28);
            this.cbxCity.TabIndex = 5;
            this.cbxCity.SelectedIndexChanged += new System.EventHandler(this.cbxCity_SelectedIndexChanged);
            // 
            // cbxCountry
            // 
            this.cbxCountry.FormattingEnabled = true;
            this.cbxCountry.Items.AddRange(new object[] {
            "Việt Nam",
            "Japan",
            "Malaysia",
            "Laos",
            "ThaiLand",
            "South Korea",
            "North Korea"});
            this.cbxCountry.Location = new System.Drawing.Point(13, 84);
            this.cbxCountry.Name = "cbxCountry";
            this.cbxCountry.Size = new System.Drawing.Size(154, 28);
            this.cbxCountry.TabIndex = 4;
            this.cbxCountry.SelectedIndexChanged += new System.EventHandler(this.cbxCountry_SelectedIndexChanged);
            // 
            // lbFilterCity
            // 
            this.lbFilterCity.AutoSize = true;
            this.lbFilterCity.Location = new System.Drawing.Point(212, 41);
            this.lbFilterCity.Name = "lbFilterCity";
            this.lbFilterCity.Size = new System.Drawing.Size(71, 20);
            this.lbFilterCity.TabIndex = 3;
            this.lbFilterCity.Text = "Filter City";
            // 
            // lbFilterCountry
            // 
            this.lbFilterCountry.AutoSize = true;
            this.lbFilterCountry.Location = new System.Drawing.Point(13, 41);
            this.lbFilterCountry.Name = "lbFilterCountry";
            this.lbFilterCountry.Size = new System.Drawing.Size(97, 20);
            this.lbFilterCountry.TabIndex = 2;
            this.lbFilterCountry.Text = "Filter Country";
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(2, 560);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 29;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(1028, 241);
            this.dgvMemberList.TabIndex = 3;
            this.dgvMemberList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_CellContentClick);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Location = new System.Drawing.Point(914, 12);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(94, 29);
            this.btnCloseApp.TabIndex = 17;
            this.btnCloseApp.Text = "&Close App";
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 801);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMemberManagement";
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMemberID;
        private Label lbMemberID;
        private TextBox txtMemberName;
        private Label lbMemberName;
        private TextBox txtPassword;
        private TextBox txtRoleID;
        private TextBox txtEmail;
        private TextBox txtCountry;
        private TextBox txtCity;
        private Label lbEmail;
        private Label lbCountry;
        private Label lbCity;
        private Label lbRoleID;
        private Label lbPassword;
        private Button btnNew;
        private Button btnLoad;
        private Button btnDelete;
        private GroupBox groupBox2;
        private TextBox txtsearchid;
        private TextBox txtTypeSearchMemberName;
        private Label lbFindMemberById;
        private Label lbFindMemberName;
        private GroupBox groupBox3;
        private Button btnSortNameDesc;
        private Label lbFilterCity;
        private Label lbFilterCountry;
        private ComboBox cbxCity;
        private ComboBox cbxCountry;
        private DataGridView dgvMemberList;
        private Button btnCloseApp;
    }
}