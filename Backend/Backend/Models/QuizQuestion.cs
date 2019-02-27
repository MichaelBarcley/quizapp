using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class QuizQuestion
    {
        public long Id { get; set; }
        public string Question { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
