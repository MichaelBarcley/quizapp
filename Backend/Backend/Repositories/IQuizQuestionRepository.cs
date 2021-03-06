﻿using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public interface IQuizQuestionRepository
    {
        Task<IEnumerable<QuizQuestion>> GetAllAsync();
        Task<QuizQuestion> GetByIdAsync(long Id);
        Task<long> GetDbEntriesNumberAsync();
        Task AddAsync(QuizQuestion question);
        Task DeleteByIdAsync(long Id);
    }
}
