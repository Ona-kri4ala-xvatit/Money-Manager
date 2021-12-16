using Money_Manager.View;
using Money_Manager.Presenter;
namespace Money_Manager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            MainForm view = new MainForm();
            MainFormPresenter presenter = new MainFormPresenter(view);
            Application.Run(view);
        }
    }
}