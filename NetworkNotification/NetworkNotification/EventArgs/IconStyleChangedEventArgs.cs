using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkNotification
{
    public class IconStyleChangedEventArgs : EventArgs
    {
        private NetIconImage.IconStyle m_iconStyle;

        public IconStyleChangedEventArgs(NetIconImage.IconStyle newIconStye)
        {
            m_iconStyle = newIconStye;
        }

        public NetIconImage.IconStyle IconStyle
        {
            get { return m_iconStyle; }
        }

    }
}