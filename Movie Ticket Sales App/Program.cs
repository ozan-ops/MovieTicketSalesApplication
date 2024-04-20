namespace Movie_Ticket_Sales_App
{
    public static class Program
    {
        public static HomePage homePage = new HomePage();
        public const string pathDB = @"DB\DB.db";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(homePage);
        }

        public static bool existsDB()
        {
            if (!File.Exists(pathDB))
                return false;

            return true;
        }
    }
}