using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;
using Backend.Repositories;

namespace Backend.Services
{
    public class QuizQuestionService : IQuizQuestionService
    {
        private readonly IQuizQuestionRepository questionRepository;

        public QuizQuestionService(IQuizQuestionRepository _questionRepository)
        {
            questionRepository = _questionRepository;
        }

        public Task AddAsync(QuizQuestion question)
        {
            return questionRepository.AddAsync(question);
        }

        public Task DeleteByIdAsync(long id)
        {
            return questionRepository.DeleteByIdAsync(id);
        }

        public Task<IEnumerable<QuizQuestion>> GetAllAsync()
        {
            return questionRepository.GetAllAsync();
        }

        public Task<QuizQuestion> GetByIdAsync(long id)
        {
            return questionRepository.GetByIdAsync(id);
        }

        public Task<QuizQuestion> GetRandomAsync()
        {
            Random rnd = new Random();
            int questionDbSize = (int)questionRepository.GetDbEntriesNumberAsync().Result;
            int randomQuestionId = rnd.Next(1, questionDbSize);
            return questionRepository.GetByIdAsync(randomQuestionId);
        }
    }
}
