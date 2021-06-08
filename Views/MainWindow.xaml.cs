using System.IO;
using System.Windows;


namespace Garbage_Organizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            bool? response = openFileDialog.ShowDialog();
            if (response == true)
            {
                 string filePath = openFileDialog.FileName;
                string fileName = Path.GetDirectoryName(filePath);
            }

            
        }
    }
}
