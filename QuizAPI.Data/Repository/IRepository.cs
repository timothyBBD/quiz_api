using QuizAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuizAPI.Data.Repository
{ 
    public interface IRepository<T> where T: EntityBase
    {
        T GetById(int Id);
        IEnumerable<T> List();
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
