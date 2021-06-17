using Microsoft.EntityFrameworkCore;
using QuizAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAPI.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : EntityBase
    {

        protected readonly QuizContext _quizContext;

        public BaseRepository(QuizContext quizContext) { _quizContext = quizContext; }

        public virtual T GetById(int id)
        {
            return _quizContext.Set<T>().Find(id);
        }
        public virtual IEnumerable<T> List()
        {
            return _quizContext.Set<T>().AsEnumerable();
        }
        public void Insert(T entity)
        {
            _quizContext.Set<T>().Add(entity);
            _quizContext.SaveChanges();
        }
        public void Update(T entity)
        {
            _quizContext.Entry(entity).State = EntityState.Modified;
            _quizContext.SaveChanges();
        }
        public void Delete(T entity)
        {
            _quizContext.Set<T>().Remove(entity);
            _quizContext.SaveChanges();
        }

    }
}
