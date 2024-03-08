using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DesktopQuizApp.ViewModels;

namespace DesktopQuizApp.Controls
{
    /// <summary>
    /// Interaction logic for QuizControl.xaml
    /// </summary>
    public partial class QuizControl : UserControl
    {
        private readonly QuizViewModel? _viewModel;

        public QuizControl()
        {
            InitializeComponent();
        }

        public QuizControl(QuizViewModel viewModel) : this()
        {
            _viewModel = viewModel;
            this.DataContext = viewModel;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            // If the next question can't be loaded
            if (!_viewModel.Next())
            {
                // Destroy the question area and show score
                QuizGrid.Children.Remove(QuestionGrid);
                QuizGrid.Children.Remove(NextButton);

                Label scoreLabel = new();
                scoreLabel.FontSize = 40;
                scoreLabel.Content = $"You got {_viewModel.Score} out of {_viewModel.MaxScore} points!";
                QuizGrid.Children.Add(scoreLabel);
                Grid.SetRow(scoreLabel, 1);
            }
        }
    }
}
