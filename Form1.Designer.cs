namespace CadrastoCSharpComBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomeDaRua = new System.Windows.Forms.TextBox();
            this.textBoxNomecompleto = new System.Windows.Forms.TextBox();
            this.textBoxNumeroDaCasa = new System.Windows.Forms.TextBox();
            this.textBoxDataNascimento = new System.Windows.Forms.TextBox();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewCadastro = new System.Windows.Forms.DataGridView();
            this.textBoxPesquisaDocumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(418, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Cadastrar);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxNomeDaRua);
            this.tabPage1.Controls.Add(this.textBoxNomecompleto);
            this.tabPage1.Controls.Add(this.textBoxNumeroDaCasa);
            this.tabPage1.Controls.Add(this.textBoxDataNascimento);
            this.tabPage1.Controls.Add(this.textBoxDocumento);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(410, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(5, 252);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(398, 162);
            this.Cadastrar.TabIndex = 10;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numero da casa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome da Rua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data de Nascimento";
            // 
            // textBoxNomeDaRua
            // 
            this.textBoxNomeDaRua.Location = new System.Drawing.Point(166, 167);
            this.textBoxNomeDaRua.Name = "textBoxNomeDaRua";
            this.textBoxNomeDaRua.Size = new System.Drawing.Size(230, 23);
            this.textBoxNomeDaRua.TabIndex = 4;
            // 
            // textBoxNomecompleto
            // 
            this.textBoxNomecompleto.Location = new System.Drawing.Point(166, 36);
            this.textBoxNomecompleto.Name = "textBoxNomecompleto";
            this.textBoxNomecompleto.Size = new System.Drawing.Size(230, 23);
            this.textBoxNomecompleto.TabIndex = 3;
            // 
            // textBoxNumeroDaCasa
            // 
            this.textBoxNumeroDaCasa.Location = new System.Drawing.Point(166, 211);
            this.textBoxNumeroDaCasa.Name = "textBoxNumeroDaCasa";
            this.textBoxNumeroDaCasa.Size = new System.Drawing.Size(230, 23);
            this.textBoxNumeroDaCasa.TabIndex = 2;
            // 
            // textBoxDataNascimento
            // 
            this.textBoxDataNascimento.Location = new System.Drawing.Point(166, 126);
            this.textBoxDataNascimento.Name = "textBoxDataNascimento";
            this.textBoxDataNascimento.Size = new System.Drawing.Size(230, 23);
            this.textBoxDataNascimento.TabIndex = 1;
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(166, 83);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(230, 23);
            this.textBoxDocumento.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonExcluir);
            this.tabPage2.Controls.Add(this.buttonPesquisa);
            this.tabPage2.Controls.Add(this.dataGridViewCadastro);
            this.tabPage2.Controls.Add(this.textBoxPesquisaDocumento);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(410, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCadastro
            // 
            this.dataGridViewCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCadastro.Location = new System.Drawing.Point(-4, 123);
            this.dataGridViewCadastro.Name = "dataGridViewCadastro";
            this.dataGridViewCadastro.RowTemplate.Height = 25;
            this.dataGridViewCadastro.Size = new System.Drawing.Size(418, 298);
            this.dataGridViewCadastro.TabIndex = 4;
            // 
            // textBoxPesquisaDocumento
            // 
            this.textBoxPesquisaDocumento.Location = new System.Drawing.Point(88, 17);
            this.textBoxPesquisaDocumento.Name = "textBoxPesquisaDocumento";
            this.textBoxPesquisaDocumento.Size = new System.Drawing.Size(187, 23);
            this.textBoxPesquisaDocumento.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Documento: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.Location = new System.Drawing.Point(5, 58);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(185, 59);
            this.buttonPesquisa.TabIndex = 5;
            this.buttonPesquisa.Text = "Pesquisa";
            this.buttonPesquisa.UseVisualStyleBackColor = true;
            this.buttonPesquisa.Click += new System.EventHandler(this.buttonPesquisa_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(218, 58);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(184, 59);
            this.buttonExcluir.TabIndex = 6;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(437, 489);
            this.MinimumSize = new System.Drawing.Size(437, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button Cadastrar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxNomeDaRua;
        private TextBox textBoxNomecompleto;
        private TextBox textBoxNumeroDaCasa;
        private TextBox textBoxDataNascimento;
        private TextBox textBoxDocumento;
        private TabPage tabPage2;
        private DataGridView dataGridViewCadastro;
        private TextBox textBoxPesquisaDocumento;
        private Label label6;
        private Button buttonExcluir;
        private Button buttonPesquisa;
    }
}