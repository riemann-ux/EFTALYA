namespace EFTALYA.Forms
{
    partial class CustomerDGW
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
            this.grdCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCustomer
            // 
            this.grdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCustomer.Location = new System.Drawing.Point(0, 0);
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCustomer.Size = new System.Drawing.Size(800, 450);
            this.grdCustomer.TabIndex = 0;
            this.grdCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomer_CellDoubleClick);
            // 
            // CustomerDGW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdCustomer);
            this.Name = "CustomerDGW";
            this.Text = "CustomerDGW";
            this.Load += new System.EventHandler(this.CustomerDGW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCustomer;
    }
}