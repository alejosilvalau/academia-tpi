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

        using (var login = new Login())
        {
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Main());
            }
        }
    }
}
