using System.Drawing;

namespace NetworkNotification
{
    public class NetIconImage
    {
        #region "Data Members"

        public enum IconStyle
        {
            Lines, Grow
        }

        public const IconStyle DEFAULT_ICON_STYLE = IconStyle.Grow;

        private Icon m_iconNet;
        private Icon m_iconNetDown;
        private Icon[] m_iconReceived;
        private Icon[] m_iconSent;
        private Icon[] m_iconSentReceived;
        private int m_intIconIndex;
        private bool m_bIncrease; // Is increasing or decreasing
        private bool m_bAeroSupport;

        private enum CurrentlyShowing
        {
            Net, Received, Sent, SentReceived, Down
        }
        private CurrentlyShowing m_currentlyShowing;

        #endregion

        #region "Methods"

        public NetIconImage(IconStyle iconStyle)
        {
            m_bAeroSupport = AeroSupport.IsAero();
            InitializeIcons(iconStyle);
        }

        public Icon IconNet()
        {
            m_currentlyShowing = CurrentlyShowing.Net;
            return m_iconNet;
        }

        public Icon IconDown()
        {
            m_currentlyShowing = CurrentlyShowing.Down;
            return m_iconNetDown;
        }

        public Icon IconReceived()
        {
            if (m_currentlyShowing != CurrentlyShowing.Received)
            {
                InitIconIndex();
            }
            m_currentlyShowing = CurrentlyShowing.Received;
            return m_iconReceived[getNextIconIndex()];
        }

        public Icon IconSent()
        {
            if (m_currentlyShowing != CurrentlyShowing.Sent)
            {
                InitIconIndex();
            }
            m_currentlyShowing = CurrentlyShowing.Sent;
            return m_iconSent[getNextIconIndex()];
        }

        public Icon IconSentReceived()
        {
            if (m_currentlyShowing != CurrentlyShowing.SentReceived)
            {
                InitIconIndex();
            }
            m_currentlyShowing = CurrentlyShowing.SentReceived;
            return m_iconSentReceived[getNextIconIndex()];
            // TODO return m_iconSentReceived[4];
            // return NetworkNotification.Properties.Resources._02_NetInOut4___Aero;

        }

