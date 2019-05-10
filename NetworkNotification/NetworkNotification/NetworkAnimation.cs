using Microsoft.VisualBasic.Devices;
using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;


namespace NetworkNotification
{
    public class NetworkAnimation : IDisposable
    {
        #region "Data Members"

        public const int DEFAULT_TIMER_INTERVAL = 400;
        public const int DEFAULT_INDICATOR_PACKET_SIZE = 512;

        private Timer m_timer = new Timer();
        private static bool m_bNetworkAvailable;
        private static long m_lBytesReceived = long.MinValue;
        private static long m_lBytesSent = long.MinValue;

        #endregion

        #region "Methods"

        public NetworkAnimation()
        {
            int intTimerInterval = AppRegistry.GetIntValue(
                Application.CompanyName, Application.ProductName, "NetworkNotificatioTimerInterval", DEFAULT_TIMER_INTERVAL);

            m_timer.Tick += m_timer_Tick;
            SetTimerInterval(intTimerInterval);
            m_timer.Start();

            //Set event handler for connection status and check initialy
            Computer c = new Computer();
            if (c.Network.IsAvailable)
            {
                OnNetworkAvailable(new NetworkStatusChangedEventArgs(true));
                m_bNetworkAvailable = true;
            }
            else
            {
                OnNetworkUnavailable(new NetworkStatusChangedEventArgs(true));
                m_bNetworkAvailable = false;
            }
            NetworkChange.NetworkAvailabilityChanged += NetworkChange_NetworkAvailabilityChanged;

        }

        protected void NetworkChange_NetworkAvailabilityChanged(object sender,
            System.Net.NetworkInformation.NetworkAvailabilityEventArgs e)
        {
            m_bNetworkAvailable = e.IsAvailable;
            if (m_bNetworkAvailable)
            {
                OnNetworkAvailable(new NetworkStatusChangedEventArgs(true));
            }
            else
            {
                OnNetworkUnavailable(new NetworkStatusChangedEventArgs(true));
            }

        }

        public NetworkInterface[] NetworkInterfaces
        {
            get
            {
                return NetworkInterface.GetAllNetworkInterfaces(); ;
            }
        }

        private void m_timer_Tick(object sender, EventArgs e)
        {
            WriteTotalNetworkBytes();
            /*
            if (m_formParent.Visible)
            {
                m_formParent.WriteBytesIn(m_lBytesReceived);
                m_formParent.WriteBytesOut(m_lBytesSend);
            }
             */
        }

        private void WriteTotalNetworkBytes()
        {
            int intIndicatorPacketSize = AppRegistry.GetIntValue(
                Application.CompanyName, Application.ProductName,
                "NetworkNotificatioIndicatorPacketSize", DEFAULT_INDICATOR_PACKET_SIZE);

            //Aggregate values
            long lBytesReceived = 0;
            long lBytesSend = 0;
            foreach (NetworkInterface adapter in NetworkInterfaces)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                if (!adapter.Supports(NetworkInterfaceComponent.IPv4)) continue;
                IPv4InterfaceStatistics ipv4stats = adapter.GetIPv4Statistics();
                lBytesReceived += ipv4stats.BytesReceived;
                lBytesSend += ipv4stats.BytesSent;
            }
            //Check if this is the first time
            if (m_lBytesReceived == long.MinValue)
                m_lBytesReceived = lBytesReceived;
            if (m_lBytesSent == long.MinValue)
                m_lBytesSent = lBytesSend;
            //Update Icons
            if (m_bNetworkAvailable)
            {
                if (lBytesSend - m_lBytesSent > intIndicatorPacketSize &&
                    lBytesReceived - m_lBytesReceived > intIndicatorPacketSize)
                {
                    //Update values for next time
                    m_lBytesReceived = lBytesReceived;
                    m_lBytesSent = lBytesSend;
                    OnTrafficSentReceived(EventArgs.Empty);
                }
                else if (lBytesSend - m_lBytesSent > intIndicatorPacketSize)
                {
                    //Update values for next time
                    m_lBytesSent = lBytesSend;
                    OnTrafficSent(EventArgs.Empty);
                }
                else if (lBytesReceived - m_lBytesReceived > intIndicatorPacketSize)
                {
                    //Update values for next time
                    m_lBytesReceived = lBytesReceived;
                    OnTrafficReceived(EventArgs.Empty);
                }
                else
                    //m_intIconIndex = 0;
                    OnNetworkAvailable(new NetworkStatusChangedEventArgs(false));
            }
            else
            {
                OnNetworkUnavailable(new NetworkStatusChangedEventArgs(false));
            }
        }

        internal void SetTimerInterval(int intNewTimerInterval)
        {
            m_timer.Interval = intNewTimerInterval;
        }

        internal void SetIconStyle(NetIconImage.IconStyle selectedIconStyle)
        {
            IconStyleChangedEventArgs eventArgs = new IconStyleChangedEventArgs(selectedIconStyle);
            OnIconStyleChanged(eventArgs);
        }

        private void OnIconStyleChanged(IconStyleChangedEventArgs eventArgs)
        {
            EventHandler<IconStyleChangedEventArgs> handler = IconStyleChanged;
            if (handler != null)
            {
                handler(this, eventArgs);
            } 
        }

        private void OnNetworkAvailable(NetworkNotification.NetworkStatusChangedEventArgs eventArgs)
        {
            EventHandler<NetworkStatusChangedEventArgs> handler = NetworkAvailable;
            if (handler != null)
            {
                handler(this, eventArgs);
            }
        }

        private void OnNetworkUnavailable(NetworkNotification.NetworkStatusChangedEventArgs eventArgs)
        {
            EventHandler<NetworkStatusChangedEventArgs> handler = NetworkUnavailable;
            if (handler != null)
            {
                handler(this, eventArgs);
            }
        }

        private void OnTrafficReceived(EventArgs eventArgs)
        {
            EventHandler handler = TrafficReceived;
            if (handler != null)
            {
                handler(this, eventArgs);
            }
        }

        private void OnTrafficSent(EventArgs eventArgs)
        {
            EventHandler handler = TrafficSent;
            if (handler != null)
            {
                handler(this, eventArgs);
            }
        }

        protected virtual void OnTrafficSentReceived(EventArgs eventArgs)
        {
            EventHandler handler = TrafficSentReceived;
            if (handler != null)
            {
                handler(this, eventArgs);
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            m_timer.Stop();
            m_timer.Dispose();
            m_timer = null;
        }

        #endregion

        #region "Events"

        public event EventHandler TrafficReceived;
        public event EventHandler TrafficSent;
        public event EventHandler TrafficSentReceived;
        public event EventHandler<NetworkStatusChangedEventArgs> NetworkAvailable;
        public event EventHandler<NetworkStatusChangedEventArgs> NetworkUnavailable;
        public event EventHandler<IconStyleChangedEventArgs> IconStyleChanged;

        #endregion
    }
}
