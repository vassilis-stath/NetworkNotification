using System;
using System.Runtime.InteropServices;

namespace NetworkNotification
{
    internal static class NativeMethods
    {
        [DllImport("dwmapi.dll", EntryPoint = "DwmIsCompositionEnabled")]
        internal static extern IntPtr DwmIsCompositionEnabled(out bool enabled);
    }
}
