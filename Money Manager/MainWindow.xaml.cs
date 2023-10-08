using System.Windows;
using System.Windows.Input;

namespace Money_Manager
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
            this.Close();
        }
    }

    
}
