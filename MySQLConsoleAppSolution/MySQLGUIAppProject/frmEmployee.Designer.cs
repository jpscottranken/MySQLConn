namespace MySQLGUIAppProject
{
    partial class frmEmployee
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
            this.gbEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtDepartmentCode = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDepartmentCode = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvSalesOrders = new System.Windows.Forms.DataGridView();
            this.gbEmployeeInfo.SuspendLayout();
            this.gbButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEmployeeInfo
            // 
            this.gbEmployeeInfo.BackColor = System.Drawing.Color.Blue;
            this.gbEmployeeInfo.Controls.Add(this.txtZipCode);
            this.gbEmployeeInfo.Controls.Add(this.txtState);
            this.gbEmployeeInfo.Controls.Add(this.txtFirstName);
            this.gbEmployeeInfo.Controls.Add(this.txtLastName);
            this.gbEmployeeInfo.Controls.Add(this.txtAddress);
            this.gbEmployeeInfo.Controls.Add(this.txtSalary);
            this.gbEmployeeInfo.Controls.Add(this.txtDepartmentCode);
            this.gbEmployeeInfo.Controls.Add(this.txtPhone);
            this.gbEmployeeInfo.Controls.Add(this.txtCity);
            this.gbEmployeeInfo.Controls.Add(this.txtID);
            this.gbEmployeeInfo.Controls.Add(this.label8);
            this.gbEmployeeInfo.Controls.Add(this.lblPhone);
            this.gbEmployeeInfo.Controls.Add(this.lblDepartmentCode);
            this.gbEmployeeInfo.Controls.Add(this.lblSalary);
            this.gbEmployeeInfo.Controls.Add(this.lblLastName);
            this.gbEmployeeInfo.Controls.Add(this.lblFirstName);
            this.gbEmployeeInfo.Controls.Add(this.lblAddress);
            this.gbEmployeeInfo.Controls.Add(this.lblID);
            this.gbEmployeeInfo.Location = new System.Drawing.Point(40, 12);
            this.gbEmployeeInfo.Name = "gbEmployeeInfo";
            this.gbEmployeeInfo.Size = new System.Drawing.Size(961, 505);
            this.gbEmployeeInfo.TabIndex = 0;
            this.gbEmployeeInfo.TabStop = false;
            this.gbEmployeeInfo.Text = "Employee Information";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.txtZipCode.Location = new System.Drawing.Point(734, 258);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(193, 32);
            this.txtZipCode.TabIndex = 6;
            this.txtZipCode.Tag = "zip";
            this.txtZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.txtState.Location = new System.Drawing.Point(626, 258);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(84, 32);
            this.txtState.TabIndex = 5;
            this.txtState.Tag = "state";
            this.txtState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.Location = new System.Drawing.Point(321, 83);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(606, 32);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Tag = "firstname";
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.txtLastName.Location = new System.Drawing.Point(321, 138);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(606, 32);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Tag = "lastname";
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.txtAddress.Location = new System.Drawing.Point(321, 195);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(606, 32);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Tag = "address";
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.txtSalary.Location = new System.Drawing.Point(321, 450);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(606, 32);
            this.txtSalary.TabIndex = 9;
            this.txtSalary.Tag = "salary";
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDepartmentCode
            // 
            this.txtDepartmentCode.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.txtDepartmentCode.Location = new System.Drawing.Point(321, 387);
            this.txtDepartmentCode.Name = "txtDepartmentCode";
            this.txtDepartmentCode.Size = new System.Drawing.Size(606, 32);
            this.txtDepartmentCode.TabIndex = 8;
            this.txtDepartmentCode.Tag = "deptcode";
            this.txtDepartmentCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.txtPhone.Location = new System.Drawing.Point(321, 324);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(606, 32);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.Tag = "phone";
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.txtCity.Location = new System.Drawing.Point(321, 258);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(284, 32);
            this.txtCity.TabIndex = 4;
            this.txtCity.Tag = "city";
            this.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.txtID.Location = new System.Drawing.Point(321, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(606, 32);
            this.txtID.TabIndex = 0;
            this.txtID.Tag = "id";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.label8.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label8.Location = new System.Drawing.Point(45, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 34);
            this.label8.TabIndex = 14;
            this.label8.Text = "Employee City, State, Zip:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblPhone.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblPhone.Location = new System.Drawing.Point(45, 322);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(257, 34);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Employee Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepartmentCode
            // 
            this.lblDepartmentCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblDepartmentCode.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.lblDepartmentCode.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblDepartmentCode.Location = new System.Drawing.Point(45, 385);
            this.lblDepartmentCode.Name = "lblDepartmentCode";
            this.lblDepartmentCode.Size = new System.Drawing.Size(257, 34);
            this.lblDepartmentCode.TabIndex = 16;
            this.lblDepartmentCode.Text = "Employee Dept Code:";
            this.lblDepartmentCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalary
            // 
            this.lblSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblSalary.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.lblSalary.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblSalary.Location = new System.Drawing.Point(45, 450);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(257, 34);
            this.lblSalary.TabIndex = 17;
            this.lblSalary.Text = "Employee Salary:";
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblLastName.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.lblLastName.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblLastName.Location = new System.Drawing.Point(45, 138);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(257, 34);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Employee Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblFirstName.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblFirstName.Location = new System.Drawing.Point(45, 86);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(257, 34);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "Employee First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblAddress.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblAddress.Location = new System.Drawing.Point(45, 195);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(257, 34);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Employee Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblID.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.lblID.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblID.Location = new System.Drawing.Point(45, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(257, 34);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "Employee ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbButtons
            // 
            this.gbButtons.BackColor = System.Drawing.Color.Blue;
            this.gbButtons.Controls.Add(this.txtSearch);
            this.gbButtons.Controls.Add(this.lblSearch);
            this.gbButtons.Controls.Add(this.btnExit);
            this.gbButtons.Controls.Add(this.btnClear);
            this.gbButtons.Controls.Add(this.btnDelete);
            this.gbButtons.Controls.Add(this.btnUpdate);
            this.gbButtons.Controls.Add(this.btnAdd);
            this.gbButtons.Location = new System.Drawing.Point(1022, 23);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(218, 494);
            this.gbButtons.TabIndex = 1;
            this.gbButtons.TabStop = false;
            this.gbButtons.Text = "groupBox2";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(19, 77);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(184, 32);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblSearch.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(16, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(187, 38);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Last Name Search:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(19, 427);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(175, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(19, 354);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(175, 44);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(19, 281);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(19, 208);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 44);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(19, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 44);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvSalesOrders
            // 
            this.dgvSalesOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesOrders.Location = new System.Drawing.Point(40, 535);
            this.dgvSalesOrders.Name = "dgvSalesOrders";
            this.dgvSalesOrders.Size = new System.Drawing.Size(1200, 255);
            this.dgvSalesOrders.TabIndex = 0;
            this.dgvSalesOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrders_CellClick);
            // 
            // frmEmployee
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1290, 802);
            this.Controls.Add(this.dgvSalesOrders);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.gbEmployeeInfo);
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesOrders Database - Employee Table Form";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.gbEmployeeInfo.ResumeLayout(false);
            this.gbEmployeeInfo.PerformLayout();
            this.gbButtons.ResumeLayout(false);
            this.gbButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmployeeInfo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvSalesOrders;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtDepartmentCode;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDepartmentCode;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}

