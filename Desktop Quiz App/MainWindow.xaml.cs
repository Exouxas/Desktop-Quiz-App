using DesktopQuizApp.Controls;
using DesktopQuizApp.ViewModels;
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

namespace DesktopQuizApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private QuizViewModel? _activeQuiz = null;
        private QuizControl? _currentQuizControl = null;

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
                _activeQuiz = new QuizViewModel();
                bool isFileLoaded = _activeQuiz.LoadQuiz(dialog.FileName);

                if(isFileLoaded)
                {
                    // Remove old quiz control
                    if(_currentQuizControl != null)
                    {
                        MainGrid.Children.Remove(_currentQuizControl);
                        _currentQuizControl = null;
                    }

                    // Create and add the new quiz control
                    _currentQuizControl = new(_activeQuiz);
                    MainGrid.Children.Add(_currentQuizControl);
                    Grid.SetRow(_currentQuizControl, 1);
                }
            }
        }
    }
}