using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkNotification
{
    
    public static class AeroSupport
    {
        public static bool IsAero()
        {
            bool enabled = false;
            try
            {
                NativeMethods.DwmIsCompositionEnabled(out enabled);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            return enabled;
        }    
    }
}
