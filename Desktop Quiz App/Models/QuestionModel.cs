using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopQuizApp.Models
{
    /// <summary>
    /// Contains paramaters for a specific questions
    /// </summary>
    /// <param name="query">The question being asked</param>
    /// <param name="correctAnswer">The index of the correct answer</param>
    /// <param name="value">An arbitrary value that the quiz can use to calculate score</param>
    /// <param name="penalty">The amount of negative points (out of the value) being subtracted upon a wrong answer</param>
    /// <param name="options">An array of possible answers</param>
    public class QuestionModel(string query, int correctAnswer, float value, float penalty, string[] options)
    {
        public string Query { get; } = query;
        public string[] Options { get; } = options;
        public int SelectedAnswer { get; set; } = 0;
        public string CorrectAnswer { get; } = options[correctAnswer];
        public float Value { get; } = value;


        private int _correctAnswerIndex = correctAnswer;
        private float _penalty = penalty;

        /// <summary>
        /// Checks whether the answer is correct
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        public float CheckAnswer() 
        { 
            if(SelectedAnswer == _correctAnswerIndex)
            {
                return Value;
            }
            else
            {
                return -Value * _penalty;
            }
        }
    }
}
