using Microsoft.EntityFrameworkCore;
using QuizAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAPI.Data.Repository
{

    public class AnswerRepository : BaseRepository<Answer>
    {
        public AnswerRepository(QuizContext quizContext) : base(quizContext) { }

        public override Answer GetById(int id)
        {
            return _quizContext.Answers
                .Include(q => q.Question)
                .Include(q => q.Category)
                .FirstOrDefault(q => q.Id == id);
        }
    }
}
