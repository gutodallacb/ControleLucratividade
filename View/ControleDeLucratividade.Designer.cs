namespace ProjetoSQLserver.View
{
	partial class ControleDeLucratividade
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
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			tabPage2 = new TabPage();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			textBox6 = new TextBox();
			textBox5 = new TextBox();
			textBox4 = new TextBox();
			button1 = new Button();
			Categoria = new Label();
			comboBox1 = new ComboBox();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tabPage2.SuspendLayout();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(688, 12);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(688, 41);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 23);
			textBox2.TabIndex = 2;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(688, 70);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(100, 23);
			textBox3.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(565, 15);
			label1.Name = "label1";
			label1.Size = new Size(117, 15);
			label1.TabIndex = 6;
			label1.Text = "Investimentos Totais:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(614, 44);
			label2.Name = "label2";
			label2.Size = new Size(68, 15);
			label2.TabIndex = 7;
			label2.Text = "Valor Bruto:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(601, 73);
			label3.Name = "label3";
			label3.Size = new Size(83, 15);
			label3.TabIndex = 8;
			label3.Text = "Lucro Líquido:";
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Location = new Point(12, 12);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(537, 117);
			tabControl1.TabIndex = 15;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(label6);
			tabPage1.Controls.Add(label5);
			tabPage1.Controls.Add(label4);
			tabPage1.Controls.Add(textBox6);
			tabPage1.Controls.Add(textBox5);
			tabPage1.Controls.Add(textBox4);
			tabPage1.Controls.Add(button1);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(529, 89);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Categorias";
			tabPage1.UseVisualStyleBackColor = true;
			tabPage1.Click += tabPage1_Click;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(Categoria);
			tabPage2.Controls.Add(comboBox1);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(529, 89);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Investimentos";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(21, 50);
			label6.Name = "label6";
			label6.Size = new Size(94, 15);
			label6.TabIndex = 21;
			label6.Text = "Descrição longa:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(238, 21);
			label5.Name = "label5";
			label5.Size = new Size(33, 15);
			label5.TabIndex = 20;
			label5.Text = "Tipo:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(54, 21);
			label4.Name = "label4";
			label4.Size = new Size(61, 15);
			label4.TabIndex = 19;
			label4.Text = "Descrição:";
			// 
			// textBox6
			// 
			textBox6.Location = new Point(121, 47);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(270, 23);
			textBox6.TabIndex = 18;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(277, 18);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(100, 23);
			textBox5.TabIndex = 17;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(121, 18);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(100, 23);
			textBox4.TabIndex = 16;
			// 
			// button1
			// 
			button1.Location = new Point(409, 46);
			button1.Name = "button1";
			button1.Size = new Size(101, 23);
			button1.TabIndex = 15;
			button1.Text = "Criar categoria";
			button1.UseVisualStyleBackColor = true;
			// 
			// Categoria
			// 
			Categoria.AutoSize = true;
			Categoria.Location = new Point(13, 20);
			Categoria.Name = "Categoria";
			Categoria.Size = new Size(61, 15);
			Categoria.TabIndex = 6;
			Categoria.Text = "Categoria:";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(80, 17);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(121, 23);
			comboBox1.TabIndex = 5;
			// 
			// ControleDeLucratividade
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 138);
			Controls.Add(tabControl1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Name = "ControleDeLucratividade";
			Text = "Controle de Lucratividade";
			Load += ControleDeLucratividade_Load;
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		private void ControleDeLucratividade_Load(object sender, EventArgs e)
		{
			// Este método pode ficar vazio se não houver lógica específica para o carregamento.
		}

		#endregion

		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private Label label1;
		private Label label2;
		private Label label3;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private Label label6;
		private Label label5;
		private Label label4;
		private TextBox textBox6;
		private TextBox textBox5;
		private TextBox textBox4;
		private Button button1;
		private Label Categoria;
		private ComboBox comboBox1;
	}
}