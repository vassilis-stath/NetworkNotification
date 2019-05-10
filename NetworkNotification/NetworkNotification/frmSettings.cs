using System;
using System.Drawing;
using System.Windows.Forms;

namespace NetworkNotification
{
    public partial class frmSettings : Form
    {
        #region "Data Members"

        private const int TIME_INTERVAL_GRANULARITY_MS = 100;
        private const int PACKET_SIZE_GRANULARITY_MS = 128;

        private NetworkAnimation m_networkAnimation;
        private NetIconImage m_lines;
        private NetIconImage m_linesSent;
        private NetIconImage m_linesReceived;
        private NetIconImage m_linesSentReceived;

        private NetIconImage m_grow;
        private NetIconImage m_growSent;
        private NetIconImage m_growReceived;
        private NetIconImage m_growSentReceived;

        #endregion

        public frmSettings(NetworkAnimation networkAnimation)
        {
            m_networkAnimation = networkAnimation;
            InitializeComponent();

            Text += " - " + Application.ProductName;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            InitPictures();

            NetIconImage.IconStyle iconStyle = AppRegistry.GetIconStyle(
                Application.CompanyName, Application.ProductName,
                "NetworkNotificationIconStyle", NetIconImage.IconStyle.Grow);
            switch (iconStyle)
            {
                case NetIconImage.IconStyle.Lines:
                    optLines.Checked = true;
                    break;
                case NetIconImage.IconStyle.Grow:
                    optGrow.Checked = true;
                    break;
            }

            int intTimerInterval = AppRegistry.GetIntValue(
                Application.CompanyName, Application.ProductName,
                "NetworkNotificationTimerInterval", NetworkAnimation.DEFAULT_TIMER_INTERVAL);
            timer1.Interval = intTimerInterval;
            timer1.Start();
            trackBarTimerInterval.Value = Convert.ToInt32(intTimerInterval / TIME_INTERVAL_GRANULARITY_MS);
            trackBarTimerInterval.Minimum = 100 / TIME_INTERVAL_GRANULARITY_MS; // 100 ms 
            trackBarTimerInterval.Maximum = 4000 / TIME_INTERVAL_GRANULARITY_MS; // 4 seconds
            trackBarTimerInterval_Scroll(this, EventArgs.Empty); // Trigger change and UI update


            int intIndicatorPacketSize = AppRegistry.GetIntValue(
                Application.CompanyName, Application.ProductName,
                "NetworkNotificatioIndicatorPacketSize", NetworkAnimation.DEFAULT_INDICATOR_PACKET_SIZE);
            trackBarIndicatorPacketSize.Value = Convert.ToInt32(intIndicatorPacketSize / PACKET_SIZE_GRANULARITY_MS);
            trackBarIndicatorPacketSize.Minimum = 128 / PACKET_SIZE_GRANULARITY_MS; // 128 bytes
            trackBarIndicatorPacketSize.Maximum = 8192 / PACKET_SIZE_GRANULARITY_MS; // 8 MB
            trackBarIndicatorPacketSize_Scroll(this, EventArgs.Empty); // Trigger change and UI update
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Apply();
            Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Apply();
        }

        private void Apply()
        {
            NetIconImage.IconStyle selectedIconStyle;
            if (optLines.Checked)
            {
                selectedIconStyle = NetIconImage.IconStyle.Lines;
            }
            else if(optGrow.Checked)
            {
                selectedIconStyle = NetIconImage.IconStyle.Grow;
            }
            else
            {
                throw new Exception("No selected icon style");
            }
            AppRegistry.SaveIconType(
                Application.CompanyName, Application.ProductName, "NetworkNotificationIconStyle", selectedIconStyle);
            m_networkAnimation.SetIconStyle(selectedIconStyle);
            
            int intNewTimerInterval = Convert.ToInt32(trackBarTimerInterval.Value * 100);
            AppRegistry.SaveIntValue(
                Application.CompanyName, Application.ProductName, "NetworkNotificationTimerInterval", intNewTimerInterval);
            m_networkAnimation.SetTimerInterval(intNewTimerInterval);

            int intIndicatorPacketSize = Convert.ToInt32(trackBarIndicatorPacketSize.Value * 128);
            AppRegistry.SaveIntValue(
                Application.CompanyName, Application.ProductName, "NetworkNotificatioIndicatorPacketSize", intIndicatorPacketSize);
        }

