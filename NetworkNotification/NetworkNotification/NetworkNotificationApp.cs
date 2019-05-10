using System;
using System.Windows.Forms;

namespace NetworkNotification
{
    public class NetworkNotificationApp : ApplicationContext
    {
        #region "Data Members"

        private static NetworkAnimation m_networkAnimation;
        private static NotifyIcon m_notifyIcon = new NotifyIcon();
        private static NetIconImage m_netIconImage = new NetIconImage(NetIconImage.IconStyle.Grow);
        private ContextMenuNetworkNotification m_contextMenu;
        
        #endregion

        #region "Methods"
        
        public NetworkNotificationApp()
        {
            m_networkAnimation = new NetworkAnimation();
            m_networkAnimation.TrafficReceived += m_networkAnimation_TrafficReceived;
            m_networkAnimation.TrafficSent += m_networkAnimation_TrafficSent;
            m_networkAnimation.TrafficSentReceived += m_networkAnimation_TrafficSentReceived;
            m_networkAnimation.NetworkAvailable += m_networkAnimation_NetworkAvailable;
            m_networkAnimation.NetworkUnavailable += m_networkAnimation_NetworkUnavailable;
            m_networkAnimation.IconStyleChanged += m_networkAnimation_IconStyleChanged;
            
            m_contextMenu = new ContextMenuNetworkNotification(m_networkAnimation);
            m_contextMenu.ExitClicked += m_contextMenu_ExitClicked;
            m_notifyIcon.ContextMenu = m_contextMenu;
            
            m_notifyIcon.Text = "Network Activity";
            m_notifyIcon.Visible = true;
        }

        void m_contextMenu_ExitClicked(object sender, EventArgs e)
        {
            Exit();
        }

        void m_networkAnimation_NetworkAvailable(object sender, NetworkStatusChangedEventArgs e)
        {
            m_notifyIcon.Icon = m_netIconImage.IconNet();
            if (e.StatusChanged)
            {
                m_notifyIcon.ShowBalloonTip(1000, 
                    Application.ProductName, "You are now connected.", ToolTipIcon.Info);
            }
        }

        void m_networkAnimation_NetworkUnavailable(object sender, NetworkStatusChangedEventArgs e)
        {
            m_notifyIcon.Icon = m_netIconImage.IconDown();
            if (e.StatusChanged)
            {
                m_notifyIcon.ShowBalloonTip(5000, 
                    Application.ProductName, "You are not connected to a network.", ToolTipIcon.Warning);
            }
        }

        void m_networkAnimation_TrafficSentReceived(object sender, EventArgs e)
        {
            m_notifyIcon.Icon = m_netIconImage.IconSentReceived();
        }

        void m_networkAnimation_TrafficSent(object sender, EventArgs e)
        {
            m_notifyIcon.Icon = m_netIconImage.IconSent();
        }

        void m_networkAnimation_TrafficReceived(object sender, EventArgs e)
        {
            m_notifyIcon.Icon = m_netIconImage.IconReceived();
        }

        void m_networkAnimation_IconStyleChanged(object sender, IconStyleChangedEventArgs e)
        {
            m_netIconImage = new NetIconImage(e.IconStyle);
        }



        internal void Exit()
        {
            m_notifyIcon.Visible = false;
            ExitThread();
        }

        #endregion
    }
}
