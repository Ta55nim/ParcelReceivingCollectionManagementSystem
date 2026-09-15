namespace ParcelManagement
{
    partial class FrmAdminDashboard
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblTotalText = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblPendingText = new System.Windows.Forms.Label();
            this.lblPendingValue = new System.Windows.Forms.Label();
            this.lblCollectedText = new System.Windows.Forms.Label();
            this.lblCollectedValue = new System.Windows.Forms.Label();
            this.lblTodayText = new System.Windows.Forms.Label();
            this.lblTodayValue = new System.Windows.Forms.Label();
            this.dgvParcels = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCollectionRequests = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcels)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(34, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(343, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Admin Dashboard";
            // 
            // lblTotalText
            // 
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTotalText.Location = new System.Drawing.Point(40, 80);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(113, 20);
            this.lblTotalText.TabIndex = 1;
            this.lblTotalText.Text = "Total Parcels:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.Location = new System.Drawing.Point(171, 79);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(19, 20);
            this.lblTotalValue.TabIndex = 2;
            this.lblTotalValue.Text = "0";
            // 
            // lblPendingText
            // 
            this.lblPendingText.AutoSize = true;
            this.lblPendingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPendingText.Location = new System.Drawing.Point(297, 80);
            this.lblPendingText.Name = "lblPendingText";
            this.lblPendingText.Size = new System.Drawing.Size(74, 20);
            this.lblPendingText.TabIndex = 3;
            this.lblPendingText.Text = "Pending:";
            // 
            // lblPendingValue
            // 
            this.lblPendingValue.AutoSize = true;
            this.lblPendingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPendingValue.Location = new System.Drawing.Point(383, 79);
            this.lblPendingValue.Name = "lblPendingValue";
            this.lblPendingValue.Size = new System.Drawing.Size(19, 20);
            this.lblPendingValue.TabIndex = 4;
            this.lblPendingValue.Text = "0";
            // 
            // lblCollectedText
            // 
            this.lblCollectedText.AutoSize = true;
            this.lblCollectedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCollectedText.Location = new System.Drawing.Point(491, 80);
            this.lblCollectedText.Name = "lblCollectedText";
            this.lblCollectedText.Size = new System.Drawing.Size(84, 20);
            this.lblCollectedText.TabIndex = 5;
            this.lblCollectedText.Text = "Collected:";
            // 
            // lblCollectedValue
            // 
            this.lblCollectedValue.AutoSize = true;
            this.lblCollectedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCollectedValue.Location = new System.Drawing.Point(583, 79);
            this.lblCollectedValue.Name = "lblCollectedValue";
            this.lblCollectedValue.Size = new System.Drawing.Size(19, 20);
            this.lblCollectedValue.TabIndex = 6;
            this.lblCollectedValue.Text = "0";
            // 
            // lblTodayText
            // 
            this.lblTodayText.AutoSize = true;
            this.lblTodayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTodayText.Location = new System.Drawing.Point(40, 112);
            this.lblTodayText.Name = "lblTodayText";
            this.lblTodayText.Size = new System.Drawing.Size(133, 20);
            this.lblTodayText.TabIndex = 7;
            this.lblTodayText.Text = "Received Today:";
            // 
            // lblTodayValue
            // 
            this.lblTodayValue.AutoSize = true;
            this.lblTodayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTodayValue.Location = new System.Drawing.Point(171, 111);
            this.lblTodayValue.Name = "lblTodayValue";
            this.lblTodayValue.Size = new System.Drawing.Size(19, 20);
            this.lblTodayValue.TabIndex = 8;
            this.lblTodayValue.Text = "0";
            // 
            // dgvParcels
            // 
            this.dgvParcels.AllowUserToAddRows = false;
            this.dgvParcels.AllowUserToDeleteRows = false;
            this.dgvParcels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParcels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParcels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcels.Location = new System.Drawing.Point(34, 155);
            this.dgvParcels.Name = "dgvParcels";
            this.dgvParcels.ReadOnly = true;
            this.dgvParcels.RowHeadersWidth = 40;
            this.dgvParcels.Size = new System.Drawing.Size(1234, 416);
            this.dgvParcels.TabIndex = 9;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(920, 592);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(171, 48);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCollectionRequests
            // 
            this.btnCollectionRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCollectionRequests.Location = new System.Drawing.Point(40, 592);
            this.btnCollectionRequests.Name = "btnCollectionRequests";
            this.btnCollectionRequests.Size = new System.Drawing.Size(217, 48);
            this.btnCollectionRequests.TabIndex = 11;
            this.btnCollectionRequests.Text = "Collection Requests";
            this.btnCollectionRequests.UseVisualStyleBackColor = true;
            this.btnCollectionRequests.Click += new System.EventHandler(this.btnCollectionRequests_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReports.Location = new System.Drawing.Point(719, 592);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(171, 48);
            this.btnReports.TabIndex = 12;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(1097, 592);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(171, 48);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(276, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "Recieving And Entry";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(453, 592);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 48);
            this.button2.TabIndex = 15;
            this.button2.Text = "Pickup Verification";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1303, 672);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTotalText);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblPendingText);
            this.Controls.Add(this.lblPendingValue);
            this.Controls.Add(this.lblCollectedText);
            this.Controls.Add(this.lblCollectedValue);
            this.Controls.Add(this.lblTodayText);
            this.Controls.Add(this.lblTodayValue);
            this.Controls.Add(this.dgvParcels);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCollectionRequests);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnLogout);
            this.Name = "FrmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.FrmAdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblPendingText;
        private System.Windows.Forms.Label lblPendingValue;
        private System.Windows.Forms.Label lblCollectedText;
        private System.Windows.Forms.Label lblCollectedValue;
        private System.Windows.Forms.Label lblTodayText;
        private System.Windows.Forms.Label lblTodayValue;
        private System.Windows.Forms.DataGridView dgvParcels;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCollectionRequests;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}