        private void InitPictures()
        {
            m_lines = new NetIconImage(NetIconImage.IconStyle.Lines);
            m_linesSent = new NetIconImage(NetIconImage.IconStyle.Lines);
            m_linesReceived = new NetIconImage(NetIconImage.IconStyle.Lines);
            m_linesSentReceived = new NetIconImage(NetIconImage.IconStyle.Lines);

            m_grow = new NetIconImage(NetIconImage.IconStyle.Grow);
            m_growSent = new NetIconImage(NetIconImage.IconStyle.Grow);
            m_growReceived = new NetIconImage(NetIconImage.IconStyle.Grow);
            m_growSentReceived = new NetIconImage(NetIconImage.IconStyle.Grow);

            pictureBoxNetLines.Image = Bitmap.FromHicon(
                m_lines.IconNet().Handle);
            pictureBoxNetReceivedLines.Image = Bitmap.FromHicon(
                m_linesReceived.IconReceived().Handle);
            pictureBoxNetSentLines.Image = Bitmap.FromHicon(
                m_linesSent.IconSent().Handle);
            pictureBoxNetSentReceivedLines.Image = Bitmap.FromHicon(
                m_linesSentReceived.IconSentReceived().Handle);

            pictureBoxNetGrow.Image = Bitmap.FromHicon(
                m_grow.IconNet().Handle);
            pictureBoxNetReceivedGrow.Image = Bitmap.FromHicon(
                m_growReceived.IconReceived().Handle);
            pictureBoxNetSentGrow.Image = Bitmap.FromHicon(
                m_growSent.IconSent().Handle);
            pictureBoxNetSentReceivedGrow.Image = Bitmap.FromHicon(
                m_growSentReceived.IconSentReceived().Handle);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBoxNetReceivedLines.Image = Bitmap.FromHicon(m_linesReceived.IconReceived().Handle);
            pictureBoxNetSentLines.Image = Bitmap.FromHicon(m_linesSent.IconSent().Handle);
            pictureBoxNetSentReceivedLines.Image = Bitmap.FromHicon(m_linesSentReceived.IconSentReceived().Handle);

            pictureBoxNetReceivedGrow.Image = Bitmap.FromHicon(m_growReceived.IconReceived().Handle);
            pictureBoxNetSentGrow.Image = Bitmap.FromHicon(m_growSent.IconSent().Handle);
            pictureBoxNetSentReceivedGrow.Image = Bitmap.FromHicon(m_growSentReceived.IconSentReceived().Handle);
        }

        private void picBoxNetLines_Click(object sender, EventArgs e)
        {
            optLines.Checked = true;
        }

        private void picBoxNetGrow_Click(object sender, EventArgs e)
        {
            optGrow.Checked = true;
        }

        private void trackBarTimerInterval_Scroll(object sender, EventArgs e)
        {
            lblTimerIntervalValue.Text = (trackBarTimerInterval.Value * 100) + " ms";
            timer1.Interval = trackBarTimerInterval.Value * 100;
        }

        private void trackBarIndicatorPacketSize_Scroll(object sender, EventArgs e)
        {
            lblIndicatorPacketSizeValue.Text = (trackBarIndicatorPacketSize.Value < 8 ? // 8 * 128 = 1024
                (trackBarIndicatorPacketSize.Value * 128) + " bytes" :
                ((float)trackBarIndicatorPacketSize.Value * 128 / 1024).ToString("0.000") + " MBs");
        }
    }
}
