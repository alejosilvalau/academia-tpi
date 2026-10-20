using System.Drawing;
using System.Drawing.Drawing2D;
using Contratos;
using Microsoft.Extensions.Configuration;

namespace UI.Desktop;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
        Application.ThreadException += (_, e) => MostrarFatal(e.Exception);
        AppDomain.CurrentDomain.UnhandledException += (_, e) =>
        {
            if (e.ExceptionObject is Exception ex) MostrarFatal(ex);
        };

        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        var baseUrl = configuration["Api:BaseUrl"] ?? "http://localhost:5006/";
        ApiEscritorio.Inicializar(baseUrl);

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

    private static void MostrarFatal(Exception? ex)
    {
        var mensaje = ex switch
        {
            ApiException ax => ax.Message,
            null => "Ocurrió un error desconocido.",
            _ => "Ocurrió un error inesperado en la aplicación. Intente nuevamente."
        };
        try
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch
        {
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