        private void InitializeIcons(IconStyle iconStyle)
        {
            InitIconIndex();
            // Load icon bitmaps
            switch (iconStyle)
            {
                case IconStyle.Lines:
                    if (m_bAeroSupport)
                    {
                        m_iconNet = Properties.Resources._01_Net___Aero;
                        m_iconNetDown = Properties.Resources._01_NetDown___Aero;
                        m_iconReceived = new Icon[] { 
                            Properties.Resources._01_NetIn0___Aero, 
                            Properties.Resources._01_NetIn1___Aero,
                            Properties.Resources._01_NetIn2___Aero,
                            Properties.Resources._01_NetIn3___Aero,
                            Properties.Resources._01_NetIn4___Aero
                        };
                        m_iconSent = new Icon[] {
                            Properties.Resources._01_NetOut0___Aero, 
                            Properties.Resources._01_NetOut1___Aero, 
                            Properties.Resources._01_NetOut2___Aero, 
                            Properties.Resources._01_NetOut3___Aero, 
                            Properties.Resources._01_NetOut4___Aero
                        };
                        m_iconSentReceived = new Icon[] {
                            Properties.Resources._01_NetInOut0___Aero,
                            Properties.Resources._01_NetInOut1___Aero,
                            Properties.Resources._01_NetInOut2___Aero,
                            Properties.Resources._01_NetInOut3___Aero,
                            Properties.Resources._01_NetInOut4___Aero
                        };
                    }
                    else // Not Aero
                    {
                        m_iconNet = Properties.Resources._01_Net;
                        m_iconNetDown = Properties.Resources._01_NetDown;
                        m_iconReceived = new Icon[] { 
                            Properties.Resources._01_NetIn0, 
                            Properties.Resources._01_NetIn1,
                            Properties.Resources._01_NetIn2,
                            Properties.Resources._01_NetIn3,
                            Properties.Resources._01_NetIn4
                        };
                        m_iconSent = new Icon[] {
                            Properties.Resources._01_NetOut0, 
                            Properties.Resources._01_NetOut1, 
                            Properties.Resources._01_NetOut2, 
                            Properties.Resources._01_NetOut3, 
                            Properties.Resources._01_NetOut4
                        };
                        m_iconSentReceived = new Icon[] {
                            Properties.Resources._01_NetInOut0,
                            Properties.Resources._01_NetInOut1,
                            Properties.Resources._01_NetInOut2,
                            Properties.Resources._01_NetInOut3,
                            Properties.Resources._01_NetInOut4
                        };

                    }
                    break;
                case IconStyle.Grow:
                    if (m_bAeroSupport)
                    {
                        m_iconNet = Properties.Resources._02_Net___Aero;
                        m_iconNetDown = Properties.Resources._02_NetDown___Aero;
                        m_iconReceived = new Icon[] { 
                            Properties.Resources._02_NetIn0___Aero, 
                            Properties.Resources._02_NetIn1___Aero,
                            Properties.Resources._02_NetIn2___Aero,
                            Properties.Resources._02_NetIn3___Aero,
                            Properties.Resources._02_NetIn4___Aero
                        };
                        m_iconSent = new Icon[] {
                            Properties.Resources._02_NetOut0___Aero, 
                            Properties.Resources._02_NetOut1___Aero, 
                            Properties.Resources._02_NetOut2___Aero, 
                            Properties.Resources._02_NetOut3___Aero, 
                            Properties.Resources._02_NetOut4___Aero
                        };
                        m_iconSentReceived = new Icon[] {
                            Properties.Resources._02_NetInOut0___Aero,
                            Properties.Resources._02_NetInOut1___Aero,
                            Properties.Resources._02_NetInOut2___Aero,
                            Properties.Resources._02_NetInOut3___Aero,
                            Properties.Resources._02_NetInOut4___Aero
                        };
                    }
                    else // Not Aero
                    {
                        m_iconNet = Properties.Resources._02_Net;
                        m_iconNetDown = Properties.Resources._02_NetDown;
                        m_iconReceived = new Icon[] { 
                            Properties.Resources._02_NetIn0, 
                            Properties.Resources._02_NetIn1,
                            Properties.Resources._02_NetIn2,
                            Properties.Resources._02_NetIn3,
                            Properties.Resources._02_NetIn4
                        };
                        m_iconSent = new Icon[] {
                            Properties.Resources._02_NetOut0, 
                            Properties.Resources._02_NetOut1, 
                            Properties.Resources._02_NetOut2, 
                            Properties.Resources._02_NetOut3, 
                            Properties.Resources._02_NetOut4
                        };
                        m_iconSentReceived = new Icon[] {
                            Properties.Resources._02_NetInOut0,
                            Properties.Resources._02_NetInOut1,
                            Properties.Resources._02_NetInOut2,
                            Properties.Resources._02_NetInOut3,
                            Properties.Resources._02_NetInOut4
                        };
                    }
                    break;
                default:
                    break;
            }
        }

        private void InitIconIndex()
        {
            // Allowed values between 0 and 4, will start with 4 and decrease
            m_intIconIndex = 5;
            m_bIncrease = false;
        }

        private int getNextIconIndex()
        {
            if (m_bIncrease)
            {
                if (++m_intIconIndex > 4)
                {
                    m_intIconIndex = 4;
                    m_bIncrease = false;
                }
            }
            else
            {
                if (--m_intIconIndex < 0)
                {
                    m_intIconIndex = 0;
                    m_bIncrease = true;
                }
            }
            System.Diagnostics.Debug.Assert(
                m_intIconIndex >= 0 && m_intIconIndex <= 4);
            return m_intIconIndex;
        }

        #endregion
    }
}