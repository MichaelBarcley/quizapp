using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Answer
    {
        public long Id { get; set; }
        public string Option { get; set; }
        public bool IsCorrect { get; set; }
    }
}
