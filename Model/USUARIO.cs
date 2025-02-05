using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoSQLserver.Model
{
	[Table("USUARIO")]
	public class Usuario
	{
		public int UsuarioID { get; set; }
		public string Nome { get; set; }
		public string Senha { get; set; }

		//Construtor (Deve estar dentro da classe
		public Usuario(string nome, string senha)
		{
			Nome = nome;
			Senha = senha;
		}
	}
}

//CREATE TABLE USUARIO (
//	UsuarioId INT PRIMARY KEY IDENTITY(1,1),
//	Nome NVARCHAR(200) NOT NULL
//  Senha NVARCHAR(200) NOT NULL
//);
