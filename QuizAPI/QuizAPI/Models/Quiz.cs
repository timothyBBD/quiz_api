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
        public string Answer { get; set; }
        public ICollection<Choice> Choices { get; set; }
        public int CategoryID { get; set; }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryText { get; set; }
    }

    public class Answer
    {
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public bool IsCorrect { get; set; }

    }

    public class Choice
    { }

    public class Quiz
    {
        public Guid QuizID { get; set; }
        public string QuizType { get; set; } //MCQ OR True/False
        public string CategoryID { get; set; }
        public string Name { get; set; }
    }
}
