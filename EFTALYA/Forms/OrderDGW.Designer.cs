namespace EFTALYA.Forms
{
    partial class OrderDGW
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
            this.grdOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOrder
            // 
            this.grdOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOrder.Location = new System.Drawing.Point(0, 0);
            this.grdOrder.Name = "grdOrder";
            this.grdOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOrder.Size = new System.Drawing.Size(800, 450);
            this.grdOrder.TabIndex = 0;
            this.grdOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrder_CellDoubleClick);
            // 
            // OrderDGW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdOrder);
            this.Name = "OrderDGW";
            this.Text = "OrderDGW";
            this.Load += new System.EventHandler(this.OrderDGW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOrder;
    }
}