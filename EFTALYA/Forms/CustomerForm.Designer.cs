namespace EFTALYA.Forms
{
    partial class CustomerForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdCustomer = new System.Windows.Forms.DataGridView();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.txtCustomerCountry = new System.Windows.Forms.TextBox();
            this.txtCustomerZip = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCustomerState = new System.Windows.Forms.TextBox();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.txtCustomerStreet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerLastname = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            this.grpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(344, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // grdCustomer
            // 
            this.grdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomer.Location = new System.Drawing.Point(12, 190);
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.ReadOnly = true;
            this.grdCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCustomer.Size = new System.Drawing.Size(889, 260);
            this.grdCustomer.TabIndex = 2;
            this.grdCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomer_CellClick);
            this.grdCustomer.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdCustomer_DataBindingComplete);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(79, 19);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(148, 20);
            this.txtCustomerName.TabIndex = 3;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.txtCustomerCountry);
            this.grpCustomer.Controls.Add(this.txtCustomerZip);
            this.grpCustomer.Controls.Add(this.btnNew);
            this.grpCustomer.Controls.Add(this.btnDelete);
            this.grpCustomer.Controls.Add(this.btnUpdate);
            this.grpCustomer.Controls.Add(this.btnSave);
            this.grpCustomer.Controls.Add(this.txtCustomerState);
            this.grpCustomer.Controls.Add(this.txtCustomerCity);
            this.grpCustomer.Controls.Add(this.txtCustomerStreet);
            this.grpCustomer.Controls.Add(this.label4);
            this.grpCustomer.Controls.Add(this.txtCustomerLastname);
            this.grpCustomer.Controls.Add(this.txtCustomerEmail);
            this.grpCustomer.Controls.Add(this.label8);
            this.grpCustomer.Controls.Add(this.label2);
            this.grpCustomer.Controls.Add(this.label7);
            this.grpCustomer.Controls.Add(this.label3);
            this.grpCustomer.Controls.Add(this.label6);
            this.grpCustomer.Controls.Add(this.txtCustomerName);
            this.grpCustomer.Controls.Add(this.label5);
            this.grpCustomer.Controls.Add(this.label1);
            this.grpCustomer.Location = new System.Drawing.Point(12, 12);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(889, 172);
            this.grpCustomer.TabIndex = 4;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer";
            // 
            // txtCustomerCountry
            // 
            this.txtCustomerCountry.Location = new System.Drawing.Point(709, 141);
            this.txtCustomerCountry.Name = "txtCustomerCountry";
            this.txtCustomerCountry.Size = new System.Drawing.Size(156, 20);
            this.txtCustomerCountry.TabIndex = 3;
            // 
            // txtCustomerZip
            // 
            this.txtCustomerZip.Location = new System.Drawing.Point(709, 106);
            this.txtCustomerZip.Name = "txtCustomerZip";
            this.txtCustomerZip.Size = new System.Drawing.Size(156, 20);
            this.txtCustomerZip.TabIndex = 3;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(344, 134);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(195, 31);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(344, 97);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(195, 31);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(344, 60);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 31);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCustomerState
            // 
            this.txtCustomerState.Location = new System.Drawing.Point(709, 64);
            this.txtCustomerState.Name = "txtCustomerState";
            this.txtCustomerState.Size = new System.Drawing.Size(156, 20);
            this.txtCustomerState.TabIndex = 3;
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.Location = new System.Drawing.Point(709, 22);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.Size = new System.Drawing.Size(156, 20);
            this.txtCustomerCity.TabIndex = 3;
            // 
            // txtCustomerStreet
            // 
            this.txtCustomerStreet.Location = new System.Drawing.Point(79, 136);
            this.txtCustomerStreet.Name = "txtCustomerStreet";
            this.txtCustomerStreet.Size = new System.Drawing.Size(148, 20);
            this.txtCustomerStreet.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Street:";
            // 
            // txtCustomerLastname
            // 
            this.txtCustomerLastname.Location = new System.Drawing.Point(79, 59);
            this.txtCustomerLastname.Name = "txtCustomerLastname";
            this.txtCustomerLastname.Size = new System.Drawing.Size(148, 20);
            this.txtCustomerLastname.TabIndex = 3;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(79, 101);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(148, 20);
            this.txtCustomerEmail.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(635, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Country:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Zip:";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "City:";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 462);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grdCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdCustomer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.TextBox txtCustomerLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerCountry;
        private System.Windows.Forms.TextBox txtCustomerZip;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCustomerState;
        private System.Windows.Forms.TextBox txtCustomerCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNew;
    }
}