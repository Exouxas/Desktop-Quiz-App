using System;
using System.Collections.Generic;
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
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename">Full path to the quiz to be loaded</param>
        public QuizViewModel()
        {
            // TODO: Logic for loading the file
            // TODO: Logic for populating list with questions
        }

        public bool LoadQuiz(string filename)
        {
            return false;
        }

        
        // TODO: Method for evaluating and summing current question
        // TODO: Method for stepping to the next question
    }
}
