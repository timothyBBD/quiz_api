using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetQuiz(string quizType)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult PostQuestion(string question, string category, string answer, List<string>choices)
        {
            return Ok();
        }

        [HttpDelete]
        public ActionResult deleteQ(int id)
        {
            return Ok();
        }
    }
}
