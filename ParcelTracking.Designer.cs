namespace ParcelManagement
{
    partial class FrmParcelTracking
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTrackingNumber;
        private System.Windows.Forms.TextBox txtTrackingNumber;
        private System.Windows.Forms.Button btnTrack;

        private System.Windows.Forms.Label lblCourier;
        private System.Windows.Forms.TextBox txtCourier;

        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.TextBox txtSender;

        private System.Windows.Forms.Label lblReceivedDate;
        private System.Windows.Forms.TextBox txtReceivedDate;

        private System.Windows.Forms.Label lblExpectedDate;
        private System.Windows.Forms.TextBox txtExpectedDate;

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;

        private System.Windows.Forms.Button btnClear;
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
            this.lblTrackingNumber = new System.Windows.Forms.Label();
            this.txtTrackingNumber = new System.Windows.Forms.TextBox();
            this.btnTrack = new System.Windows.Forms.Button();

            this.lblCourier = new System.Windows.Forms.Label();
            this.txtCourier = new System.Windows.Forms.TextBox();

            this.lblSender = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();

            this.lblReceivedDate = new System.Windows.Forms.Label();
            this.txtReceivedDate = new System.Windows.Forms.TextBox();

            this.lblExpectedDate = new System.Windows.Forms.Label();
            this.txtExpectedDate = new System.Windows.Forms.TextBox();

            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();

            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();

            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

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
                new System.Drawing.Point(270, 30);

            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size =
                new System.Drawing.Size(170, 29);

            this.lblTitle.Text = "Parcel Tracking";

            // 
            // lblTrackingNumber
            // 
            this.lblTrackingNumber.AutoSize = true;
            this.lblTrackingNumber.Location =
                new System.Drawing.Point(80, 100);

            this.lblTrackingNumber.Name =
                "lblTrackingNumber";

            this.lblTrackingNumber.Size =
                new System.Drawing.Size(91, 13);

            this.lblTrackingNumber.Text =
                "Tracking Number:";

            // 
            // txtTrackingNumber
            // 
            this.txtTrackingNumber.Location =
                new System.Drawing.Point(200, 97);

            this.txtTrackingNumber.Name =
                "txtTrackingNumber";

            this.txtTrackingNumber.Size =
                new System.Drawing.Size(300, 20);

            // 
            // btnTrack
            // 
            this.btnTrack.Location =
                new System.Drawing.Point(520, 95);

            this.btnTrack.Name =
                "btnTrack";

            this.btnTrack.Size =
                new System.Drawing.Size(100, 25);

            this.btnTrack.Text = "Track";
            this.btnTrack.UseVisualStyleBackColor = true;

            // 
            // lblCourier
            // 
            this.lblCourier.AutoSize = true;
            this.lblCourier.Location =
                new System.Drawing.Point(80, 155);

            this.lblCourier.Name =
                "lblCourier";

            this.lblCourier.Size =
                new System.Drawing.Size(43, 13);

            this.lblCourier.Text =
                "Courier:";

            // 
            // txtCourier
            // 
            this.txtCourier.Location =
                new System.Drawing.Point(200, 152);

            this.txtCourier.Name =
                "txtCourier";

            this.txtCourier.ReadOnly = true;

            this.txtCourier.Size =
                new System.Drawing.Size(300, 20);

            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Location =
                new System.Drawing.Point(80, 195);

            this.lblSender.Name =
                "lblSender";

            this.lblSender.Size =
                new System.Drawing.Size(44, 13);

            this.lblSender.Text =
                "Sender:";

            // 
            // txtSender
            // 
            this.txtSender.Location =
                new System.Drawing.Point(200, 192);

            this.txtSender.Name =
                "txtSender";

            this.txtSender.ReadOnly = true;

            this.txtSender.Size =
                new System.Drawing.Size(300, 20);

            // 
            // lblReceivedDate
            // 
            this.lblReceivedDate.AutoSize = true;
            this.lblReceivedDate.Location =
                new System.Drawing.Point(80, 235);

            this.lblReceivedDate.Name =
                "lblReceivedDate";

            this.lblReceivedDate.Size =
                new System.Drawing.Size(78, 13);

            this.lblReceivedDate.Text =
                "Received Date:";

            // 
            // txtReceivedDate
            // 
            this.txtReceivedDate.Location =
                new System.Drawing.Point(200, 232);

            this.txtReceivedDate.Name =
                "txtReceivedDate";

            this.txtReceivedDate.ReadOnly = true;

            this.txtReceivedDate.Size =
                new System.Drawing.Size(300, 20);

            // 
            // lblExpectedDate
            // 
            this.lblExpectedDate.AutoSize = true;
            this.lblExpectedDate.Location =
                new System.Drawing.Point(80, 275);

            this.lblExpectedDate.Name =
                "lblExpectedDate";

            this.lblExpectedDate.Size =
                new System.Drawing.Size(120, 13);

            this.lblExpectedDate.Text =
                "Expected Collection:";

            // 
            // txtExpectedDate
            // 
            this.txtExpectedDate.Location =
                new System.Drawing.Point(200, 272);

            this.txtExpectedDate.Name =
                "txtExpectedDate";

            this.txtExpectedDate.ReadOnly = true;

            this.txtExpectedDate.Size =
                new System.Drawing.Size(300, 20);

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location =
                new System.Drawing.Point(80, 315);

            this.lblStatus.Name =
                "lblStatus";

            this.lblStatus.Size =
                new System.Drawing.Size(40, 13);

            this.lblStatus.Text =
                "Status:";

            // 
            // txtStatus
            // 
            this.txtStatus.Location =
                new System.Drawing.Point(200, 312);

            this.txtStatus.Name =
                "txtStatus";

            this.txtStatus.ReadOnly = true;

            this.txtStatus.Size =
                new System.Drawing.Size(300, 20);

            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location =
                new System.Drawing.Point(80, 355);

            this.lblLocation.Name =
                "lblLocation";

            this.lblLocation.Size =
                new System.Drawing.Size(51, 13);

            this.lblLocation.Text =
                "Location:";

            // 
            // txtLocation
            // 
            this.txtLocation.Location =
                new System.Drawing.Point(200, 352);

            this.txtLocation.Name =
                "txtLocation";

            this.txtLocation.ReadOnly = true;

            this.txtLocation.Size =
                new System.Drawing.Size(300, 20);

            // 
            // btnClear
            // 
            this.btnClear.Location =
                new System.Drawing.Point(200, 405);

            this.btnClear.Name =
                "btnClear";

            this.btnClear.Size =
                new System.Drawing.Size(100, 30);

            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;

            // 
            // btnClose
            // 
            this.btnClose.Location =
                new System.Drawing.Point(320, 405);

            this.btnClose.Name =
                "btnClose";

            this.btnClose.Size =
                new System.Drawing.Size(100, 30);

            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;

            // 
            // FrmParcelTracking
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(700, 480);

            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.lblTrackingNumber);
            this.Controls.Add(this.txtTrackingNumber);
            this.Controls.Add(this.btnTrack);

            this.Controls.Add(this.lblCourier);
            this.Controls.Add(this.txtCourier);

            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.txtSender);

            this.Controls.Add(this.lblReceivedDate);
            this.Controls.Add(this.txtReceivedDate);

            this.Controls.Add(this.lblExpectedDate);
            this.Controls.Add(this.txtExpectedDate);

            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);

            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtLocation);

            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);

            this.Name =
                "FrmParcelTracking";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Parcel Tracking";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}