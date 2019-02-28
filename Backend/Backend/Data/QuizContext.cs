using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data
{
    public class QuizContext : DbContext
    {
        public DbSet<QuizQuestion> QuizQuestions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public QuizContext(DbContextOptions<QuizContext> options) : base(options)
        {
        }
    }
}
