namespace BibliotecaApp
{
    partial class FormLivroDetalhes
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
            label1 = new Label();
            lblTitulo = new Label();
            lblAnoPublicacao = new Label();
            txtTitulo = new TextBox();
            txtAnoPublicacao = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblAutores = new Label();
            clbAutores = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(89, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 32);
            label1.TabIndex = 0;
            label1.Text = "Detalhes do Livro";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 244);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Livro";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(txtTitulo, 1, 0);
            tableLayoutPanel1.Controls.Add(lblAnoPublicacao, 0, 1);
            tableLayoutPanel1.Controls.Add(txtAnoPublicacao, 1, 1);
            tableLayoutPanel1.Controls.Add(lblAutores, 0, 2);
            tableLayoutPanel1.Controls.Add(clbAutores, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3F));
            tableLayoutPanel1.Size = new Size(336, 222);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(49, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título";
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTitulo.Location = new Point(103, 8);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(230, 23);
            txtTitulo.TabIndex = 1;
            // 
            // lblAnoPublicacao
            // 
            lblAnoPublicacao.AutoSize = true;
            lblAnoPublicacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnoPublicacao.Location = new Point(3, 74);
            lblAnoPublicacao.Name = "lblAnoPublicacao";
            lblAnoPublicacao.Size = new Size(137, 21);
            lblAnoPublicacao.TabIndex = 2;
            lblAnoPublicacao.Text = "Ano da Publicação";
            // 
            // txtAnoPublicacao
            // 
            txtAnoPublicacao.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAnoPublicacao.Location = new Point(103, 76);
            txtAnoPublicacao.Name = "txtAnoPublicacao";
            txtAnoPublicacao.Size = new Size(230, 23);
            txtAnoPublicacao.TabIndex = 3;
            // 
            // lblAutores
            // 
            lblAutores.AutoSize = true;
            lblAutores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAutores.Location = new Point(3, 148);
            lblAutores.Name = "lblAutores";
            lblAutores.Size = new Size(64, 21);
            lblAutores.TabIndex = 4;
            lblAutores.Text = "Autores";
            // 
            // clbAutores
            // 
            clbAutores.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            clbAutores.FormattingEnabled = true;
            clbAutores.Location = new Point(103, 151);
            clbAutores.Name = "clbAutores";
            clbAutores.Size = new Size(230, 68);
            clbAutores.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.LightGreen;
            btnSalvar.Location = new Point(12, 314);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 72);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Location = new Point(242, 314);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 72);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormLivroDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 398);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormLivroDetalhes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTitulo;
        private Label lblAnoPublicacao;
        private TextBox txtTitulo;
        private TextBox txtAnoPublicacao;
        private Button btnSalvar;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblAutores;
        private CheckedListBox clbAutores;
    }
}
