using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Data.Models
{
    public class Question : EntityBase
    {
        public Category Category { get; set; }
        public string QuestionText { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
    }
}
