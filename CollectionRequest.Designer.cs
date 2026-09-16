namespace ParcelManagement
{
    partial class FrmCollectionRequest
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblParcel;
        private System.Windows.Forms.ComboBox cmbParcel;
        private System.Windows.Forms.Label lblInfo;

        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblParcel = new System.Windows.Forms.Label();
            this.cmbParcel = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();

            this.btnRequest = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif",
                    18F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.Location =
                new System.Drawing.Point(30, 25);

            this.lblTitle.Name =
                "lblTitle";

            this.lblTitle.Size =
                new System.Drawing.Size(250, 29);

            this.lblTitle.TabIndex = 0;

            this.lblTitle.Text =
                "Collection Request";

            // lblParcel
            this.lblParcel.AutoSize = true;

            this.lblParcel.Location =
                new System.Drawing.Point(40, 100);

            this.lblParcel.Name =
                "lblParcel";

            this.lblParcel.Size =
                new System.Drawing.Size(78, 13);

            this.lblParcel.TabIndex = 1;

            this.lblParcel.Text =
                "Select Parcel:";

            // cmbParcel
            this.cmbParcel.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbParcel.FormattingEnabled = true;

            this.cmbParcel.Location =
                new System.Drawing.Point(150, 97);

            this.cmbParcel.Name =
                "cmbParcel";

            this.cmbParcel.Size =
                new System.Drawing.Size(300, 21);

            this.cmbParcel.TabIndex = 2;

            // lblInfo
            this.lblInfo.AutoSize = true;

            this.lblInfo.Location =
                new System.Drawing.Point(150, 140);

            this.lblInfo.Name =
                "lblInfo";

            this.lblInfo.Size =
                new System.Drawing.Size(400, 80);

            this.lblInfo.TabIndex = 3;

            this.lblInfo.Text =
                "Select the parcel you want to collect.";

            // btnRequest
            this.btnRequest.Location =
                new System.Drawing.Point(150, 240);

            this.btnRequest.Name =
                "btnRequest";

            this.btnRequest.Size =
                new System.Drawing.Size(150, 35);

            this.btnRequest.TabIndex = 4;

            this.btnRequest.Text =
                "Request Collection";

            this.btnRequest.UseVisualStyleBackColor = true;

            // btnClear
            this.btnClear.Location =
                new System.Drawing.Point(310, 240);

            this.btnClear.Name =
                "btnClear";

            this.btnClear.Size =
                new System.Drawing.Size(80, 35);

            this.btnClear.TabIndex = 5;

            this.btnClear.Text =
                "Clear";

            this.btnClear.UseVisualStyleBackColor = true;

            // btnClose
            this.btnClose.Location =
                new System.Drawing.Point(400, 240);

            this.btnClose.Name =
                "btnClose";

            this.btnClose.Size =
                new System.Drawing.Size(80, 35);

            this.btnClose.TabIndex = 6;

            this.btnClose.Text =
                "Close";

            this.btnClose.UseVisualStyleBackColor = true;

            // dgvRequests
            this.dgvRequests.AllowUserToAddRows = false;
            this.dgvRequests.AllowUserToDeleteRows = false;

            this.dgvRequests.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvRequests.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvRequests.Location =
                new System.Drawing.Point(30, 80);

            this.dgvRequests.Name =
                "dgvRequests";

            this.dgvRequests.ReadOnly = true;

            this.dgvRequests.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvRequests.MultiSelect = false;

            this.dgvRequests.Size =
                new System.Drawing.Size(1050, 400);

            this.dgvRequests.TabIndex = 7;

            this.dgvRequests.Visible = false;

            // btnRefresh
            this.btnRefresh.Location =
                new System.Drawing.Point(30, 500);

            this.btnRefresh.Name =
                "btnRefresh";

            this.btnRefresh.Size =
                new System.Drawing.Size(100, 35);

            this.btnRefresh.TabIndex = 8;

            this.btnRefresh.Text =
                "Refresh";

            this.btnRefresh.UseVisualStyleBackColor = true;

            this.btnRefresh.Visible = false;

            // FrmCollectionRequest
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(600, 330);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblParcel);
            this.Controls.Add(this.cmbParcel);
            this.Controls.Add(this.lblInfo);

            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);

            this.Controls.Add(this.dgvRequests);
            this.Controls.Add(this.btnRefresh);

            this.Name =
                "FrmCollectionRequest";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Collection Request";

            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}