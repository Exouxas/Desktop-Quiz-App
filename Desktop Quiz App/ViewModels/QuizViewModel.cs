using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopQuizApp.ViewModels
{
    /// <summary>
    /// Contains sets of questions and evaluates score
    /// </summary>
    public class QuizViewModel
    {
        public string Name { get; set; } = "";

        private List<QuestionViewModel> _questions = new();


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

                    _questions.Add(new QuestionViewModel(
                        parts[0],
                        int.Parse(parts[1]),
                        float.Parse(parts[2]),
                        float.Parse(parts[3]),
                        parts.Skip(4).ToArray()
                        ));
                }


                reader.Close();
                return true;
            }
        }

        
        // TODO: Method for evaluating and summing current question
        // TODO: Method for stepping to the next question
    }
}
