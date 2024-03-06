using Microsoft.Win32;
using System.Diagnostics;
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
        private Quiz? _activeQuiz = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.Filter = "Quiz files|*.quiz";
            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                _activeQuiz = new Quiz(dialog.FileName);
            }
        }

        // TODO: Event handler for next question
        // Either remove the previous question and add the new one, or update the control(s) to match

        // Sample of how to add and set position of item in Grid:
        // MainGrid.Children.Add(_welcomeScreen);
        // Grid.SetRow(_welcomeScreen, 1);
    }
}