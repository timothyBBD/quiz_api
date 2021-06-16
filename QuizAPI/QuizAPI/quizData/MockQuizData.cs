using QuizAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.quizData
{
    public class MockQuizData : IQuizData
    {

        private List<Quiz> quizzes = new List<Quiz>() {

            new Quiz()
            {
                QuizID = Guid.NewGuid(),
                QuizType = "Eskom is so reliable",
                CategoryID = "General knownledge",
                 Name = "Politic"
            },  new Quiz()
            {
                QuizID = Guid.NewGuid(),
                QuizType = "water is a solid",
                CategoryID = "Phyisc",
                 Name = "Education"
            },  new Quiz()
            {
                QuizID = Guid.NewGuid(),
                QuizType = "Kerane is Hungry",
                CategoryID = "Mystery",
                 Name = "Mystery"
            }
        };


        public Quiz Addquiz(Quiz newQuiz)
        {

            newQuiz.QuizID = Guid.NewGuid();
          /*  newQuiz.QuizType =;
            newQuiz.Name =;
            newQuiz.CategoryID =;*/
            quizzes.Add(newQuiz);

            return newQuiz;
        }

        public void DeleteQuiz(Quiz quizEntry)
        {
            quizzes.Remove(quizEntry);
        }

        public Quiz GetQuiz(Guid id)
        {
            return quizzes.SingleOrDefault(x => x.QuizID == id);
        }

        public List<Quiz> GetQuizByCategory()
        {
            throw new NotImplementedException();
        }

        public List<Quiz> GetQuizzes()
        {
            return quizzes;
        }
    }
}
