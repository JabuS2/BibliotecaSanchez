using BibliotecaApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaApp
{
    public partial class FormLivros : Form
    {
        private readonly LivroService _livroService;
        private readonly AutorService _autorService;

        public FormLivros(LivroService livroService, AutorService autorService)
        {
            InitializeComponent();
            _livroService = livroService;
            _autorService = autorService;
        }

        public FormLivros()
        {
        }

        private void FormLivros_Load(object sender, EventArgs e)
        {
            CarregarLivros();
        }

        private void CarregarLivros(string pesquisa = null)
        {
            var livros = _livroService.ObterTodos();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                livros = livros.Where(l => l.Titulo.Contains(pesquisa, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            dgvLivros.DataSource = livros;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var pesquisa = txtPesquisa.Text;
            CarregarLivros(pesquisa);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var formLivroDetalhes = new FormLivroDetalhes(_livroService, _autorService);
            formLivroDetalhes.ShowDialog();
            CarregarLivros();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLivros.CurrentRow == null)
            {
                MessageBox.Show("Selecione um livro para editar.");
                return;
            }

            var livroId = (int)dgvLivros.CurrentRow.Cells[0].Value;
            var livro = _livroService.ObterPorId(livroId); // Obtenha o livro pelo ID

            if (livro == null)
            {
                MessageBox.Show("Livro não encontrado.");
                return;
            }

            var formLivroDetalhes = new FormLivroDetalhes(_livroService, _autorService, livro); // Passe o livro recuperado
            formLivroDetalhes.ShowDialog();
            CarregarLivros();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvLivros.CurrentRow == null)
            {
                MessageBox.Show("Selecione um livro para excluir.");
                return;
            }

            var livroId = (int)dgvLivros.CurrentRow.Cells[0].Value;
            _livroService.Deletar(livroId);
            CarregarLivros();
        }
    }
}
