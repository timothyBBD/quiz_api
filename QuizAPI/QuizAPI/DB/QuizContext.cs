using QuizAPI.Models;
using System.Data.Entity;

namespace QuizAPI.DB
{
   
    public class QuizContext : DbContext
    {
        private readonly DbContext _context;
        public QuizContext() : base("QuizContext") { }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Quiz> quizzes { get; set; }


    }
}