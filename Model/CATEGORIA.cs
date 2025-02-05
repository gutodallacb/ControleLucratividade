using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoSQLserver.Model
{
	[Table("CATEGORIA")]
	public class Categoria
	{
		public string DescricaoCurta { get; set; }
		public string TipoCategoria { get; set; }
		public string DescricaoLonga { get; set; }

		//Construtor:
		public Categoria(string descricaoCurta, string tipoCategoria, string descricaoLonga)
		{
			DescricaoCurta = descricaoCurta;
			TipoCategoria = tipoCategoria;
			DescricaoLonga = descricaoLonga;
		}
	}
}

//CREATE TABLE CATEGORIA (
//	CategoriaId INT PRIMARY KEY IDENTITY(1,1),
//	DescricaoCurta NVARCHAR(100) NOT NULL,
//	TipoCategoria NVARCHAR (20) NOT NULL,
//	DescricaoLonga NVARCHAR (250) NULL
//)