using ProjetoSQLserver.Model;

namespace ProjetoSQLserver.Controller
{
	public class InvestimentoCreate
	{
		public bool CreateInvestimento(int usuarioId, int categoriaId, decimal valor, DateTime data, string descricao)
		{
			try
			{
				using (var context = new MeuDbContext())
				{
					var novoInvestimento = new Investimento(valor, data, descricao);

					context.Investimentos.Add(novoInvestimento);
					int result = context.SaveChanges();

					if (result > 0)
					{
						MessageBox.Show($"O investimento {descricao} foi criado com sucesso!");
						return true;
					}
					else
					{
						MessageBox.Show($"Falha ao criar o investimento: {descricao}");
						return false;
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
