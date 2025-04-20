using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Security;

namespace MPos
{
    /// <summary>
    /// Represents a Win32 point structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]

    public struct WinPoint
    {
        public int X;
        public int Y;

        public static explicit operator Point(WinPoint point)
        {
            return new Point(point.X, point.Y);
        }

        public static explicit operator WinPoint(Point point)
        {
            WinPoint pt = new WinPoint();
            pt.X = (int)point.X;
            pt.Y = (int)point.Y;
            return pt;
        }
    }

    public enum MonitorOptions
    {
        MONITOR_DEFUALRRONULL = 0,
        MONITOR_DEFAULTTOPRIMARY = 1,
        MONITOR_DEFUALTTONEAREST = 2 // ← TIP: hay un typo aquí en DEFUALT
    }

    public enum MonitorDpiType
    {
        EFFECTIVE_DPI = 0,
        ANGULAR_DPI = 1,
        RAW_DPI = 2,
    }

    /// <summary>
    /// A class that wraps some used Win32 Api calls.
    /// </summary>
    public static class WinApi
    {
        public struct MARGINS
        {
            public int cxLeftWidth;
            public int cxRightWidth;
            public int cyTopHeight;
            public int cyBottomHeight;
        }

        #region API methods

        [SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll")]
        private static extern bool ScreenToClient(IntPtr hWnd, ref WinPoint lpPoint);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll")]
        public static extern IntPtr MonitorFromPoint(WinPoint pt, MonitorOptions dwFlags); // ← cambiado a public

        // requires Windows 8.1 or newer
        [SuppressUnmanagedCodeSecurity]
        [DllImport("Shcore.dll")]
        public static extern int GetDpiForMonitor(IntPtr hmonitor, MonitorDpiType dpiType, out int dpiX, out int dpiY); // ← cambiado a public y tipo de retorno corregido

        [SuppressUnmanagedCodeSecurity]
        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateRoundRectRgn(int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS margins);


        #endregion

        #region Static methods

        /// <summary>
        /// Maps a point in screen coordinates to coordinates relative to the active window.
        /// </summary>
        public static WinPoint ScreenPointToClient(WinPoint point)
        {
            IntPtr hWnd = GetForegroundWindow();
            ScreenToClient(hWnd, ref point);
            return point;
        }

        /// <summary>
        /// Gets the dpi of the monitor from a screen point.
        /// </summary>
        public static int GetMonitorDpiFromPoint(WinPoint pt, MonitorDpiType dpiType)
        {
            IntPtr hmonitor = MonitorFromPoint(pt, MonitorOptions.MONITOR_DEFUALTTONEAREST);
            GetDpiForMonitor(hmonitor, dpiType, out int dpiX, out int dpiY);
            return dpiX;
        }

        #endregion
    }
}
