using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Data.Models
{
    public class Category : EntityBase
    { 
        public string Name { get; set; }
    }
}
