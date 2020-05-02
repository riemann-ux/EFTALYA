namespace EFTALYA.Forms
{
    partial class OrderProduct
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
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.btnProductDGW = new System.Windows.Forms.Button();
            this.btnOrderDGW = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdOrderProduct = new System.Windows.Forms.DataGridView();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.txtProductQuantity);
            this.grpOrder.Controls.Add(this.btnProductDGW);
            this.grpOrder.Controls.Add(this.btnOrderDGW);
            this.grpOrder.Controls.Add(this.btnNew);
            this.grpOrder.Controls.Add(this.btnDelete);
            this.grpOrder.Controls.Add(this.btnUpdate);
            this.grpOrder.Controls.Add(this.btnSave);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Controls.Add(this.label4);
            this.grpOrder.Controls.Add(this.txtProductId);
            this.grpOrder.Controls.Add(this.txtOrderId);
            this.grpOrder.Controls.Add(this.label1);
            this.grpOrder.Location = new System.Drawing.Point(12, 12);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(889, 172);
            this.grpOrder.TabIndex = 8;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(254, 131);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtProductQuantity.TabIndex = 6;
            // 
            // btnProductDGW
            // 
            this.btnProductDGW.Location = new System.Drawing.Point(460, 80);
            this.btnProductDGW.Name = "btnProductDGW";
            this.btnProductDGW.Size = new System.Drawing.Size(26, 20);
            this.btnProductDGW.TabIndex = 5;
            this.btnProductDGW.Text = "...";
            this.btnProductDGW.UseVisualStyleBackColor = true;
            this.btnProductDGW.Click += new System.EventHandler(this.btnProductDGW_Click);
            // 
            // btnOrderDGW
            // 
            this.btnOrderDGW.Location = new System.Drawing.Point(460, 25);
            this.btnOrderDGW.Name = "btnOrderDGW";
            this.btnOrderDGW.Size = new System.Drawing.Size(26, 20);
            this.btnOrderDGW.TabIndex = 5;
            this.btnOrderDGW.Text = "...";
            this.btnOrderDGW.UseVisualStyleBackColor = true;
            this.btnOrderDGW.Click += new System.EventHandler(this.btnOrderDGW_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Product:";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(254, 80);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(200, 20);
            this.txtProductId.TabIndex = 3;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(254, 25);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(200, 20);
            this.txtOrderId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order:";
            // 
            // grdOrderProduct
            // 
            this.grdOrderProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrderProduct.Location = new System.Drawing.Point(12, 190);
            this.grdOrderProduct.Name = "grdOrderProduct";
            this.grdOrderProduct.ReadOnly = true;
            this.grdOrderProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOrderProduct.Size = new System.Drawing.Size(889, 260);
            this.grdOrderProduct.TabIndex = 7;
            this.grdOrderProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrderProduct_CellClick);
            this.grdOrderProduct.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdOrderProduct_DataBindingComplete);
            // 
            // OrderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 464);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grdOrderProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderProduct";
            this.Text = "OrderProduct";
            this.Load += new System.EventHandler(this.OrderProduct_Load);
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Button btnProductDGW;
        private System.Windows.Forms.Button btnOrderDGW;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtProductId;
        public System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdOrderProduct;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Label label2;
    }
}