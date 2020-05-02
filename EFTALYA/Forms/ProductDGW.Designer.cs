namespace EFTALYA.Forms
{
    partial class ProductDGW
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
            this.grdProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProduct
            // 
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProduct.Location = new System.Drawing.Point(0, 0);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProduct.Size = new System.Drawing.Size(800, 450);
            this.grdProduct.TabIndex = 0;
            this.grdProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduct_CellDoubleClick);
            // 
            // ProductDGW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdProduct);
            this.Name = "ProductDGW";
            this.Text = "ProductDGW";
            this.Load += new System.EventHandler(this.ProductDGW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdProduct;
    }
}