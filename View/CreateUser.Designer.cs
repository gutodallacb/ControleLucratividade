namespace ProjetoSQLserver.View
{
	partial class CreateUser
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			VoltarButton = new Button();
			CadastrarButton = new Button();
			UsuarioTextBox = new TextBox();
			SenhaTextBox = new TextBox();
			Senha2TextBox = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			SuspendLayout();
			// 
			// VoltarButton
			// 
			VoltarButton.Location = new Point(123, 99);
			VoltarButton.Name = "VoltarButton";
			VoltarButton.Size = new Size(92, 23);
			VoltarButton.TabIndex = 0;
			VoltarButton.Text = "Voltar";
			VoltarButton.UseVisualStyleBackColor = true;
			// 
			// CadastrarButton
			// 
			CadastrarButton.Location = new Point(221, 99);
			CadastrarButton.Name = "CadastrarButton";
			CadastrarButton.Size = new Size(95, 23);
			CadastrarButton.TabIndex = 1;
			CadastrarButton.Text = "Cadastrar";
			CadastrarButton.UseVisualStyleBackColor = true;
			CadastrarButton.Click += CadastrarButton_Click;
			// 
			// UsuarioTextBox
			// 
			UsuarioTextBox.Location = new Point(143, 12);
			UsuarioTextBox.Name = "UsuarioTextBox";
			UsuarioTextBox.Size = new Size(173, 23);
			UsuarioTextBox.TabIndex = 2;
			// 
			// SenhaTextBox
			// 
			SenhaTextBox.Location = new Point(143, 41);
			SenhaTextBox.Name = "SenhaTextBox";
			SenhaTextBox.Size = new Size(173, 23);
			SenhaTextBox.TabIndex = 3;
			// 
			// Senha2TextBox
			// 
			Senha2TextBox.Location = new Point(143, 70);
			Senha2TextBox.Name = "Senha2TextBox";
			Senha2TextBox.Size = new Size(173, 23);
			Senha2TextBox.TabIndex = 4;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(87, 15);
			label1.Name = "label1";
			label1.Size = new Size(50, 15);
			label1.TabIndex = 5;
			label1.Text = "Usuário:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(95, 44);
			label2.Name = "label2";
			label2.Size = new Size(42, 15);
			label2.TabIndex = 6;
			label2.Text = "Senha:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(60, 73);
			label3.Name = "label3";
			label3.Size = new Size(77, 15);
			label3.TabIndex = 7;
			label3.Text = "Repita senha:";
			// 
			// CreateUser
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(323, 129);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(Senha2TextBox);
			Controls.Add(SenhaTextBox);
			Controls.Add(UsuarioTextBox);
			Controls.Add(CadastrarButton);
			Controls.Add(VoltarButton);
			MaximumSize = new Size(339, 168);
			MinimumSize = new Size(339, 168);
			Name = "CreateUser";
			Text = "Criação de novo usuário";
			Load += this.CreateUser_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button VoltarButton;
		private Button CadastrarButton;
		private TextBox UsuarioTextBox;
		private TextBox SenhaTextBox;
		private TextBox Senha2TextBox;
		private Label label1;
		private Label label2;
		private Label label3;
	}
}