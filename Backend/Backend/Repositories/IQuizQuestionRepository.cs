using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public interface IQuizQuestionRepository
    {
        IEnumerable<QuizQuestion> GetAll();
        QuizQuestion GetById(long Id);
        void Add(QuizQuestion question);
        void DeleteById(long Id);
    }
}
