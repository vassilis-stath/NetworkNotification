using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace NetworkNotification
{
    public static class AppRegistry
    {
        internal static int GetIntValue(string companyName, string applicationProductName, string name, int defaultValue)
        {
            //RegistryKey key = Registry.CurrentUser.OpenSubKey("Software");
            RegistryKey key = Registry.CurrentUser;
            
            int returnValue = 0;
            int.TryParse(key.GetValue(name, defaultValue).ToString(), out returnValue);
            return returnValue;
        }

        internal static void SaveIntValue(string companyName, string applicationProductName, string name, int value)
        {
            RegistryKey key = Registry.CurrentUser;
            key.SetValue(name, value);
        }

        internal static NetIconImage.IconStyle GetIconStyle(string companyName, string applicationProductName, 
            string name, NetIconImage.IconStyle defaultIconStyle)
        {
            int defaultValue = Convert.ToInt32(NetIconImage.IconStyle.Grow);
                        
            RegistryKey key = Registry.CurrentUser;
            int returnValue = 0;
            int.TryParse(key.GetValue(name, defaultValue).ToString(), out returnValue);
            switch (returnValue)
            {
                case 0:
                    return NetIconImage.IconStyle.Lines;
                    // break;
                case 1:
                    return NetIconImage.IconStyle.Grow;
                    // break;
                default:
                    throw new Exception("Wrong registry value for: " + name);
            }
        }

        internal static void SaveIconType(string companyName, string applicationProductName, string name, NetIconImage.IconStyle value)
        {
            RegistryKey key = Registry.CurrentUser;
            key.SetValue(name, Convert.ToInt32(value));
        }
    }
}