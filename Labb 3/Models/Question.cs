using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3.Models
{
    internal class Question
    {
        public Question(string query, string correctAnswer, string incorrectAnswer1, string incorrectAnswer2, string incorrectAnswer3)
        {
            Query = query;
            CorrectAnswer = correctAnswer;
            IncorrectAnswers = new string[3];
            IncorrectAnswers[0] = incorrectAnswer1;
            IncorrectAnswers[1] = incorrectAnswer2;
            IncorrectAnswers[2] = incorrectAnswer3;
        }

        public string Query { get; set;}
        public string CorrectAnswer { get; set;}
        public string[] IncorrectAnswers { get; set;}
    }
}
