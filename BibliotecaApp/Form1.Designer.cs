namespace BibliotecaApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnLivros;
        private Button btnAutores;
        private DataGridView dgvLivros;
        private TextBox txtPesquisa;
        private Button btnPesquisar;
        private Label lblPesquisa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnLivros = new Button();
            btnAutores = new Button();
            dgvLivros = new DataGridView();
            txtPesquisa = new TextBox();
            btnPesquisar = new Button();
            lblPesquisa = new Label();
            lblCatalogo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLivros).BeginInit();
            SuspendLayout();
            // 
            // btnLivros
            // 
            btnLivros.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLivros.Location = new Point(30, 30);
            btnLivros.Name = "btnLivros";
            btnLivros.Size = new Size(150, 50);
            btnLivros.TabIndex = 0;
            btnLivros.Text = "Livros";
            btnLivros.UseVisualStyleBackColor = true;
            btnLivros.Click += btnLivros_Click;
            // 
            // btnAutores
            // 
            btnAutores.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAutores.Location = new Point(200, 30);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(150, 50);
            btnAutores.TabIndex = 1;
            btnAutores.Text = "Autores";
            btnAutores.UseVisualStyleBackColor = true;
            btnAutores.Click += btnAutores_Click;
            // 
            // dgvLivros
            // 
            dgvLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLivros.Location = new Point(30, 150);
            dgvLivros.Name = "dgvLivros";
            dgvLivros.RowHeadersWidth = 51;
            dgvLivros.RowTemplate.Height = 29;
            dgvLivros.Size = new Size(740, 300);
            dgvLivros.TabIndex = 2;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(400, 50);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(250, 23);
            txtPesquisa.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Segoe UI", 10F);
            btnPesquisar.Location = new Point(670, 47);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(100, 30);
            btnPesquisar.TabIndex = 4;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Font = new Font("Segoe UI", 10F);
            lblPesquisa.Location = new Point(400, 30);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(69, 19);
            lblPesquisa.TabIndex = 5;
            lblPesquisa.Text = "Pesquisar:";
            // 
            // lblCatalogo
            // 
            lblCatalogo.AutoSize = true;
            lblCatalogo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCatalogo.Location = new Point(30, 117);
            lblCatalogo.Name = "lblCatalogo";
            lblCatalogo.Size = new Size(101, 30);
            lblCatalogo.TabIndex = 6;
            lblCatalogo.Text = "Catálogo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 500);
            Controls.Add(lblCatalogo);
            Controls.Add(lblPesquisa);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisa);
            Controls.Add(dgvLivros);
            Controls.Add(btnAutores);
            Controls.Add(btnLivros);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca - Catálogo";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLivros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCatalogo;
    }
}
