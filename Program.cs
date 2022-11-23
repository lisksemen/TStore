namespace TStore
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (StreamWriter w = File.AppendText("database.dat")) { w.Close(); };
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}