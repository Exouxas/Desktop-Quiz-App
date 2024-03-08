using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using DesktopQuizApp.Models;

namespace DesktopQuizApp.ViewModels
{
    /// <summary>
    /// Contains sets of questions and evaluates score
    /// </summary>
    public partial class QuizViewModel : ObservableObject
    {
        public string Name { get; set; } = "";

        private float _score = 0;
        public float Score
        {
            get => _score;
        }

        private float _maxScore = 0;
        public float MaxScore
        {
            get => _maxScore;
        }


        [ObservableProperty]
        private QuestionModel _currentQuestion;


        private List<QuestionModel> _questions = new();
        private int _questionPointer = 0;

        public QuizViewModel()
        {

        }

        public bool LoadQuiz(string filename)
        {
            using(StreamReader reader = new(filename))
            {
                _questions.Clear();

                Name = reader.ReadLine() ?? "Quiz";

                while(!reader.EndOfStream)
                {
                    string? line = reader.ReadLine();
                    if (line == null) return false;

                    string[] parts = line.Split(';');

                    _questions.Add(new QuestionModel(
                        parts[0],
                        int.Parse(parts[1]),
                        float.Parse(parts[2]),
                        float.Parse(parts[3]),
                        parts.Skip(4).ToArray()
                        ));
                }

                CurrentQuestion = _questions.FirstOrDefault();
                _questionPointer = 0;

                reader.Close();
                return true;
            }
        }

        public bool Next()
        {
            _score += CurrentQuestion.CheckAnswer();
            _maxScore += CurrentQuestion.Value;

            _questionPointer++;
            if (_questionPointer >= _questions.Count) return false;


            CurrentQuestion = _questions[_questionPointer];
            return true;
        }

        
    }
}
