using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoSQLserver.Model
{
	[Table("INVESTIMENTO")]
	public class Investimento
	{
		public decimal Valor { get; set; }
		public DateTime DataInvestimento { get; set; }
		public string Descricao { get; set; }

		//Construtor:
		public Investimento(decimal valor, DateTime data, string descricao)
		{
			Valor = valor;
			DataInvestimento = data;
			Descricao = descricao;
		}
	}
}


//CREATE TABLE INVESTIMENTO (
//	InvestimentoId INT PRIMARY KEY IDENTITY(1,1),
//	UsuarioId int FOREIGN KEY REFERENCES USUARIO(UsuarioId),
//	CategoriaId int FOREIGN KEY REFERENCES CATEGORIA(CategoriaId),
//	Valor DECIMAL (12,2) NOT NULL,
//	DataInvestimento DATETIME NOT NULL,
//	Descricao NVARCHAR(200) NULL
//);
