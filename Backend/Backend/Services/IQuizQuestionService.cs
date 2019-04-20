using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services
{
    public interface IQuizQuestionService
    {
        Task<IEnumerable<QuizQuestion>> GetAllAsync();
        Task<QuizQuestion> GetByIdAsync(long Id);
        Task AddAsync(QuizQuestion question);
        Task DeleteByIdAsync(long Id);
    }
}
