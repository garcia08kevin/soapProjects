using CON_UNI_SOAP_DOTNET_KGARCIA_CLIENTE;

namespace CON_UNI_RESTFUL_DOTNET_KGARCIA_CLIENTE
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
            Application.Run(new Form1());
        }
    }
}