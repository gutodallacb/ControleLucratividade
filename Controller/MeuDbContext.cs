using Microsoft.EntityFrameworkCore;
using ProjetoSQLserver.Model;

namespace ControleLucratividadeSQLserver
{
	public class MeuDbContext : DbContext
	{
		public DbSet<Usuario> Usuarios { get; set; }

		// Configura a string de conexão para o banco de dados
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string server = @"GUSTAVO\SQLEXPRESS";		  // Nome do servidor
			string dataBase = "ControleLucratividadeDb";  // Nome do banco de dados

			//String de conexão com banco:
			optionsBuilder.UseSqlServer($"Data Source={server};Initial Catalog={dataBase};Integrated Security=True;TrustServerCertificate=True");
		}
	}
}