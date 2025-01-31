namespace ProjetoSQLserver.View
{
	partial class Login
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
			EntrarButton = new Button();
			CriarUsuarioButton = new Button();
			label1 = new Label();
			label2 = new Label();
			UsuarioTextBox = new TextBox();
			SenhaTextBox = new TextBox();
			SuspendLayout();
			// 
			// EntrarButton
			// 
			EntrarButton.Location = new Point(70, 87);
			EntrarButton.Name = "EntrarButton";
			EntrarButton.Size = new Size(147, 23);
			EntrarButton.TabIndex = 0;
			EntrarButton.Text = "Entrar";
			EntrarButton.UseVisualStyleBackColor = true;
			EntrarButton.Click += button1_Click;
			// 
			// CriarUsuarioButton
			// 
			CriarUsuarioButton.Location = new Point(70, 111);
			CriarUsuarioButton.Name = "CriarUsuarioButton";
			CriarUsuarioButton.Size = new Size(147, 23);
			CriarUsuarioButton.TabIndex = 1;
			CriarUsuarioButton.Text = "Criar usuário";
			CriarUsuarioButton.UseVisualStyleBackColor = true;
			CriarUsuarioButton.Click += CriarUsuarioButton_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(19, 24);
			label1.Name = "label1";
			label1.Size = new Size(50, 15);
			label1.TabIndex = 2;
			label1.Text = "Usuário:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(27, 52);
			label2.Name = "label2";
			label2.Size = new Size(42, 15);
			label2.TabIndex = 3;
			label2.Text = "Senha:";
			// 
			// UsuarioTextBox
			// 
			UsuarioTextBox.Location = new Point(70, 21);
			UsuarioTextBox.Name = "UsuarioTextBox";
			UsuarioTextBox.Size = new Size(147, 23);
			UsuarioTextBox.TabIndex = 4;
			UsuarioTextBox.TextChanged += UsuarioTextBox_TextChanged;
			// 
			// SenhaTextBox
			// 
			SenhaTextBox.Location = new Point(70, 49);
			SenhaTextBox.Name = "SenhaTextBox";
			SenhaTextBox.Size = new Size(147, 23);
			SenhaTextBox.TabIndex = 5;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(255, 147);
			Controls.Add(SenhaTextBox);
			Controls.Add(UsuarioTextBox);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(CriarUsuarioButton);
			Controls.Add(EntrarButton);
			Name = "Login";
			Text = "Login";
			Load += Login_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button EntrarButton;
		private Button CriarUsuarioButton;
		private Label label1;
		private Label label2;
		private TextBox UsuarioTextBox;
		private TextBox SenhaTextBox;
	}
}