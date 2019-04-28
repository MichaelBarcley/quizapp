using Backend.Extensions;
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
        public async Task<IActionResult> GetAllQuestions()
        {
            var questions = await questionService.GetAllAsync();
            return StatusCode(200, questions);
        }

        [HttpPost("questions")]
        public async Task<IActionResult> AddQuestion([FromBody] QuizQuestion question)
        {
            if (question.IsAnyPropertyNull())
            {
                return StatusCode(400, "not so noice");
            }
            await questionService.AddAsync(question);
            return StatusCode(201, "noice");
        }

        [HttpGet("random")]
        public async Task<IActionResult> GetRandomQuestion()
        {
            var randomQuestion = await questionService.GetRandomAsync();
            return StatusCode(200, randomQuestion);
        }
    }
}
