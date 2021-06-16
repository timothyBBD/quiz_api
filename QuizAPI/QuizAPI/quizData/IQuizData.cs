using QuizAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.quizData
{
   public interface IQuizData
    {
        List<Quiz> GetQuizzes();

        List<Quiz> GetQuizByCategory();

        Quiz GetQuiz(Guid id);


        Quiz Addquiz(Quiz newQuiz);

        void DeleteQuiz(Quiz quizEntry);
    }
}
