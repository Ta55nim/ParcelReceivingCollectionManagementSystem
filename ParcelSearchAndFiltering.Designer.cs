namespace ParcelManagement
{
    partial class FrmParcelSearchAndFiltering
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblTracking;
        private System.Windows.Forms.TextBox txtTracking;

        private System.Windows.Forms.Label lblCourier;
        private System.Windows.Forms.TextBox txtCourier;

        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.TextBox txtSender;

        private System.Windows.Forms.Label lblReceivedDate;
        private System.Windows.Forms.TextBox txtReceivedDate;

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.DataGridView dgvParcels;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            this.lblTracking = new System.Windows.Forms.Label();
            this.txtTracking = new System.Windows.Forms.TextBox();

            this.lblCourier = new System.Windows.Forms.Label();
            this.txtCourier = new System.Windows.Forms.TextBox();

            this.lblSender = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();

            this.lblReceivedDate = new System.Windows.Forms.Label();
            this.txtReceivedDate = new System.Windows.Forms.TextBox();

            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();

            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();

            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.dgvParcels = new System.Windows.Forms.DataGridView();

            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcels)).BeginInit();
            this.SuspendLayout();

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor =
                System.Drawing.SystemColors.InactiveCaption;

            this.panelHeader.Controls.Add(this.lblTitle);

            this.panelHeader.Location =
                new System.Drawing.Point(0, 0);

            this.panelHeader.Name = "panelHeader";

            this.panelHeader.Size =
                new System.Drawing.Size(1000, 70);

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
                new System.Drawing.Point(300, 20);

            this.lblTitle.Name = "lblTitle";

            this.lblTitle.Text =
                "Parcel Search And Filtering";

            // 
            // lblTracking
            // 
            this.lblTracking.AutoSize = true;

            this.lblTracking.Location =
                new System.Drawing.Point(40, 100);

            this.lblTracking.Text =
                "Tracking No:";

            // 
            // txtTracking
            // 
            this.txtTracking.Location =
                new System.Drawing.Point(160, 96);

            this.txtTracking.Size =
                new System.Drawing.Size(250, 22);

            // 
            // lblCourier
            // 
            this.lblCourier.AutoSize = true;

            this.lblCourier.Location =
                new System.Drawing.Point(520, 100);

            this.lblCourier.Text =
                "Courier Name:";

            // 
            // txtCourier
            // 
            this.txtCourier.Location =
                new System.Drawing.Point(650, 96);

            this.txtCourier.Size =
                new System.Drawing.Size(250, 22);

            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;

            this.lblSender.Location =
                new System.Drawing.Point(40, 145);

            this.lblSender.Text =
                "Sender Name:";

            // 
            // txtSender
            // 
            this.txtSender.Location =
                new System.Drawing.Point(160, 141);

            this.txtSender.Size =
                new System.Drawing.Size(250, 22);

            // 
            // lblReceivedDate
            // 
            this.lblReceivedDate.AutoSize = true;

            this.lblReceivedDate.Location =
                new System.Drawing.Point(520, 145);

            this.lblReceivedDate.Text =
                "Received Date:";

            // 
            // txtReceivedDate
            // 
            this.txtReceivedDate.Location =
                new System.Drawing.Point(650, 141);

            this.txtReceivedDate.Size =
                new System.Drawing.Size(250, 22);

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;

            this.lblStatus.Location =
                new System.Drawing.Point(40, 190);

            this.lblStatus.Text =
                "Status:";

            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbStatus.Location =
                new System.Drawing.Point(160, 186);

            this.cmbStatus.Size =
                new System.Drawing.Size(250, 24);

            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;

            this.lblLocation.Location =
                new System.Drawing.Point(520, 190);

            this.lblLocation.Text =
                "Storage Location:";

            // 
            // txtLocation
            // 
            this.txtLocation.Location =
                new System.Drawing.Point(650, 186);

            this.txtLocation.Size =
                new System.Drawing.Size(250, 22);

            // 
            // btnSearch
            // 
            this.btnSearch.Location =
                new System.Drawing.Point(160, 230);

            this.btnSearch.Size =
                new System.Drawing.Size(110, 35);

            this.btnSearch.Text =
                "Search";

            this.btnSearch.UseVisualStyleBackColor = true;

            // 
            // btnClear
            // 
            this.btnClear.Location =
                new System.Drawing.Point(285, 230);

            this.btnClear.Size =
                new System.Drawing.Size(110, 35);

            this.btnClear.Text =
                "Clear";

            this.btnClear.UseVisualStyleBackColor = true;

            // 
            // dgvParcels
            // 
            this.dgvParcels.AllowUserToAddRows = false;
            this.dgvParcels.AllowUserToDeleteRows = false;

            this.dgvParcels.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvParcels.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvParcels.Location =
                new System.Drawing.Point(40, 285);

            this.dgvParcels.ReadOnly = true;

            this.dgvParcels.Size =
                new System.Drawing.Size(920, 250);

            // 
            // btnClose
            // 
            this.btnClose.Location =
                new System.Drawing.Point(850, 550);

            this.btnClose.Size =
                new System.Drawing.Size(110, 35);

            this.btnClose.Text =
                "Close";

            this.btnClose.UseVisualStyleBackColor = true;

            // 
            // FrmParcelSearchAndFiltering
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.SystemColors.GradientInactiveCaption;

            this.ClientSize =
                new System.Drawing.Size(1000, 610);

            this.Controls.Add(this.panelHeader);

            this.Controls.Add(this.lblTracking);
            this.Controls.Add(this.txtTracking);

            this.Controls.Add(this.lblCourier);
            this.Controls.Add(this.txtCourier);

            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.txtSender);

            this.Controls.Add(this.lblReceivedDate);
            this.Controls.Add(this.txtReceivedDate);

            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);

            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtLocation);

            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);

            this.Controls.Add(this.dgvParcels);
            this.Controls.Add(this.btnClose);

            this.Name =
                "FrmParcelSearchAndFiltering";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Parcel Search And Filtering";

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvParcels)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}