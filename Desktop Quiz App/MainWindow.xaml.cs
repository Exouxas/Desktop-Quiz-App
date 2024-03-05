using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Desktop_Quiz_App
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

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            // Spawn a file dialog box
        }

        // TODO: Event handler for next question
        // Either remove the previous question and add the new one, or update the control(s) to match

        // Sample of how to add and set position of item in Grid:
        // MainGrid.Children.Add(_welcomeScreen);
        // Grid.SetRow(_welcomeScreen, 1);
    }
}