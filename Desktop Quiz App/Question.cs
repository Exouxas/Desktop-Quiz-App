using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopQuizApp
{
    /// <summary>
    /// Contains paramaters for a specific questions
    /// </summary>
    /// <param name="query">The question being asked</param>
    /// <param name="options">An array of possible answers</param>
    /// <param name="correctAnswer">The index of the correct answer</param>
    /// <param name="value">An arbitrary value that the quiz can use to calculate score</param>
    /// <param name="penalty">The amount of negative points (out of the value) being subtracted upon a wrong answer</param>
    public struct Question(string query, string[] options, int correctAnswer, float value, float penalty)
    {
        private string _query = query;
        private string[] _options = options;
        private int _correctAnswer = correctAnswer;
        private float _value = value;
        private float _penalty = penalty;

        /// <summary>
        /// Checks whether the answer is correct
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        public bool CheckAnswer(int answer) { return answer == _correctAnswer; }

        /// <summary>
        /// Gets the amount of points that should be awarded if the answer is correct
        /// </summary>
        /// <returns></returns>
        public float CorrectPoints() { return _correctAnswer; }

        /// <summary>
        /// Gets the amount of points that should be awarded if the answer is wrong
        /// </summary>
        /// <returns></returns>
        public float WrongPoints() { return -_correctAnswer * _penalty; }

        // TODO: Replace this with something more sensible. I don't like the way you get the points, as it feels like getters and setters from Java.
    }
}
