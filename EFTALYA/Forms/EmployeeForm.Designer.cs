namespace EFTALYA.Forms
{
    partial class EmployeeForm
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
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmployeePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployeeLastname = new System.Windows.Forms.TextBox();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdEmployee = new System.Windows.Forms.DataGridView();
            this.grpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.btnNew);
            this.grpEmployee.Controls.Add(this.btnDelete);
            this.grpEmployee.Controls.Add(this.btnUpdate);
            this.grpEmployee.Controls.Add(this.btnSave);
            this.grpEmployee.Controls.Add(this.txtEmployeePassword);
            this.grpEmployee.Controls.Add(this.label4);
            this.grpEmployee.Controls.Add(this.txtEmployeeLastname);
            this.grpEmployee.Controls.Add(this.txtEmployeeEmail);
            this.grpEmployee.Controls.Add(this.label2);
            this.grpEmployee.Controls.Add(this.label3);
            this.grpEmployee.Controls.Add(this.txtEmployeeName);
            this.grpEmployee.Controls.Add(this.label1);
            this.grpEmployee.Location = new System.Drawing.Point(12, 12);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(889, 172);
            this.grpEmployee.TabIndex = 6;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Employee";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(609, 134);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(274, 31);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(609, 97);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(274, 31);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(609, 59);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(274, 31);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(609, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(274, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmployeePassword
            // 
            this.txtEmployeePassword.Location = new System.Drawing.Point(79, 136);
            this.txtEmployeePassword.Name = "txtEmployeePassword";
            this.txtEmployeePassword.Size = new System.Drawing.Size(488, 20);
            this.txtEmployeePassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password:";
            // 
            // txtEmployeeLastname
            // 
            this.txtEmployeeLastname.Location = new System.Drawing.Point(79, 59);
            this.txtEmployeeLastname.Name = "txtEmployeeLastname";
            this.txtEmployeeLastname.Size = new System.Drawing.Size(488, 20);
            this.txtEmployeeLastname.TabIndex = 3;
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Location = new System.Drawing.Point(79, 101);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(488, 20);
            this.txtEmployeeEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "E-Mail:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(79, 19);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(488, 20);
            this.txtEmployeeName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // grdEmployee
            // 
            this.grdEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployee.Location = new System.Drawing.Point(12, 190);
            this.grdEmployee.Name = "grdEmployee";
            this.grdEmployee.ReadOnly = true;
            this.grdEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmployee.Size = new System.Drawing.Size(889, 260);
            this.grdEmployee.TabIndex = 5;
            this.grdEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEmployee_CellClick);
            this.grdEmployee.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdEmployee_DataBindingComplete);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 468);
            this.Controls.Add(this.grpEmployee);
            this.Controls.Add(this.grdEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmployeePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmployeeLastname;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdEmployee;
    }
}