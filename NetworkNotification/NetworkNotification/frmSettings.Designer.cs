namespace NetworkNotification
{
    partial class frmSettings
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
            this.components = new System.ComponentModel.Container();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpIconStyle = new System.Windows.Forms.GroupBox();
            this.lblNetSentReceive = new System.Windows.Forms.Label();
            this.lblNetSent = new System.Windows.Forms.Label();
            this.lblNetReceived = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.tableLayoutPanelNetIcons = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxNetSentReceivedGrow = new System.Windows.Forms.PictureBox();
            this.pictureBoxNetSentGrow = new System.Windows.Forms.PictureBox();
            this.pictureBoxNetReceivedGrow = new System.Windows.Forms.PictureBox();
            this.pictureBoxNetGrow = new System.Windows.Forms.PictureBox();
            this.pictureBoxNetSentReceivedLines = new System.Windows.Forms.PictureBox();
            this.pictureBoxNetSentLines = new System.Windows.Forms.PictureBox();
            this.pictureBoxNetReceivedLines = new System.Windows.Forms.PictureBox();
            this.pictureBoxNetLines = new System.Windows.Forms.PictureBox();
            this.optLines = new System.Windows.Forms.RadioButton();
            this.optGrow = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBarTimerInterval = new System.Windows.Forms.TrackBar();
            this.lblTimerInterval = new System.Windows.Forms.Label();
            this.lblTimerIntervalValue = new System.Windows.Forms.Label();
            this.lblIndicatorPacketSizeValue = new System.Windows.Forms.Label();
            this.lblIndicatorPacketSize = new System.Windows.Forms.Label();
            this.trackBarIndicatorPacketSize = new System.Windows.Forms.TrackBar();
            this.grpIconStyle.SuspendLayout();
            this.tableLayoutPanelNetIcons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetSentReceivedGrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetSentGrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetReceivedGrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetGrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetSentReceivedLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetSentLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetReceivedLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimerInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIndicatorPacketSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(198, 397);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(278, 397);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(360, 397);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpIconStyle
            // 
            this.grpIconStyle.Controls.Add(this.lblNetSentReceive);
            this.grpIconStyle.Controls.Add(this.lblNetSent);
            this.grpIconStyle.Controls.Add(this.lblNetReceived);
            this.grpIconStyle.Controls.Add(this.lblNet);
            this.grpIconStyle.Controls.Add(this.tableLayoutPanelNetIcons);
            this.grpIconStyle.Controls.Add(this.optLines);
            this.grpIconStyle.Controls.Add(this.optGrow);
            this.grpIconStyle.Location = new System.Drawing.Point(12, 12);
            this.grpIconStyle.Name = "grpIconStyle";
            this.grpIconStyle.Size = new System.Drawing.Size(418, 168);
            this.grpIconStyle.TabIndex = 3;
            this.grpIconStyle.TabStop = false;
            this.grpIconStyle.Text = "Icon Style";
            // 
            // lblNetSentReceive
            // 
            this.lblNetSentReceive.AutoSize = true;
            this.lblNetSentReceive.Location = new System.Drawing.Point(322, 16);
            this.lblNetSentReceive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNetSentReceive.Name = "lblNetSentReceive";
            this.lblNetSentReceive.Size = new System.Drawing.Size(87, 13);
            this.lblNetSentReceive.TabIndex = 9;
            this.lblNetSentReceive.Text = "Sent & Received";
            this.lblNetSentReceive.UseMnemonic = false;
            // 
            // lblNetSent
            // 
            this.lblNetSent.AutoSize = true;
            this.lblNetSent.Location = new System.Drawing.Point(235, 16);
            this.lblNetSent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNetSent.Name = "lblNetSent";
            this.lblNetSent.Size = new System.Drawing.Size(29, 13);
            this.lblNetSent.TabIndex = 8;
            this.lblNetSent.Text = "Sent";
            // 
            // lblNetReceived
            // 
            this.lblNetReceived.AutoSize = true;
            this.lblNetReceived.Location = new System.Drawing.Point(148, 16);
            this.lblNetReceived.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNetReceived.Name = "lblNetReceived";
            this.lblNetReceived.Size = new System.Drawing.Size(53, 13);
            this.lblNetReceived.TabIndex = 7;
            this.lblNetReceived.Text = "Received";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Location = new System.Drawing.Point(61, 16);
            this.lblNet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(50, 13);
            this.lblNet.TabIndex = 6;
            this.lblNet.Text = "No traffic";
            // 
            // tableLayoutPanelNetIcons
            // 
            this.tableLayoutPanelNetIcons.BackColor = System.Drawing.SystemColors.Desktop;
            this.tableLayoutPanelNetIcons.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanelNetIcons.ColumnCount = 4;
            this.tableLayoutPanelNetIcons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNetIcons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNetIcons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNetIcons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNetIcons.Controls.Add(this.pictureBoxNetSentReceivedGrow, 3, 1);
            this.tableLayoutPanelNetIcons.Controls.Add(this.pictureBoxNetSentGrow, 2, 1);
            this.tableLayoutPanelNetIcons.Controls.Add(this.pictureBoxNetReceivedGrow, 1, 1);
            this.tableLayoutPanelNetIcons.Controls.Add(this.pictureBoxNetGrow, 0, 1);
            this.tableLayoutPanelNetIcons.Controls.Add(this.pictureBoxNetSentReceivedLines, 3, 0);
            this.tableLayoutPanelNetIcons.Controls.Add(this.pictureBoxNetSentLines, 2, 0);
            this.tableLayoutPanelNetIcons.Controls.Add(this.pictureBoxNetReceivedLines, 1, 0);
            this.tableLayoutPanelNetIcons.Controls.Add(this.pictureBoxNetLines, 0, 0);
            this.tableLayoutPanelNetIcons.Location = new System.Drawing.Point(61, 34);
            this.tableLayoutPanelNetIcons.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelNetIcons.Name = "tableLayoutPanelNetIcons";
            this.tableLayoutPanelNetIcons.RowCount = 2;
            this.tableLayoutPanelNetIcons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelNetIcons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelNetIcons.Size = new System.Drawing.Size(351, 129);
            this.tableLayoutPanelNetIcons.TabIndex = 0;
            // 
            // pictureBoxNetSentReceivedGrow
            // 
            this.pictureBoxNetSentReceivedGrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxNetSentReceivedGrow.ErrorImage = null;
            this.pictureBoxNetSentReceivedGrow.InitialImage = null;
            this.pictureBoxNetSentReceivedGrow.Location = new System.Drawing.Point(290, 80);
            this.pictureBoxNetSentReceivedGrow.Name = "pictureBoxNetSentReceivedGrow";
            this.pictureBoxNetSentReceivedGrow.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxNetSentReceivedGrow.TabIndex = 12;
            this.pictureBoxNetSentReceivedGrow.TabStop = false;
            this.pictureBoxNetSentReceivedGrow.Click += new System.EventHandler(this.picBoxNetGrow_Click);
            // 
            // pictureBoxNetSentGrow
            // 
            this.pictureBoxNetSentGrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxNetSentGrow.ErrorImage = null;
            this.pictureBoxNetSentGrow.InitialImage = null;
            this.pictureBoxNetSentGrow.Location = new System.Drawing.Point(202, 80);
            this.pictureBoxNetSentGrow.Name = "pictureBoxNetSentGrow";
            this.pictureBoxNetSentGrow.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxNetSentGrow.TabIndex = 14;
            this.pictureBoxNetSentGrow.TabStop = false;
            this.pictureBoxNetSentGrow.Click += new System.EventHandler(this.picBoxNetGrow_Click);
            // 
            // pictureBoxNetReceivedGrow
            // 
            this.pictureBoxNetReceivedGrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxNetReceivedGrow.ErrorImage = null;
            this.pictureBoxNetReceivedGrow.InitialImage = null;
            this.pictureBoxNetReceivedGrow.Location = new System.Drawing.Point(115, 80);
            this.pictureBoxNetReceivedGrow.Name = "pictureBoxNetReceivedGrow";
            this.pictureBoxNetReceivedGrow.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxNetReceivedGrow.TabIndex = 13;
            this.pictureBoxNetReceivedGrow.TabStop = false;
            this.pictureBoxNetReceivedGrow.Click += new System.EventHandler(this.picBoxNetGrow_Click);
            // 
            // pictureBoxNetGrow
            // 
            this.pictureBoxNetGrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxNetGrow.ErrorImage = null;
            this.pictureBoxNetGrow.InitialImage = null;
            this.pictureBoxNetGrow.Location = new System.Drawing.Point(28, 80);
            this.pictureBoxNetGrow.Name = "pictureBoxNetGrow";
            this.pictureBoxNetGrow.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxNetGrow.TabIndex = 11;
            this.pictureBoxNetGrow.TabStop = false;
            this.pictureBoxNetGrow.Click += new System.EventHandler(this.picBoxNetGrow_Click);
            // 
            // pictureBoxNetSentReceivedLines
            // 
            this.pictureBoxNetSentReceivedLines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxNetSentReceivedLines.ErrorImage = null;
            this.pictureBoxNetSentReceivedLines.InitialImage = null;
            this.pictureBoxNetSentReceivedLines.Location = new System.Drawing.Point(290, 16);
            this.pictureBoxNetSentReceivedLines.Name = "pictureBoxNetSentReceivedLines";
            this.pictureBoxNetSentReceivedLines.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxNetSentReceivedLines.TabIndex = 8;
            this.pictureBoxNetSentReceivedLines.TabStop = false;
            this.pictureBoxNetSentReceivedLines.Click += new System.EventHandler(this.picBoxNetLines_Click);
            // 
            // pictureBoxNetSentLines
            // 
            this.pictureBoxNetSentLines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxNetSentLines.ErrorImage = null;
            this.pictureBoxNetSentLines.InitialImage = null;
            this.pictureBoxNetSentLines.Location = new System.Drawing.Point(202, 16);
            this.pictureBoxNetSentLines.Name = "pictureBoxNetSentLines";
            this.pictureBoxNetSentLines.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxNetSentLines.TabIndex = 10;
            this.pictureBoxNetSentLines.TabStop = false;
            this.pictureBoxNetSentLines.Click += new System.EventHandler(this.picBoxNetLines_Click);
            // 
            // pictureBoxNetReceivedLines
            // 
            this.pictureBoxNetReceivedLines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxNetReceivedLines.ErrorImage = null;
            this.pictureBoxNetReceivedLines.InitialImage = null;
            this.pictureBoxNetReceivedLines.Location = new System.Drawing.Point(115, 16);
            this.pictureBoxNetReceivedLines.Name = "pictureBoxNetReceivedLines";
            this.pictureBoxNetReceivedLines.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxNetReceivedLines.TabIndex = 9;
            this.pictureBoxNetReceivedLines.TabStop = false;
            this.pictureBoxNetReceivedLines.Click += new System.EventHandler(this.picBoxNetLines_Click);
            // 
            // pictureBoxNetLines
            // 
            this.pictureBoxNetLines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxNetLines.ErrorImage = null;
            this.pictureBoxNetLines.InitialImage = null;
            this.pictureBoxNetLines.Location = new System.Drawing.Point(28, 16);
            this.pictureBoxNetLines.Name = "pictureBoxNetLines";
            this.pictureBoxNetLines.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxNetLines.TabIndex = 7;
            this.pictureBoxNetLines.TabStop = false;
            this.pictureBoxNetLines.Click += new System.EventHandler(this.picBoxNetLines_Click);
            // 
            // optLines
            // 
            this.optLines.AutoSize = true;
            this.optLines.Location = new System.Drawing.Point(6, 50);
            this.optLines.Name = "optLines";
            this.optLines.Size = new System.Drawing.Size(50, 17);
            this.optLines.TabIndex = 4;
            this.optLines.TabStop = true;
            this.optLines.Text = "Lines";
            this.optLines.UseVisualStyleBackColor = true;
            // 
            // optGrow
            // 
            this.optGrow.AutoSize = true;
            this.optGrow.Location = new System.Drawing.Point(6, 108);
            this.optGrow.Name = "optGrow";
            this.optGrow.Size = new System.Drawing.Size(50, 17);
            this.optGrow.TabIndex = 5;
            this.optGrow.TabStop = true;
            this.optGrow.Text = "Grow";
            this.optGrow.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBarTimerInterval
            // 
            this.trackBarTimerInterval.Location = new System.Drawing.Point(12, 222);
            this.trackBarTimerInterval.Maximum = 40;
            this.trackBarTimerInterval.Minimum = 1;
            this.trackBarTimerInterval.Name = "trackBarTimerInterval";
            this.trackBarTimerInterval.Size = new System.Drawing.Size(418, 42);
            this.trackBarTimerInterval.TabIndex = 4;
            this.trackBarTimerInterval.Value = 4;
            this.trackBarTimerInterval.Scroll += new System.EventHandler(this.trackBarTimerInterval_Scroll);
            // 
            // lblTimerInterval
            // 
            this.lblTimerInterval.AutoSize = true;
            this.lblTimerInterval.Location = new System.Drawing.Point(13, 196);
            this.lblTimerInterval.Name = "lblTimerInterval";
            this.lblTimerInterval.Size = new System.Drawing.Size(71, 13);
            this.lblTimerInterval.TabIndex = 5;
            this.lblTimerInterval.Text = "Timer Interval";
            // 
            // lblTimerIntervalValue
            // 
            this.lblTimerIntervalValue.Location = new System.Drawing.Point(321, 196);
            this.lblTimerIntervalValue.Name = "lblTimerIntervalValue";
            this.lblTimerIntervalValue.Size = new System.Drawing.Size(100, 23);
            this.lblTimerIntervalValue.TabIndex = 6;
            this.lblTimerIntervalValue.Text = "#";
            this.lblTimerIntervalValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblIndicatorPacketSizeValue
            // 
            this.lblIndicatorPacketSizeValue.Location = new System.Drawing.Point(325, 285);
            this.lblIndicatorPacketSizeValue.Name = "lblIndicatorPacketSizeValue";
            this.lblIndicatorPacketSizeValue.Size = new System.Drawing.Size(100, 23);
            this.lblIndicatorPacketSizeValue.TabIndex = 9;
            this.lblIndicatorPacketSizeValue.Text = "#";
            this.lblIndicatorPacketSizeValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblIndicatorPacketSize
            // 
            this.lblIndicatorPacketSize.AutoSize = true;
            this.lblIndicatorPacketSize.Location = new System.Drawing.Point(17, 285);
            this.lblIndicatorPacketSize.Name = "lblIndicatorPacketSize";
            this.lblIndicatorPacketSize.Size = new System.Drawing.Size(108, 13);
            this.lblIndicatorPacketSize.TabIndex = 8;
            this.lblIndicatorPacketSize.Text = "Indicator Packet Size";
            // 
            // trackBarIndicatorPacketSize
            // 
            this.trackBarIndicatorPacketSize.LargeChange = 4;
            this.trackBarIndicatorPacketSize.Location = new System.Drawing.Point(16, 311);
            this.trackBarIndicatorPacketSize.Maximum = 64;
            this.trackBarIndicatorPacketSize.Minimum = 1;
            this.trackBarIndicatorPacketSize.Name = "trackBarIndicatorPacketSize";
            this.trackBarIndicatorPacketSize.Size = new System.Drawing.Size(418, 42);
            this.trackBarIndicatorPacketSize.TabIndex = 7;
            this.trackBarIndicatorPacketSize.Value = 4;
            this.trackBarIndicatorPacketSize.Scroll += new System.EventHandler(this.trackBarIndicatorPacketSize_Scroll);
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(447, 432);
            this.Controls.Add(this.lblIndicatorPacketSizeValue);
            this.Controls.Add(this.lblIndicatorPacketSize);
            this.Controls.Add(this.trackBarIndicatorPacketSize);
            this.Controls.Add(this.lblTimerIntervalValue);
            this.Controls.Add(this.lblTimerInterval);
            this.Controls.Add(this.trackBarTimerInterval);
            this.Controls.Add(this.grpIconStyle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.grpIconStyle.ResumeLayout(false);
            this.grpIconStyle.PerformLayout();
            this.tableLayoutPanelNetIcons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetSentReceivedGrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetSentGrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetReceivedGrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetGrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetSentReceivedLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetSentLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetReceivedLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimerInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIndicatorPacketSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpIconStyle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNetIcons;
        private System.Windows.Forms.PictureBox pictureBoxNetSentReceivedGrow;
        private System.Windows.Forms.PictureBox pictureBoxNetSentGrow;
        private System.Windows.Forms.PictureBox pictureBoxNetReceivedGrow;
        private System.Windows.Forms.RadioButton optLines;
        private System.Windows.Forms.PictureBox pictureBoxNetGrow;
        private System.Windows.Forms.RadioButton optGrow;
        private System.Windows.Forms.PictureBox pictureBoxNetSentReceivedLines;
        private System.Windows.Forms.PictureBox pictureBoxNetSentLines;
        private System.Windows.Forms.PictureBox pictureBoxNetReceivedLines;
        private System.Windows.Forms.PictureBox pictureBoxNetLines;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblNetSentReceive;
        private System.Windows.Forms.Label lblNetSent;
        private System.Windows.Forms.Label lblNetReceived;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.TrackBar trackBarTimerInterval;
        private System.Windows.Forms.Label lblTimerInterval;
        private System.Windows.Forms.Label lblTimerIntervalValue;
        private System.Windows.Forms.Label lblIndicatorPacketSizeValue;
        private System.Windows.Forms.Label lblIndicatorPacketSize;
        private System.Windows.Forms.TrackBar trackBarIndicatorPacketSize;

    }
}