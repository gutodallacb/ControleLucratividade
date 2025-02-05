using ProjetoSQLserver.Model;

namespace ControleLucratividadeSQLserver.Controller
{
	public class UsuarioLogin
	{
		public static bool ValidarLogin(string usuario, string senha)
		{
			try
			{
				using (var context = new MeuDbContext())
				{
					// Verifica se o usuário existe
					var usuarioEncontrado = context.Usuarios.FirstOrDefault(u => u.Nome == usuario);

					if (usuarioEncontrado == null)
					{
						MessageBox.Show("Usuário não encontrado!");
						return false;
					}

					// Verifica se a senha está correta
					if (usuarioEncontrado.Senha != senha)
					{
						MessageBox.Show("Senha incorreta!");
						return false;
					}

					// Se passou pelos testes, login bem-sucedido
					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Não foi possível conectar ao banco! Erro: " + ex.Message);
				return false;
			}
		}
	}
}