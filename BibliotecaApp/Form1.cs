using BibliotecaApp.Models;
using BibliotecaApp.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace BibliotecaApp
{
    public partial class Form1 : Form
    {
        private readonly LivroService _livroService;
        private readonly AutorService _autorService;

        public Form1(LivroService livroService, AutorService autorService)
        {
            InitializeComponent();
            _livroService = livroService;
            _autorService = autorService;
        }

        private void CarregarLivros(string pesquisa = null)
        {
            var livros = _livroService.ObterTodosComAutores();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                livros = livros.Where(l => l.Titulo.Contains(pesquisa, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            dgvLivros.DataSource = livros.Select(l => new
            {
                l.Titulo,
                l.AnoPublicacao,
                Autores = string.Join(", ", l.AutorLivros.Select(al => al.Autor.Nome))
            }).ToList();
        }


        private void btnLivros_Click(object sender, EventArgs e)
        {
            FormLivros formLivros = new FormLivros(_livroService, _autorService);
            formLivros.Show();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            FormAutores formAutores = new FormAutores(_autorService);
            formAutores.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarLivros();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var pesquisa = txtPesquisa.Text;
            CarregarLivros(pesquisa);
        }

    }
}
