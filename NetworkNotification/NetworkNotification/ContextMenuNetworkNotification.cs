using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace NetworkNotification
{
    class ContextMenuNetworkNotification : ContextMenu
    {
        NetworkAnimation m_networkAnimation;

        public ContextMenuNetworkNotification(NetworkAnimation animation)
        {
            m_networkAnimation = animation;
        }

        protected override void OnPopup(EventArgs e)
        {
            base.OnPopup(e);

            // Create menu items
            MenuItems.Clear();

            foreach (NetworkInterface networkInterface in m_networkAnimation.NetworkInterfaces)
            {
                if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    string strIP = "";
                    foreach (UnicastIPAddressInformation ip in networkInterface.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            strIP += ip.Address.ToString();
                        }
                    }
                    MenuItem mi = new MenuItem(strIP + " - " + networkInterface.Name);
                    mi.Enabled = false;
                    MenuItems.Add(mi);
                }
            }
            MenuItems.Add(new MenuItem("-"));
            MenuItems.Add(new MenuItem("&Settings", menuItemSettings_Click));
            MenuItems.Add(new MenuItem("-"));
            MenuItems.Add(new MenuItem("E&xit", menuItemExit_Click));
        }

        private void menuItemSettings_Click(object sender, EventArgs e)
        {
            using (frmSettings f = new frmSettings(m_networkAnimation))
            {
                f.ShowDialog();
            }
        }

        void menuItemExit_Click(object sender, EventArgs e)
        {
            OnExitClicked(EventArgs.Empty);
        }

        protected virtual void OnExitClicked(EventArgs eventArgs)
        {
            EventHandler handler = ExitClicked;
            if (handler != null)
            {
                handler(this, eventArgs);
            }
        }
        
        public event EventHandler ExitClicked;

    }
}
