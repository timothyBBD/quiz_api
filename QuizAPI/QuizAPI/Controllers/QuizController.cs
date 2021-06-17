using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizAPI.quizData;

namespace QuizAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {

        private IQuizData _quizData;
        //inject the mockData here 

        public QuizController(IQuizData quizData)
        {
            _quizData = quizData;
        }

      
        [HttpGet]
        [Route("list")]
        public ActionResult GetQuizzes()
        {

            return Ok(_quizData.GetQuizzes());
        }

        [HttpGet]
        [Route("category")]
        public ActionResult GetByQuizCategory()
        {

            return Ok(_quizData.GetQuizByCategory());
        }

        [HttpGet]
        public ActionResult GetQuiz(Guid quizId)
        {

            var quizById = _quizData.GetQuiz(quizId);
            if (quizById != null)
            {
                return Ok(quizById);
            }
            return NotFound($"quiz by specfic Id :{quizId} was not found");
        }

        [HttpPost]
        public ActionResult PostQuestion(string question, string category, string answer, Models.Quiz quiz)
        {//need to create a choice function within the inner part of the code for the 
            /*
                        var Q = question;
                        var C = category;
                        var A = answer;
                        var Choices = choices;*/
                        _quizData.Addquiz(quiz);
                        return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + quiz.QuizID, quiz);
        }

        [HttpDelete]
        public ActionResult deleteQ(Guid id)
        {

            var quizInfo = _quizData.GetQuiz(id);
            if (quizInfo != null)
            {
                _quizData.DeleteQuiz(quizInfo);
                return Ok();
            }
            return NotFound($"quiz by specfic Id :{id} was not found");
        }
    }
}
