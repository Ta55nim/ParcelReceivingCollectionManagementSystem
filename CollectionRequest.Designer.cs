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
            this.lblParcel = new System.Windows.Forms.Label();
            this.cmbParcel = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
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
                new System.Drawing.Point(205, 40);

            this.lblTitle.Name =
                "lblTitle";

            this.lblTitle.Size =
                new System.Drawing.Size(230, 29);

            this.lblTitle.Text =
                "Collection Request";

            // 
            // lblParcel
            // 
            this.lblParcel.AutoSize = true;

            this.lblParcel.Location =
                new System.Drawing.Point(80, 130);

            this.lblParcel.Name =
                "lblParcel";

            this.lblParcel.Size =
                new System.Drawing.Size(78, 13);

            this.lblParcel.Text =
                "Select Parcel:";

            // 
            // cmbParcel
            // 
            this.cmbParcel.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbParcel.FormattingEnabled = true;

            this.cmbParcel.Location =
                new System.Drawing.Point(190, 127);

            this.cmbParcel.Name =
                "cmbParcel";

            this.cmbParcel.Size =
                new System.Drawing.Size(300, 21);

            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;

            this.lblInfo.Location =
                new System.Drawing.Point(190, 170);

            this.lblInfo.Name =
                "lblInfo";

            this.lblInfo.Size =
                new System.Drawing.Size(280, 13);

            this.lblInfo.Text =
                "Select the parcel you want to collect.";

            // 
            // btnRequest
            // 
            this.btnRequest.Location =
                new System.Drawing.Point(190, 220);

            this.btnRequest.Name =
                "btnRequest";

            this.btnRequest.Size =
                new System.Drawing.Size(130, 35);

            this.btnRequest.Text =
                "Request Collection";

            this.btnRequest.UseVisualStyleBackColor =
                true;

            // 
            // btnClear
            // 
            this.btnClear.Location =
                new System.Drawing.Point(330, 220);

            this.btnClear.Name =
                "btnClear";

            this.btnClear.Size =
                new System.Drawing.Size(80, 35);

            this.btnClear.Text =
                "Clear";

            this.btnClear.UseVisualStyleBackColor =
                true;

            // 
            // btnClose
            // 
            this.btnClose.Location =
                new System.Drawing.Point(420, 220);

            this.btnClose.Name =
                "btnClose";

            this.btnClose.Size =
                new System.Drawing.Size(80, 35);

            this.btnClose.Text =
                "Close";

            this.btnClose.UseVisualStyleBackColor =
                true;

            // 
            // FrmCollectionRequest
            // 
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

            this.Name =
                "FrmCollectionRequest";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Collection Request";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}