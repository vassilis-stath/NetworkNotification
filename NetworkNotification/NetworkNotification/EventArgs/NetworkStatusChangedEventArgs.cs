using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkNotification
{
    public class NetworkStatusChangedEventArgs : EventArgs
    {
        private bool m_statusChanged;

        public NetworkStatusChangedEventArgs(bool statusChanged)
        {
            m_statusChanged = statusChanged;
        }

        public bool StatusChanged
        {
            get { return m_statusChanged; }
        }

    }
}