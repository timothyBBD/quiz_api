using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Data.Models
{
    public class Answer : EntityBase
    {
        public Category Category { get; set; }
        public Question Question { get; set; }
        public bool IsCorrectAnswer { get; set; }
        public string AnswerValue { get; set; }
    }
}
