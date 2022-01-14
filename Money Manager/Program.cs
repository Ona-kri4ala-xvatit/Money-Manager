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
            MainForm mainForm = new();
            MainFormPresenter presenter = new(mainForm);

            Application.ThreadException += new ThreadExceptionEventHandler(Exception);
            Application.Run(mainForm);
        }

        public static void OpenAddBudgetForm()
        {
            AddBudgetForm addBudgetForm = new();
            AddBudgetFormPresenter presenter = new(addBudgetForm);
            addBudgetForm.ShowDialog();
        }

        static void Exception(object sander, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
        }
    }
}