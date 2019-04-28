using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Data;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories
{
    public class QuizQuestionRepository : IQuizQuestionRepository
    {
        private readonly QuizContext quizContext;

        public QuizQuestionRepository(QuizContext _quizContext)
        {
            quizContext = _quizContext;
        }

        public async Task AddAsync(QuizQuestion question)
        {
            quizContext.Add(question);
            await quizContext.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(long Id)
        {
            quizContext.Remove(GetByIdAsync(Id));
            await quizContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<QuizQuestion>> GetAllAsync()
        {
            return await quizContext.QuizQuestions.Include(question => question.Answers).ToListAsync(); ;
        }

        public async Task<QuizQuestion> GetByIdAsync(long Id)
        {
            return await quizContext.QuizQuestions.Include(question => question.Answers).FirstOrDefaultAsync(question => question.Id == Id);
        }

        public async Task<long> GetDbEntriesNumberAsync()
        {
            return await quizContext.QuizQuestions.CountAsync();
        }
    }
}
