using Microsoft.EntityFrameworkCore;

namespace FilmesCRUDRazor.Models
{
   // Aqui vai gerar uma tabela de acordo com as propriedades da classe Filme
   public class FilmeContext: DbContext
   {
      public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
      {
         // Default
      }

      public DbSet<Filme> Filme {get; set;}
   }
}