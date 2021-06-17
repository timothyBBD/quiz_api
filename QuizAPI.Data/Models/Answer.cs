using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Data.Models
{
    public class Answer : EntityBase
    {
        public int CategoryId { get; set; }
        public int QuestionId { get; set; }
        public bool IsCorrectAnswer { get; set; }
        public string AnswerValue { get; set; }
    }
}
