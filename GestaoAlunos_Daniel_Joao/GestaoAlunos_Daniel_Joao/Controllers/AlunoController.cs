using Microsoft.AspNetCore.Mvc;
using GestaoAlunos_Daniel_Joao.Models;

namespace GestaoAlunos_Daniel_Joao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AlunoController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var client = _httpClientFactory.CreateClient("Imposter");
            var response = await client.GetAsync("/api/alunos");
            var content = await response.Content.ReadAsStringAsync();
            return StatusCode((int)response.StatusCode, content);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var client = _httpClientFactory.CreateClient("Imposter");
            var response = await client.GetAsync($"/api/alunos/{id}");
            var content = await response.Content.ReadAsStringAsync();
            return StatusCode((int)response.StatusCode, content);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Aluno body)
        {
            var client = _httpClientFactory.CreateClient("Imposter");
            var response = await client.PostAsJsonAsync("/api/alunos", body);
            var content = await response.Content.ReadAsStringAsync();
            return StatusCode((int)response.StatusCode, content);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Aluno body)
        {
            var client = _httpClientFactory.CreateClient("Imposter");
            var response = await client.PutAsJsonAsync($"/api/alunos/{id}", body);
            var content = await response.Content.ReadAsStringAsync();
            return StatusCode((int)response.StatusCode, content);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, [FromHeader(Name = "Authorization")] string? authorization)
        {
            var client = _httpClientFactory.CreateClient("Imposter");
            var request = new HttpRequestMessage(HttpMethod.Delete, $"/api/alunos/{id}");
            if (!string.IsNullOrEmpty(authorization))
                request.Headers.Add("Authorization", authorization);

            var response = await client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            return StatusCode((int)response.StatusCode, content);
        }
    }
}