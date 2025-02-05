using ControleLucratividadeSQLserver;
using ProjetoSQLserver.Model;

namespace ProjetoSQLserver.Controller
{
	public class CategoriaCreate
	{
		public bool CreateCategoria(string descricaoCurta, string tipoCategoria, string descricaoLonga)
		{
			try
			{
				using (var context = new MeuDbContext())
				{
					//Usa o Lambda para verificar se existe um registro no CATEGORIA com a descrição passada por parâmetro:
					var categoriaExistente = context.Categorias.FirstOrDefault(c => c.DescricaoCurta == descricaoCurta);

					//Se é <> de nullo, quer dizer que existe:
					if (categoriaExistente != null)
					{
						MessageBox.Show($"A categoria {descricaoCurta}");
						return false;
					}
					else
					{
						//Aqui cria uma nova categoria (CATEGORIA.cs) com ajuda do construtor:
						var novaCategoria = new Categoria(descricaoCurta, tipoCategoria, descricaoLonga);

						//Agora aqui vai adicionar ao context e salvar ao banco:
						context.Categorias.Add(novaCategoria);
						int results = context.SaveChanges();

						if (results > 0)
						{
							MessageBox.Show($"A categoria {descricaoCurta} foi criada com sucesso!");
							return true;
						}
						else
						{
							MessageBox.Show($"Falha ao criar a categoria {descricaoCurta}!");
							return false;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro: {ex.Message}");
				throw;
			}
		}
	}
}
