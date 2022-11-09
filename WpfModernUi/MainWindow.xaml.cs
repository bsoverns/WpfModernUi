//Example based on https://www.youtube.com/watch?v=HQoPNbTXa_M
//C# WPF UI Academy

using System.Windows;
using System.Windows.Input;

namespace WpfModernUi
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

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}
