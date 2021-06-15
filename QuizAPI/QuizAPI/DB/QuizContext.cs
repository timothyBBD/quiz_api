using Microsoft.EntityFrameworkCore;

namespace QuizAPI.DB
{
    public class QuizContext : DbContext
    {
        private readonly DbContext _context;
    }
}