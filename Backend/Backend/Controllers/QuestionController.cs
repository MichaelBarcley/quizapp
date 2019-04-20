using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api")]
    public class QuestionController : Controller
    {
        public readonly IQuizQuestionService questionService;

        public QuestionController(IQuizQuestionService _questionService)
        {
            questionService = _questionService;
        }

        [HttpGet("questions")]
        public async Task<IEnumerable<QuizQuestion>> GetAllQuestions()
        {
            return await questionService.GetAllAsync();
        }
    }
}
