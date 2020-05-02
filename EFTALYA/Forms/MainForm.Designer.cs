namespace EFTALYA.Forms
{
    partial class MainForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnOrderProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.pnlHeader.Controls.Add(this.btnOrderProduct);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1081, 57);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // btnOrderProduct
            // 
            this.btnOrderProduct.Location = new System.Drawing.Point(926, 18);
            this.btnOrderProduct.Name = "btnOrderProduct";
            this.btnOrderProduct.Size = new System.Drawing.Size(75, 23);
            this.btnOrderProduct.TabIndex = 0;
            this.btnOrderProduct.Text = "OP";
            this.btnOrderProduct.UseVisualStyleBackColor = true;
            this.btnOrderProduct.Click += new System.EventHandler(this.btnOrderProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(425, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "EFTALYA COSMETICS";
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::EFTALYA.Properties.Resources.kapat;
            this.btnClose.Location = new System.Drawing.Point(1027, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 57);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(152)))));
            this.pnlButtons.Controls.Add(this.btnEmployee);
            this.pnlButtons.Controls.Add(this.btnProduct);
            this.pnlButtons.Controls.Add(this.btnOrder);
            this.pnlButtons.Controls.Add(this.btnCustomer);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 57);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1081, 124);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnEmployee.Image = global::EFTALYA.Properties.Resources.icons8_gender_neutral_employee_group_96;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmployee.Location = new System.Drawing.Point(810, 0);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(270, 124);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Employees";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnProduct.Image = global::EFTALYA.Properties.Resources.icons8_used_product_96;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProduct.Location = new System.Drawing.Point(540, 0);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(270, 124);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Products";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnOrder.Image = global::EFTALYA.Properties.Resources.icons8_purchase_order_96__1_;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrder.Location = new System.Drawing.Point(270, 0);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(270, 124);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Orders";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnCustomer.Image = global::EFTALYA.Properties.Resources.icons8_customer_96;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomer.Location = new System.Drawing.Point(0, 0);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(270, 124);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContent.Location = new System.Drawing.Point(0, 181);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1081, 566);
            this.pnlContent.TabIndex = 6;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.pnlFooter.Controls.Add(this.lblEmployeeName);
            this.pnlFooter.Controls.Add(this.label2);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFooter.Location = new System.Drawing.Point(0, 747);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1081, 43);
            this.pnlFooter.TabIndex = 7;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblEmployeeName.Location = new System.Drawing.Point(503, 13);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(19, 20);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(349, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee Name:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 789);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrderProduct;
        private System.Windows.Forms.Label lblEmployeeName;
    }
}