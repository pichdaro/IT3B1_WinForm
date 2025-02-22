namespace IT3B1_WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //frmSplashScreen logo = new frmSplashScreen();
            //logo.ShowDialog();
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                //Run frmMain() after successful login
                Application.Run(new frmMain());
            }

        }
    }
}