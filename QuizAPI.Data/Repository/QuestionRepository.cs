using Microsoft.EntityFrameworkCore;
using QuizAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAPI.Data.Repository
{

    public class QuestionRepository : BaseRepository<Question>
    {
        public QuestionRepository(QuizContext quizContext) : base(quizContext) { }

        public override Question GetById(int id)
        {
            return _quizContext.Questions
                .Include(q => q.Category)
                .FirstOrDefault(q => q.Id == id);
        }

        public override IEnumerable<Question> List() 
        {
            return _quizContext.Questions
                .Include(q => q.Category)
                .AsEnumerable();
        }


    }
}
