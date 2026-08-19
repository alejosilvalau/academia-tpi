using System.Drawing;
using System.Drawing.Drawing2D;
using Servicios.Excepciones;
using Repositorio;

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

    private static void MostrarFatal(Exception? ex)
    {
        var mensaje = ex switch
        {
            ServicioException sx => sx.Message,
            null => "Ocurrió un error desconocido.",
            _ => "Ocurrió un error inesperado en la aplicación. Intente nuevamente."
        };
        try
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch
        {
            // Si no se puede mostrar el cuadro (por ejemplo, durante el cierre), se ignora.
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
