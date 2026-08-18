using System.Drawing;
using System.Drawing.Drawing2D;
using Repositorio;

namespace UI.Desktop;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        using (var context = new AcademiaContext())
        {
            context.Database.EnsureCreated();
        }

        var icon = GenerateIcon();

        using (var login = new Login())
        {
            login.Icon = icon;
            if (login.ShowDialog() == DialogResult.OK)
            {
                using (var main = new Main())
                {
                    main.Icon = icon;
                    Application.Run(main);
                }
            }
        }
    }

    private static Icon GenerateIcon()
    {
        var bmp = new Bitmap(64, 64);
        using (var g = Graphics.FromImage(bmp))
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            g.Clear(Color.Transparent);

            using (var font = new Font("Arial", 48, FontStyle.Bold, GraphicsUnit.Pixel))
            using (var brush = new SolidBrush(Color.FromArgb(255, 193, 7)))
            {
                var rect = new RectangleF(0, 0, 64, 64);
                var format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                g.DrawString("A", font, brush, rect, format);
            }
        }

        IntPtr hIcon = bmp.GetHicon();
        var icon = Icon.FromHandle(hIcon);
        return icon;
    }
}
