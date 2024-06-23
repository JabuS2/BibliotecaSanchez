using BibliotecaApp.Models;
using BibliotecaApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BibliotecaApp
{
    public partial class FormLivroDetalhes : Form
    {
        private readonly LivroService _livroService;
        private readonly AutorService _autorService;
        private Livro _livro;

        public FormLivroDetalhes(LivroService livroService, AutorService autorService, Livro livro = null)
        {
            InitializeComponent();
            _livroService = livroService;
            _autorService = autorService;
            _livro = livro;

            CarregarAutores();
            if (_livro != null)
            {
                txtTitulo.Text = _livro.Titulo;
                txtAnoPublicacao.Text = _livro.AnoPublicacao.ToString();
                // Marcar os autores associados
                foreach (var autorLivro in _livro.AutorLivros)
                {
                    var item = clbAutores.Items.Cast<Autor>().FirstOrDefault(a => a.AutorId == autorLivro.AutorId);
                    if (item != null)
                    {
                        int index = clbAutores.Items.IndexOf(item);
                        clbAutores.SetItemChecked(index, true);
                    }
                }
            }
        }



        private void CarregarAutores()
        {
            var autores = _autorService.ObterTodos();
            clbAutores.DataSource = autores;
            clbAutores.DisplayMember = "Nome";
            clbAutores.ValueMember = "AutorId";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var titulo = txtTitulo.Text;
            var anoPublicacao = int.Parse(txtAnoPublicacao.Text);
            var autorIds = clbAutores.CheckedItems.Cast<Autor>().Select(a => a.AutorId).ToList();

            if (_livro == null)
            {
                var novoLivro = new Livro
                {
                    Titulo = titulo,
                    AnoPublicacao = anoPublicacao,
                };
                _livroService.Adicionar(novoLivro, autorIds);
            }
            else
            {
                _livro.Titulo = titulo;
                _livro.AnoPublicacao = anoPublicacao;
                _livroService.Atualizar(_livro, autorIds);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
