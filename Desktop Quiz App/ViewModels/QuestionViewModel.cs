﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopQuizApp.ViewModels
{
    /// <summary>
    /// Contains paramaters for a specific questions
    /// </summary>
    /// <param name="query">The question being asked</param>
    /// <param name="correctAnswer">The index of the correct answer</param>
    /// <param name="value">An arbitrary value that the quiz can use to calculate score</param>
    /// <param name="penalty">The amount of negative points (out of the value) being subtracted upon a wrong answer</param>
    /// <param name="options">An array of possible answers</param>
    public struct QuestionViewModel(string query, int correctAnswer, float value, float penalty, string[] options)
    {
        public string Query { get; } = query;
        public string[] Options { get; } = options;
        public string CorrectAnswer { get; } = options[correctAnswer];


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
        public float CorrectPoints() { return _value; }

        /// <summary>
        /// Gets the amount of points that should be awarded if the answer is wrong
        /// </summary>
        /// <returns></returns>
        public float WrongPoints() { return -_value * _penalty; }

        // TODO: Replace this with something more sensible. I don't like the way you get the points, as it feels like getters and setters from Java.
    }
}