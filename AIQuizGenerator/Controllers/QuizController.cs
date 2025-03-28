using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Route("api/quiz")]
[ApiController]
public class QuizController : ControllerBase
{
    private readonly GeminiService _geminiService;

    public QuizController(GeminiService geminiService)
    {
        _geminiService = geminiService;
    }

    [HttpGet("generate")]
    public async Task<IActionResult> GenerateQuiz(
        [FromQuery] string category = "General Knowledge", 
        [FromQuery] int numQuestions = 5,
        [FromQuery] string difficulty = "Easy")
    {
        var questions = await _geminiService.GenerateQuizQuestions(category, numQuestions, difficulty);
        return Ok(questions);
    }

    [HttpGet("general")]
    public async Task<IActionResult> GetGeneralKnowledgeQuiz()
    {
        var questions = await _geminiService.GenerateQuizQuestions("General Knowledge", 5, "Easy");
        return Ok(questions);
    }

    [HttpGet("math")]
    public async Task<IActionResult> GetMathQuiz()
    {
        var questions = await _geminiService.GenerateQuizQuestions("Math", 5, "Easy");
        return Ok(questions);
    }

    [HttpGet("sport")]
    public async Task<IActionResult> GetSportQuiz()
    {
        var questions = await _geminiService.GenerateQuizQuestions("Sports", 5, "Easy");
        return Ok(questions);
    }
    [HttpGet("coding")]
    public async Task<IActionResult> GetCodingQuiz()
    {
        var questions = await _geminiService.GenerateQuizQuestions("Coding", 5, "Easy");
        return Ok(questions);
    }
    [HttpGet("scince")]
    public async Task<IActionResult> GetScienceQuiz()
    {
        var questions = await _geminiService.GenerateQuizQuestions("Science", 5, "Easy");
        return Ok(questions);
    }
    [HttpGet("technology")]
    public async Task<IActionResult> GetTechnologyQuiz()
    {
        var questions = await _geminiService.GenerateQuizQuestions("Technology", 5, "Easy");
        return Ok(questions);
    }
    [HttpGet("history")]
    public async Task<IActionResult> GetHistoryQuiz()
    {
        var questions = await _geminiService.GenerateQuizQuestions("history", 5, "Easy");
        return Ok(questions);
    }
    [HttpGet("movies")]
    public async Task<IActionResult> GetMoviesQuiz()
    {
        var questions = await _geminiService.GenerateQuizQuestions("Movies", 5, "Easy");
        return Ok(questions);
    }
    [HttpGet("geography")]
    public async Task<IActionResult> GetGeographyQuiz()
    {
        var questions = await _geminiService.GenerateQuizQuestions("Geography", 5, "Easy");
        return Ok(questions);
    }
}
