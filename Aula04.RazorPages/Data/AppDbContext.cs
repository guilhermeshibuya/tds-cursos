using Aula04.RazorPages.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula04.RazorPages.Data {
        public class AppDbContext : DbContext
        {
        public DbSet<AlunoModel>? Alunos {get; set;}
        public DbSet<CursoModel>? Cursos {get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=tds.db;Cache=Shared");

       
    
    }

}