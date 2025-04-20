using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MPos
{
    public struct PositionData
    {
        public readonly Point PhysicalPosition;
        public readonly Point ScaledPosition;
        public readonly Point RelativePosition;

        public readonly int Dpi;
        public readonly int RawDpi;
        public readonly double DpiScaling;
        public readonly double DpiRawRatio;

        public readonly Size ScreenResolution;
        public readonly Color PixelColor;

        public readonly string MonitorName; // NUEVO: nombre del monitor

        public PositionData(Point position)
        {
            WinPoint winPos = (WinPoint)position;
            this.PhysicalPosition = position;

            // Obtener pantalla actual
            var allScreens = Screen.AllScreens;
            var screen = Screen.FromPoint(position);
            var index = Array.IndexOf(allScreens, screen);
            this.MonitorName = GetMonitorFriendlyName(index + 1); // 1-based index
            this.ScreenResolution = screen.Bounds.Size;

            // DPI efectivo (escalado lógico)
            this.Dpi = WinApi.GetMonitorDpiFromPoint(winPos, MonitorDpiType.EFFECTIVE_DPI);
            this.DpiScaling = Math.Round(Dpi / 96.0, 2);

            // Posición escalada
            this.ScaledPosition = new Point(
                (int)(position.X / DpiScaling),
                (int)(position.Y / DpiScaling)
            );

            // Posición relativa a ventana activa
            this.RelativePosition = (Point)WinApi.ScreenPointToClient(winPos);

            // DPI físico (sin escalado)
            this.RawDpi = WinApi.GetMonitorDpiFromPoint(winPos, MonitorDpiType.RAW_DPI);
            this.DpiRawRatio = Math.Round(RawDpi / (double)Dpi, 2);

            // Color del píxel bajo el cursor
            this.PixelColor = GetPixelColor(winPos);
        }

        public static Color GetPixelColor(WinPoint point)
        {
            Bitmap bmp = new Bitmap(1, 1);
            try
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(point.X, point.Y, 0, 0, new Size(1, 1));
                }
                return bmp.GetPixel(0, 0);
            }
            finally
            {
                bmp.Dispose();
            }
        }

        public override string ToString() => ToString(new Settings());

        public string ToString(Settings settings)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(formatPoint(settings, "Physical", PhysicalPosition));
            if (settings.ScaledVisible)
                sb.Append("; ").Append(formatPoint(settings, "Scaled", ScaledPosition));
            if (settings.RelativeVisible)
                sb.Append("; ").Append(formatPoint(settings, "Relative", RelativePosition));
            if (settings.DpiVisible)
                sb.Append("; ").Append(formatDpi(settings));
            if (settings.ScreenResolutionVisible)
                sb.Append("; ").Append(formatResolution(settings, "Screen Resolution", ScreenResolution));
            if (settings.PixelColorVisible)
                sb.Append("; ").Append(formatColor(settings, PixelColor));
            return sb.ToString();
        }

        private StringBuilder formatPoint(Settings settings, string name, Point p)
            => new StringBuilder(settings.DataFormatPoint)
                .Replace("{name}", name)
                .Replace("{x}", p.X.ToString())
                .Replace("{y}", p.Y.ToString());

        private StringBuilder formatDpi(Settings settings)
            => new StringBuilder(settings.DataFormatDpi)
                .Replace("{dpi}", Dpi.ToString())
                .Replace("{rawDpi}", RawDpi.ToString())
                .Replace("{dpiRatio}", DpiRawRatio.ToString("0.00"));

        private StringBuilder formatResolution(Settings settings, string name, Size s)
            => new StringBuilder(settings.DataFormatResolution)
                .Replace("{name}", name)
                .Replace("{x}", s.Width.ToString())
                .Replace("{y}", s.Height.ToString());

        private StringBuilder formatColor(Settings settings, Color c)
            => new StringBuilder(settings.DataFormatColor)
                .Replace("{value}", ColorTranslator.ToHtml(c));


        private static string GetMonitorFriendlyName(int displayIndex)
        {
            try
            {
                using (var searcher = new System.Management.ManagementObjectSearcher(
                    @"root\wmi", "SELECT * FROM WmiMonitorID"))
                {
                    int i = 1;
                    foreach (var obj in searcher.Get())
                    {
                        // Skip until we match the display index
                        if (i++ != displayIndex)
                            continue;

                        var nameBytes = (ushort[])obj["UserFriendlyName"];
                        string name = System.Text.Encoding.ASCII.GetString(nameBytes.Where(b => b != 0).Select(b => (byte)b).ToArray());
                        return name;
                    }
                }
            }
            catch { }
            return $"Monitor {displayIndex}";
        }
    }
}
