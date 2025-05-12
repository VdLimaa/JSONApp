using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Net.Http;
using JSON.Model;
using JSON.Controller;

namespace JSON
{
    public partial class Form1 : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public Form1()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            usuarios = UsuarioController.Carregar();
            dgv_json.DataSource = null;
            dgv_json.DataSource = usuarios;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            var novo = new Usuario
            {
                Nome = txt_nome.Text,
                Email = txt_email.Text,
                Idade = int.TryParse(txt_idade.Text, out int idade) ? idade : 0
            };

            UsuarioController.Adicionar(novo);
            CarregarDados();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (dgv_json.CurrentRow != null)
            {
                var usuario = (Usuario)dgv_json.CurrentRow.DataBoundItem;

                usuario.Nome = txt_nome.Text;
                usuario.Email = txt_email.Text;
                usuario.Idade = int.TryParse(txt_idade.Text, out int idade) ? idade : 0;

                UsuarioController.Atualizar(usuario);
                CarregarDados();
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (dgv_json.CurrentRow != null)
            {
                var usuario = (Usuario)dgv_json.CurrentRow.DataBoundItem;
                UsuarioController.Excluir(usuario.ID);
                CarregarDados();
            }
        }

        private async void btn_obter_Click(object sender, EventArgs e)
        {
            string url = "https://fakestoreapi.com/users";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);

                    using (JsonDocument doc = JsonDocument.Parse(json))
                    {
                        var lista = new List<UsuarioAPI>();

                        foreach (JsonElement item in doc.RootElement.EnumerateArray())
                        {
                            var usuario = new UsuarioAPI
                            {
                                username = item.GetProperty("username").GetString(),
                                email = item.GetProperty("email").GetString(),
                                password = item.GetProperty("password").GetString()
                            };
                            lista.Add(usuario);
                        }

                        dgv_json.DataSource = lista;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar API: " + ex.Message);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_json.CurrentRow?.DataBoundItem is Usuario usuario)
            {
                txt_nome.Text = usuario.Nome;
                txt_email.Text = usuario.Email;
                txt_idade.Text = usuario.Idade.ToString();
            }
        }

        private void dgv_json_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
