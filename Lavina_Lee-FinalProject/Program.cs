namespace Lavina_Lee_FinalProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            TestForm new_test = new TestForm();
            Application.Run(new_test);
            return;
            XMLManager xmlManager = new XMLManager();
            LoginForm login_form = new LoginForm(ref xmlManager);
            login_form.Show();
            Application.Run();
        }
    }
}