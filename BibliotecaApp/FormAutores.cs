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
    public partial class FormAutores : Form
    {
        private readonly AutorService _autorService;
        public FormAutores(AutorService autorService)
        {
            InitializeComponent();
            _autorService = autorService;
        }

        private void FormAutores_Load(object sender, EventArgs e)
        {
            CarregarAutores();
        }

        private void CarregarAutores(string pesquisa = null)
        {
            var autor = _autorService.ObterTodos();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                autor = autor.Where(l => l.Nome.Contains(pesquisa, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            dgvAutores.DataSource = autor;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var pesquisa = txtPesquisa.Text;
            CarregarAutores(pesquisa);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var formautordetalhes = new FormAutorDetalhes(_autorService);
            formautordetalhes.ShowDialog();
            CarregarAutores();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAutores.CurrentRow == null)
            {
                MessageBox.Show("Selecione um livro para editar.");
                return;
            }

            var autorId = (int)dgvAutores.CurrentRow.Cells[0].Value;
            var formautordetalhes = new FormAutorDetalhes(_autorService, autorId);
            formautordetalhes.ShowDialog();
            CarregarAutores();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvAutores.CurrentRow == null)
            {
                MessageBox.Show("Selecione um livro para excluir.");
                return;
            }

            var livroId = (int)dgvAutores.CurrentRow.Cells[0].Value;
            _autorService.Deletar(livroId);
            CarregarAutores();
        }
    }
}
