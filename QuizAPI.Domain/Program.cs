using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using QuizAPI.Data;
using QuizAPI.Data.Models;
using QuizAPI.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Domain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QuizContext dbContext = new QuizContext();
            IRepository < Question > questionRepo = new QuestionRepository(dbContext);
            var question = questionRepo.GetById(1);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
