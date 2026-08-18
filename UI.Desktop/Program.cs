namespace UI.Desktop;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        using (var login = new Login())
        {
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Main());
            }
        }
    }
}
