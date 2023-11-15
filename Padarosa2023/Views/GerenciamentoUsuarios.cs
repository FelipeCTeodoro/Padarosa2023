using EasyEncryption;
using MySqlConnector;
using Padarosa2023.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Padarosa2023.Views
{
    public partial class GerenciamentoUsuarios : Form
    {
        // Atributos globais:
        int idSelecionado = 0;
        public GerenciamentoUsuarios()
        {
            InitializeComponent();
            Classes.Usuario usuario = new Classes.Usuario();

            // Atribuir a tabela (resultado do SELECT) no DGV:
            dgvUsuarios.DataSource = usuario.ListarTudo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Instanciar o usuário:
            Classes.Usuario usuario = new Classes.Usuario();
            // Obter os valores dos campos:
            usuario.NomeCompleto = txbNomeCad.Text;
            usuario.Email = txbEmailCad.Text;
            usuario.Senha = txbSenhaCad.Text;

            if (usuario.Cadastrar() == true)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                // Limpar os campos:
                txbNomeCad.Clear();
                txbEmailCad.Clear();
                txbSenhaCad.Clear();
                // Atualizar o dgv:
                dgvUsuarios.DataSource = usuario.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar usuário!");
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar os grbs:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;

            // obter a linha clicada:
            int linhaSelecionada = dgvUsuarios.CurrentCell.RowIndex;

            // Armazenar os dados da linha seleciona em "linha" (tipo um vetor)
            var linha = dgvUsuarios.Rows[linhaSelecionada];

            // Preencher os campos:
            txbNomeEdi.Text = linha.Cells[1].Value.ToString();
            txbEmailEdi.Text = linha.Cells[2].Value.ToString();

            // Juntar o ID e o nome para exibir no apagar:
            lblApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            // Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id = idSelecionado;


            var r = MessageBox.Show("Tem Certeza que Deseja Remover o Usuário selecionado ?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Apagar:

                if (usuario.Apagar() == true)
                {
                    MessageBox.Show("Usuário removido!", "Susseco!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualizar o dgv:

                    dgvUsuarios.DataSource = usuario.ListarTudo();

                    //Limpar os Campos de Edição:

                    txbEmailEdi.Clear();
                    txbNomeEdi.Clear();
                    txbSenhaEdi.Clear();
                    lblApagar.Text = "Selecione um Usuário para Apagar.";

                    // Desabilitar os grbs:

                    grbApagar.Enabled = false;
                    grbEditar.Enabled = false;
                }
                    else
                    {
                        MessageBox.Show("Falha ao remover usuário!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Obter os Valores dos txbs:
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id = idSelecionado;
            usuario.NomeCompleto = txbNomeEdi.Text;
            usuario.Email = txbEmailEdi.Text;
            usuario.Senha = txbSenhaEdi.Text;

            //Editar

            if(usuario.Modificar()== true)
            {

                MessageBox.Show("Usuário modificado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualizar o dgv:

                dgvUsuarios.DataSource = usuario.ListarTudo();

                //Limpar os Campos de Edição:

                txbEmailEdi.Clear();
                txbNomeEdi.Clear();
                txbSenhaEdi.Clear();
                lblApagar.Text = "Selecione um Usuário para Apagar.";

                // Desabilitar os grbs:

                grbApagar.Enabled = false;
                grbEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Falha ao Modificar usuário!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            }
        }
    }
    


