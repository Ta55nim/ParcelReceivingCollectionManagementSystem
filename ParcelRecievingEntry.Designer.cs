namespace ParcelManagement
{
    partial class FrmParcelReceiving
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
            this.lblTracking = new System.Windows.Forms.Label();
            this.txtTrackingNumber = new System.Windows.Forms.TextBox();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.cmbRecipient = new System.Windows.Forms.ComboBox();
            this.lblSender = new System.Windows.Forms.Label();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.lblCourier = new System.Windows.Forms.Label();
            this.txtCourierName = new System.Windows.Forms.TextBox();
            this.lblReceivedDate = new System.Windows.Forms.Label();
            this.dtpReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpectedDate = new System.Windows.Forms.Label();
            this.dtpExpectedCollectionDate = new System.Windows.Forms.DateTimePicker();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocationID = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                16F,
                System.Drawing.FontStyle.Bold);

            this.lblTitle.Location = new System.Drawing.Point(35, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Parcel Receiving & Entry";

            // 
            // lblTracking
            // 
            this.lblTracking.AutoSize = true;
            this.lblTracking.Location = new System.Drawing.Point(40, 95);
            this.lblTracking.Name = "lblTracking";
            this.lblTracking.Size = new System.Drawing.Size(115, 16);
            this.lblTracking.TabIndex = 1;
            this.lblTracking.Text = "Tracking Number:";

            // 
            // txtTrackingNumber
            // 
            this.txtTrackingNumber.Location = new System.Drawing.Point(220, 91);
            this.txtTrackingNumber.Name = "txtTrackingNumber";
            this.txtTrackingNumber.ReadOnly = true;
            this.txtTrackingNumber.Size = new System.Drawing.Size(300, 22);
            this.txtTrackingNumber.TabIndex = 2;

            // 
            // lblRecipient
            // 
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.Location = new System.Drawing.Point(40, 140);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(68, 16);
            this.lblRecipient.TabIndex = 3;
            this.lblRecipient.Text = "Recipient:";

            // 
            // cmbRecipient
            // 
            this.cmbRecipient.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbRecipient.FormattingEnabled = true;
            this.cmbRecipient.Location = new System.Drawing.Point(220, 136);
            this.cmbRecipient.Name = "cmbRecipient";
            this.cmbRecipient.Size = new System.Drawing.Size(300, 24);
            this.cmbRecipient.TabIndex = 4;

            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Location = new System.Drawing.Point(40, 185);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(86, 16);
            this.lblSender.TabIndex = 5;
            this.lblSender.Text = "Sender Name:";

            // 
            // txtSenderName
            // 
            this.txtSenderName.Location = new System.Drawing.Point(220, 181);
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(300, 22);
            this.txtSenderName.TabIndex = 6;

            // 
            // lblCourier
            // 
            this.lblCourier.AutoSize = true;
            this.lblCourier.Location = new System.Drawing.Point(40, 230);
            this.lblCourier.Name = "lblCourier";
            this.lblCourier.Size = new System.Drawing.Size(91, 16);
            this.lblCourier.TabIndex = 7;
            this.lblCourier.Text = "Courier Name:";

            // 
            // txtCourierName
            // 
            this.txtCourierName.Location = new System.Drawing.Point(220, 226);
            this.txtCourierName.Name = "txtCourierName";
            this.txtCourierName.Size = new System.Drawing.Size(300, 22);
            this.txtCourierName.TabIndex = 8;

            // 
            // lblReceivedDate
            // 
            this.lblReceivedDate.AutoSize = true;
            this.lblReceivedDate.Location = new System.Drawing.Point(40, 275);
            this.lblReceivedDate.Name = "lblReceivedDate";
            this.lblReceivedDate.Size = new System.Drawing.Size(96, 16);
            this.lblReceivedDate.TabIndex = 9;
            this.lblReceivedDate.Text = "Received Date:";

            // 
            // dtpReceivedDate
            // 
            this.dtpReceivedDate.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpReceivedDate.Location =
                new System.Drawing.Point(220, 271);

            this.dtpReceivedDate.Name = "dtpReceivedDate";
            this.dtpReceivedDate.Size = new System.Drawing.Size(300, 22);
            this.dtpReceivedDate.TabIndex = 10;

            // 
            // lblExpectedDate
            // 
            this.lblExpectedDate.AutoSize = true;
            this.lblExpectedDate.Location = new System.Drawing.Point(40, 320);
            this.lblExpectedDate.Name = "lblExpectedDate";
            this.lblExpectedDate.Size = new System.Drawing.Size(153, 16);
            this.lblExpectedDate.TabIndex = 11;
            this.lblExpectedDate.Text = "Expected Collection Date:";

            // 
            // dtpExpectedCollectionDate
            // 
            this.dtpExpectedCollectionDate.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpExpectedCollectionDate.Location =
                new System.Drawing.Point(220, 316);

            this.dtpExpectedCollectionDate.Name =
                "dtpExpectedCollectionDate";

            this.dtpExpectedCollectionDate.Size =
                new System.Drawing.Size(300, 22);

            this.dtpExpectedCollectionDate.TabIndex = 12;

            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(40, 365);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(116, 16);
            this.lblLocation.TabIndex = 13;
            this.lblLocation.Text = "Storage Location:";

            // 
            // txtLocationID
            // 
            this.txtLocationID.Location =
                new System.Drawing.Point(220, 361);

            this.txtLocationID.Name = "txtLocationID";
            this.txtLocationID.Size =
                new System.Drawing.Size(300, 22);

            this.txtLocationID.TabIndex = 14;

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(40, 410);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 16);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status:";

            // 
            // txtStatus
            // 
            this.txtStatus.Location =
                new System.Drawing.Point(220, 406);

            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size =
                new System.Drawing.Size(300, 22);

            this.txtStatus.TabIndex = 16;
            this.txtStatus.Text = "Pending";

            // 
            // btnReceive
            // 
            this.btnReceive.Location =
                new System.Drawing.Point(220, 465);

            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size =
                new System.Drawing.Size(140, 40);

            this.btnReceive.TabIndex = 17;
            this.btnReceive.Text = "Receive Parcel";
            this.btnReceive.UseVisualStyleBackColor = true;

            this.btnReceive.Click +=
                new System.EventHandler(this.btnReceive_Click);

            // 
            // btnClear
            // 
            this.btnClear.Location =
                new System.Drawing.Point(375, 465);

            this.btnClear.Name = "btnClear";
            this.btnClear.Size =
                new System.Drawing.Size(145, 40);

            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;

            this.btnClear.Click +=
                new System.EventHandler(this.btnClear_Click);

            // 
            // btnClose
            // 
            this.btnClose.Location =
                new System.Drawing.Point(220, 520);

            this.btnClose.Name = "btnClose";
            this.btnClose.Size =
                new System.Drawing.Size(300, 40);

            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;

            this.btnClose.Click +=
                new System.EventHandler(this.btnClose_Click);

            // 
            // FrmParcelReceiving
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.White;

            this.ClientSize =
                new System.Drawing.Size(600, 600);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTracking);
            this.Controls.Add(this.txtTrackingNumber);
            this.Controls.Add(this.lblRecipient);
            this.Controls.Add(this.cmbRecipient);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.txtSenderName);
            this.Controls.Add(this.lblCourier);
            this.Controls.Add(this.txtCourierName);
            this.Controls.Add(this.lblReceivedDate);
            this.Controls.Add(this.dtpReceivedDate);
            this.Controls.Add(this.lblExpectedDate);
            this.Controls.Add(this.dtpExpectedCollectionDate);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtLocationID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);

            this.Name = "FrmParcelReceiving";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Parcel Receiving & Entry";

            this.Load +=
                new System.EventHandler(this.FrmParcelReceiving_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTracking;
        private System.Windows.Forms.TextBox txtTrackingNumber;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.ComboBox cmbRecipient;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.Label lblCourier;
        private System.Windows.Forms.TextBox txtCourierName;
        private System.Windows.Forms.Label lblReceivedDate;
        private System.Windows.Forms.DateTimePicker dtpReceivedDate;
        private System.Windows.Forms.Label lblExpectedDate;
        private System.Windows.Forms.DateTimePicker dtpExpectedCollectionDate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocationID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}