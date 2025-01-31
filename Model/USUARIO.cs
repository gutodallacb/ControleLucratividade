using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoSQLserver.Model
{
	[Table("USUARIO")]
	public class Usuario
	{
		public int UsuarioID { get; set; }
		public string Nome { get; set; }
		public string Senha { get; set; }
	}
}
