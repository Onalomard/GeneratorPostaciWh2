using GeneratorPostaciWh2.Encje;
using GeneratorPostaciWh2.Services;

namespace GeneratorPostaciWh2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
         


            ;
        }
    }
}