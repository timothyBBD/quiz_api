using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizAPI.DB;
using QuizAPI.Models;

namespace QuizAPI.Controllers
{
    /*public class QuestionsFactory
    {
        public QuestionType MakeQuestionType(string questionType)
        {
            QuestionType type = null;

            if (questionType.Equals("MCQ"))
            {
                return new MCQ();
            }
            if (questionType.Equals("TrueFalse"))
            {
                return new TrueFalse();
            }
            else
            {
                return type;
            }
        }
    }

    public abstract class QuestionType
    {
        private string Type;
        
       /* public void setQustionType(string questionType)
        {
            Type = questionType;
        }*/

       /* public MCQ getType()
        {
            return new MCQ();
        }
        
        
    }

    public interface Quest
    {
        public string getQuestionType(string question);
    }

    public class MCQ : QuestionType
    {
        public MCQ()
        {
            //setQustionType("Multiple Choice Question");
        }

        public ActionResult CreateMCQ(int number)
        {
            List<Question> mcq = null;
            using (QuizContext db = new QuizContext())
            {
                //Fetch from DB
            }

            //return mcq json result;
            return new AcceptedResult();
        }
        
    }

    public class TrueFalse : QuestionType
    {
        
    }
    */
      /* public interface IMCQ {}
       public interface ITrueFalse {}
       
       public interface IQuestionFactory
       {
           public IMCQ CreateMcq();
           public ITrueFalse CreateTrueFalse();
       }

       public class EasyQuestionsFactory : IQuestionFactory
       {
           public IMCQ CreateMcq() {}
           public ITrueFalse CreateTrueFalse() {}
       }
       
       public class HardQuestionsFactory : IQuestionFactory
       {
           public IMCQ CreateMcq() {}
           public ITrueFalse CreateTrueFalse() {}
       }

       public class EasyMcq : EasyQuestionsFactory, IMCQ
       {
           
       }
       
       public class EasyTrueFalse : EasyQuestionsFactory, ITrueFalse
       {
           
       }
       
       public class HardMcq : HardQuestionsFactory, IMCQ
       {
           
       }
       
       public class HardTrueFalse : HardQuestionsFactory, ITrueFalse
       {
           
       }
       */

       [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        [HttpGet("{quizType}")]
        /*public ActionResult<QuestionType> GetQuiz(string quizType)
        {
            QuestionsFactory questionsFactory = new QuestionsFactory();
            var questionType = questionsFactory.MakeQuestionType(quizType);
            return questionType;
        }*/

        [HttpGet("/test/{id}")]
        public ActionResult<Question> Test(int id)
        {
            QuizContext quizContext;
            Question question;

            using (quizContext = new QuizContext())
            {
                question = quizContext.Questions.Where(e => e.QuestionID == id).FirstOrDefault();
                Console.WriteLine(question);
                return question;
            }
            
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
