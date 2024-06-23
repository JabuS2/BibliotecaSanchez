using BibliotecaApp.Models;
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
    public partial class FormAutorDetalhes : Form
    {
        private readonly AutorService _autorService;
        private int? _autorId;

        public FormAutorDetalhes(AutorService autorService, int? autorId = null)
        {
            _autorService = autorService;
            _autorId = autorId;
            InitializeComponent();
        }

        private void FormAutorDetalhes_Load(object sender, EventArgs e)
        {
            if (_autorId.HasValue)
            {
                var autor = _autorService.ObterPorId(_autorId.Value);
                if (autor != null)
                {
                    txtNome.Text = autor.Nome;
                    txtDatanascimento.Text = autor.DataNascimento.ToString("dd/MM/yyyy");
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string datanascimentoTexto = txtDatanascimento.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O nome é obrigatório.");
                return;
            }

            if (!DateTime.TryParseExact(datanascimentoTexto, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime datanascimento))
            {
                MessageBox.Show("A data de nascimento deve ser uma data válida no formato DD/MM/YYYY.");
                return;
            }

            datanascimento = DateTime.SpecifyKind(datanascimento, DateTimeKind.Utc);

            if (_autorId.HasValue)
            {
                var autor = _autorService.ObterPorId(_autorId.Value);
                autor.Nome = nome;
                autor.DataNascimento = datanascimento;
                _autorService.Atualizar(autor);
            }
            else
            {
                var autor = new Autor
                {
                    Nome = nome,
                    DataNascimento = datanascimento
                };
                _autorService.Adicionar(autor);
            }

            Close();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

