namespace ParcelManagement
{
    partial class FrmCollectionStatusHistory
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();

            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif",
                    18F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.Location =
                new System.Drawing.Point(280, 25);

            this.lblTitle.Name =
                "lblTitle";

            this.lblTitle.Size =
                new System.Drawing.Size(280, 29);

            this.lblTitle.Text =
                "Collection History";

            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode
                .AllCells;

            this.dgvHistory.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode
                .AutoSize;

            this.dgvHistory.Location =
                new System.Drawing.Point(20, 80);

            this.dgvHistory.Name =
                "dgvHistory";

            this.dgvHistory.ReadOnly = true;

            this.dgvHistory.RowHeadersVisible = false;

            this.dgvHistory.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode
                .FullRowSelect;

            this.dgvHistory.Size =
                new System.Drawing.Size(940, 350);

            // 
            // btnRefresh
            // 
            this.btnRefresh.Location =
                new System.Drawing.Point(350, 455);

            this.btnRefresh.Name =
                "btnRefresh";

            this.btnRefresh.Size =
                new System.Drawing.Size(100, 35);

            this.btnRefresh.Text =
                "Refresh";

            this.btnRefresh.UseVisualStyleBackColor =
                true;

            // 
            // btnClose
            // 
            this.btnClose.Location =
                new System.Drawing.Point(470, 455);

            this.btnClose.Name =
                "btnClose";

            this.btnClose.Size =
                new System.Drawing.Size(100, 35);

            this.btnClose.Text =
                "Close";

            this.btnClose.UseVisualStyleBackColor =
                true;

            // 
            // FrmCollectionStatusHistory
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(980, 530);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);

            this.Name =
                "FrmCollectionStatusHistory";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Collection Status & History";

            this.Load +=
                new System.EventHandler(
                    this.FrmCollectionStatusHistory_Load);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvHistory)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}