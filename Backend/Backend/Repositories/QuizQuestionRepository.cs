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
        private readonly QuizContext _quizContext;

        public QuizQuestionRepository(QuizContext quizContext)
        {
            _quizContext = quizContext;
        }

        public async Task AddAsync(QuizQuestion question)
        {
            _quizContext.Add(question);
            await _quizContext.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(long Id)
        {
            _quizContext.Remove(GetByIdAsync(Id));
            await _quizContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<QuizQuestion>> GetAllAsync()
        {
            return await _quizContext.QuizQuestions.Include(question => question.Answers).ToListAsync(); ;
        }

        public async Task<QuizQuestion> GetByIdAsync(long Id)
        {
            return await _quizContext.QuizQuestions.FirstOrDefaultAsync(question => question.Id == Id);
        }

        public async Task<long> GetDbEntriesNumberAsync()
        {
            return await _quizContext.QuizQuestions.CountAsync();
        }
    }
}
