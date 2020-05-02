namespace EFTALYA.Forms
{
    partial class OrderForm
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
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.btnCustomerDGW = new System.Windows.Forms.Button();
            this.dateInvoice = new System.Windows.Forms.DateTimePicker();
            this.dateDelivery = new System.Windows.Forms.DateTimePicker();
            this.datePayment = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdOrder = new System.Windows.Forms.DataGridView();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.btnCustomerDGW);
            this.grpOrder.Controls.Add(this.dateInvoice);
            this.grpOrder.Controls.Add(this.dateDelivery);
            this.grpOrder.Controls.Add(this.datePayment);
            this.grpOrder.Controls.Add(this.btnNew);
            this.grpOrder.Controls.Add(this.btnDelete);
            this.grpOrder.Controls.Add(this.btnUpdate);
            this.grpOrder.Controls.Add(this.btnSave);
            this.grpOrder.Controls.Add(this.label4);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Controls.Add(this.label3);
            this.grpOrder.Controls.Add(this.txtCustomerId);
            this.grpOrder.Controls.Add(this.label1);
            this.grpOrder.Location = new System.Drawing.Point(12, 12);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(889, 172);
            this.grpOrder.TabIndex = 6;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order";
            // 
            // btnCustomerDGW
            // 
            this.btnCustomerDGW.Location = new System.Drawing.Point(304, 19);
            this.btnCustomerDGW.Name = "btnCustomerDGW";
            this.btnCustomerDGW.Size = new System.Drawing.Size(26, 20);
            this.btnCustomerDGW.TabIndex = 5;
            this.btnCustomerDGW.Text = "...";
            this.btnCustomerDGW.UseVisualStyleBackColor = true;
            this.btnCustomerDGW.Click += new System.EventHandler(this.btnCustomerDGW_Click);
            // 
            // dateInvoice
            // 
            this.dateInvoice.Location = new System.Drawing.Point(98, 91);
            this.dateInvoice.Name = "dateInvoice";
            this.dateInvoice.Size = new System.Drawing.Size(200, 20);
            this.dateInvoice.TabIndex = 4;
            // 
            // dateDelivery
            // 
            this.dateDelivery.Location = new System.Drawing.Point(440, 19);
            this.dateDelivery.Name = "dateDelivery";
            this.dateDelivery.Size = new System.Drawing.Size(200, 20);
            this.dateDelivery.TabIndex = 4;
            // 
            // datePayment
            // 
            this.datePayment.Location = new System.Drawing.Point(440, 91);
            this.datePayment.Name = "datePayment";
            this.datePayment.Size = new System.Drawing.Size(200, 20);
            this.datePayment.TabIndex = 4;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(662, 131);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(195, 31);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(662, 94);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(195, 31);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(662, 57);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 31);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(662, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Invoice Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delivery Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Payment Date:";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(98, 19);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer:";
            // 
            // grdOrder
            // 
            this.grdOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrder.Location = new System.Drawing.Point(12, 190);
            this.grdOrder.Name = "grdOrder";
            this.grdOrder.ReadOnly = true;
            this.grdOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOrder.Size = new System.Drawing.Size(889, 260);
            this.grdOrder.TabIndex = 5;
            this.grdOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrder_CellClick);
            this.grdOrder.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdOrder_DataBindingComplete);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 466);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grdOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdOrder;
        private System.Windows.Forms.Button btnCustomerDGW;
        private System.Windows.Forms.DateTimePicker dateInvoice;
        private System.Windows.Forms.DateTimePicker dateDelivery;
        private System.Windows.Forms.DateTimePicker datePayment;
        public System.Windows.Forms.TextBox txtCustomerId;
    }
}