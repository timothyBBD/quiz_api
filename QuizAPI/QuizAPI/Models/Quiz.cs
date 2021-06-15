using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; }
        public int Answer { get; set; }
        public int CategoryID { get; set; }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryText { get; set; }
    }

    public class Answer
    {
        public int AnswerID { get; set; }
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }

    }

    public class Choice
    { }

    public class Quiz
    {
        public int QuizID { get; set; }
        public string QuizType { get; set; } //MCQ OR True/False
        public string CategoryID { get; set; }
        public string Name { get; set; }
    }
}
