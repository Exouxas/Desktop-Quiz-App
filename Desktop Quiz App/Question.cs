using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Quiz_App
{
    /// <summary>
    /// Contains paramaters for a specific questions
    /// </summary>
    public class Question
    {
        private string _query; // The question in... question
        private string[] _options; // List of potential options
        private int _correctAnswer; // Index of _options
        private float _value; // Arbitrary number
        private float _penalty; // In percent


    }
}
