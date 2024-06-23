namespace BibliotecaApp
{
    partial class FormAutorDetalhes
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblNome = new Label();
            lblAnoPublicacao = new Label();
            txtNome = new TextBox();
            txtDatanascimento = new MaskedTextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
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
            label1.Text = "Detalhes do Autor";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 244);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Autor";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(lblNome, 0, 0);
            tableLayoutPanel1.Controls.Add(txtNome, 1, 0);
            tableLayoutPanel1.Controls.Add(lblAnoPublicacao, 0, 1);
            tableLayoutPanel1.Controls.Add(txtDatanascimento, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(336, 222);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(3, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(103, 8);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(230, 23);
            txtNome.TabIndex = 1;
            // 
            // lblAnoPublicacao
            // 
            lblAnoPublicacao.AutoSize = true;
            lblAnoPublicacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnoPublicacao.Location = new Point(3, 111);
            lblAnoPublicacao.Name = "lblAnoPublicacao";
            lblAnoPublicacao.Size = new Size(150, 21);
            lblAnoPublicacao.TabIndex = 2;
            lblAnoPublicacao.Text = "Data de Nascimento";
            // 
            // txtDatanascimento
            // 
            txtDatanascimento.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDatanascimento.Location = new Point(103, 119);
            txtDatanascimento.Mask = "00/00/0000";
            txtDatanascimento.Name = "txtDatanascimento";
            txtDatanascimento.Size = new Size(230, 23);
            txtDatanascimento.TabIndex = 3;
            txtDatanascimento.ValidatingType = typeof(System.DateTime);
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
            // FormAutorDetalhes
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
            Name = "FormAutorDetalhes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhes";
            Load += FormAutorDetalhes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNome;
        private Label lblAnoPublicacao;
        private TextBox txtNome;
        private MaskedTextBox txtDatanascimento;
        private Button btnSalvar;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
