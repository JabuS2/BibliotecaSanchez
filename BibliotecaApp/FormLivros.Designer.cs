namespace BibliotecaApp
{
    partial class FormLivros
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
            dgvLivros = new DataGridView();
            txtPesquisa = new TextBox();
            btnPesquisar = new Button();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            groupBoxPesquisa = new GroupBox();
            flowLayoutPanelBotoes = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvLivros).BeginInit();
            groupBoxPesquisa.SuspendLayout();
            flowLayoutPanelBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLivros
            // 
            dgvLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLivros.Location = new Point(12, 98);
            dgvLivros.Name = "dgvLivros";
            dgvLivros.Size = new Size(942, 355);
            dgvLivros.TabIndex = 0;
            // 
            // groupBoxPesquisa
            // 
            groupBoxPesquisa.Controls.Add(txtPesquisa);
            groupBoxPesquisa.Controls.Add(btnPesquisar);
            groupBoxPesquisa.Location = new Point(12, 12);
            groupBoxPesquisa.Name = "groupBoxPesquisa";
            groupBoxPesquisa.Size = new Size(942, 80);
            groupBoxPesquisa.TabIndex = 1;
            groupBoxPesquisa.TabStop = false;
            groupBoxPesquisa.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(6, 33);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(817, 23);
            txtPesquisa.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(829, 32);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(100, 25);
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // flowLayoutPanelBotoes
            // 
            flowLayoutPanelBotoes.Controls.Add(btnAdicionar);
            flowLayoutPanelBotoes.Controls.Add(btnEditar);
            flowLayoutPanelBotoes.Controls.Add(btnExcluir);
            flowLayoutPanelBotoes.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBotoes.Location = new Point(12, 459);
            flowLayoutPanelBotoes.Name = "flowLayoutPanelBotoes";
            flowLayoutPanelBotoes.Size = new Size(942, 57);
            flowLayoutPanelBotoes.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(733, 3);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(206, 51);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.BackColor = Color.FromArgb(52, 152, 219); // Cor de fundo azul claro
            btnAdicionar.Click += btnAdicionar_Click;

            btnEditar.Location = new Point(521, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(206, 51);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.BackColor = Color.FromArgb(46, 204, 113); // Cor de fundo verde
            btnEditar.Click += btnEditar_Click;

            btnExcluir.Location = new Point(309, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(206, 51);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.BackColor = Color.FromArgb(231, 76, 60); // Cor de fundo vermelho
            btnExcluir.Click += btnExcluir_Click;

            // FormLivros
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 528);
            Controls.Add(flowLayoutPanelBotoes);
            Controls.Add(groupBoxPesquisa);
            Controls.Add(dgvLivros);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLivros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Livros";
            Load += FormLivros_Load;

            ((System.ComponentModel.ISupportInitialize)dgvLivros).EndInit();
            groupBoxPesquisa.ResumeLayout(false);
            groupBoxPesquisa.PerformLayout();
            flowLayoutPanelBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLivros;
        private TextBox txtPesquisa;
        private Button btnPesquisar;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnExcluir;
        private GroupBox groupBoxPesquisa;
        private FlowLayoutPanel flowLayoutPanelBotoes;
    }
}
