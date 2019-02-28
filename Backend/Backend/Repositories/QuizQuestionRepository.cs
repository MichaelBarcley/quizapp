using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Data;
using Backend.Models;

namespace Backend.Repositories
{
    public class QuizQuestionRepository : IQuizQuestionRepository
    {
        private readonly QuizContext _quizContext;

        public QuizQuestionRepository(QuizContext quizContext)
        {
            _quizContext = quizContext;
        }

        public void Add(QuizQuestion question)
        {
            _quizContext.Add(question);
            _quizContext.SaveChanges();
        }

        public void DeleteById(long Id)
        {
            _quizContext.Remove(GetById(Id));
            _quizContext.SaveChanges();
        }

        public IEnumerable<QuizQuestion> GetAll()
        {
            return _quizContext.QuizQuestions;
        }

        public QuizQuestion GetById(long Id)
        {
            return _quizContext.QuizQuestions.First(question => question.Id == Id);
        }
    }
}
