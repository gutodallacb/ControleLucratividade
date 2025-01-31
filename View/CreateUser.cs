using ProjetoSQLserver.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoSQLserver.View
{
	public partial class CreateUser : Form
	{
		public CreateUser()
		{
			InitializeComponent();
			SenhaTextBox.PasswordChar = '*';
			Senha2TextBox.PasswordChar = '*';
		}
		private void CreateUser_Load(object sender, EventArgs e)
		{
			// Aqui você pode inicializar componentes ou carregar dados se necessário
		}


		private void CadastrarButton_Click(object sender, EventArgs e)
		{
			string usuario = UsuarioTextBox.Text;
			string senha = SenhaTextBox.Text;
			string senha2 = Senha2TextBox.Text;

			if (senha != senha2)
			{
				MessageBox.Show("Senhas não colidem!");
			}
			else
			{
				UserCreation criaUsuario = new UserCreation();

				bool criouUsuario = criaUsuario.CreateUser(usuario, senha);

				if (criouUsuario)
				{
					Login login = new Login();

					login.Show();
					this.Hide();
				}
			}
		}
	}
}
