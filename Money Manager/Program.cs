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
            MainForm mainForm = new MainForm();
            addBudgetForm addBudgetForm = new addBudgetForm();
            MainFormPresenter presenter = new MainFormPresenter(mainForm, addBudgetForm);
            Application.ThreadException += new ThreadExceptionEventHandler(Exception);
            Application.Run(mainForm);
        }

        static void Exception(object sander, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
        }
    }
}