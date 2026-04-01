using Microsoft.EntityFrameworkCore;
using GestaoAlunos_Daniel_Joao.Models;

namespace GestaoAlunos_Daniel_Joao.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }
    }
}
