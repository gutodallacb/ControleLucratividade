using Microsoft.EntityFrameworkCore;

namespace ProjetoSQLserver.Model
{
	public class MeuDbContext : DbContext
	{
		//Cria variaveis para usar em outras classes:
		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Categoria> Categorias { get; set; }
		public DbSet<Investimento> Investimentos { get; set; }

		// Configura a string de conexão para o banco de dados
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string server = @"GUSTAVO\SQLEXPRESS";        // Nome do servidor
			string dataBase = "ControleLucratividadeDb";  // Nome do banco de dados

			//String de conexão com banco:
			optionsBuilder.UseSqlServer($"Data Source={server};Initial Catalog={dataBase};Integrated Security=True;TrustServerCertificate=True");
		}
	}
}