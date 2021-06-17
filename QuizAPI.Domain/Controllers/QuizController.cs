using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizAPI.quizData;
using QuizAPI.Data.Repository;
using QuizAPI.Data.Models;

namespace QuizAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IRepository<Question> questionRepository;
        private readonly IRepository<Answer> answerRepository;
        private readonly IRepository<Category> categoryRepository;

        public QuizController(
            IRepository<Question> questionRepository, 
            IRepository<Answer> answerRepository, 
            IRepository<Category> categoryRepository)
        {
            this.questionRepository = questionRepository;
            this.answerRepository = answerRepository;
            this.categoryRepository = categoryRepository;
        }


        [HttpGet]
        [Route("questions/{id}")]
        public ActionResult GetQuestions(int id)
        {
            Question question = questionRepository.GetById(id);


            return Ok(question);
        }

        [HttpGet]
        [Route("questions")]
        public ActionResult GetQuestions()
        {
            List<Question> questions = questionRepository.List().ToList();
            return Ok(questions);
        }


        [HttpGet]
        [Route("questions/category/{categoryId}")]
        public ActionResult GetQuestionsByCategory(int categoryId)
        {
            IEnumerable<Question> questions = from q in questionRepository.List()
                                              where q.Category.Id == categoryId
                                              select q;

            return Ok(questions);
        }

        [HttpGet]
        [Route("category")]
        public ActionResult GetCategories()
        {
            IEnumerable<Category> categories = categoryRepository.List();
            return Ok(categories);
        }

        [HttpGet]
        [Route("answers/question/{questionID}")]
        public ActionResult GetQuestionAnswers(int questionID)
        {

            IEnumerable<Answer> answer = from a in answerRepository.List()
                                         where a.QuestionId == questionID
                                         select a;
            return Ok(answer);
        }

        [HttpGet]
        [Route("answers")]
        public ActionResult getAnswers()
        {
            IEnumerable<Answer> answers = answerRepository.List();

            return Ok(answers);
        }




    }
}
