using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;

public class GeminiService
{
    private readonly string _apiKey;
    private const string API_URL = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent";

    public GeminiService(IConfiguration configuration)
    {
        _apiKey = configuration["GeminiAPI:Key"];
    }

    public async Task<string> GenerateQuizQuestions(string category, int numQuestions, string difficulty)
    {
        var client = new RestClient($"{API_URL}?key={_apiKey}");
        var request = new RestRequest("", Method.Post); 
        request.AddHeader("Content-Type", "application/json");

var prompt = $"Generate {numQuestions} {difficulty} multiple-choice questions on {category}. Ensure that each question is unique and is different at each timestamp. Format the output as JSON with 'question', 'options', and 'answer'.";

        var body = new
        {
            contents = new[]
            {
                new { parts = new[] { new { text = prompt } } }
            }
        };

        request.AddJsonBody(body);

        var response = await client.ExecuteAsync(request);
        return response.Content;
    }
}
