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

namespace Padarosa2023
{
    public partial class MenuProdutos : Form

    {
        int idSelecionado = 0;
        Classes.Usuario usuario = new Classes.Usuario();
        public MenuProdutos(Classes.Usuario usuario)
        {
            InitializeComponent();
            Classes.Produto produto = new Classes.Produto();
            // Atribuir a tabela (resultado do SELECT) no DGV:
            dgvProdutos.DataSource = produto.ListarTudo();
            this.usuario = usuario;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Instanciar o Produto:
            Classes.Produto produto = new Classes.Produto();
            // Obter os valores dos campos:
            produto.Nome = txbProdutoCadastro.Text;
            produto.Preco = double.Parse (txbPrecoCadastro.Text);
            produto.IdCategoria = int.Parse(txbCategoriaCadastro.Text);
            produto.IdRespCadastro = usuario.Id;

            if (produto.Cadastrar() == true)
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
                // Limpar os campos:
                txbProdutoCadastro.Clear();
                txbPrecoCadastro.Clear();
                txbCategoriaCadastro.Clear();
                // Atualizar o dgv:
                dgvProdutos.DataSource = produto.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar Produto!");
            }

        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar os grbs:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;

            // obter a linha clicada:
            int linhaSelecionada = dgvProdutos.CurrentCell.RowIndex;

            // Armazenar os dados da linha seleciona em "linha" (tipo um vetor)
            var linha = dgvProdutos.Rows[linhaSelecionada];

            // Preencher os campos:
            txbProdutoEditar.Text = linha.Cells[1].Value.ToString();
            txbPrecoEditar.Text = linha.Cells[2].Value.ToString();
            lblApagar.Text = linha.Cells[3].Value.ToString();

            // Juntar o ID e o nome para exibir no apagar:
            lblApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            // Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();
            produto.Id = idSelecionado;


            var r = MessageBox.Show("Tem Certeza que Deseja Remover o Produto selecionado ?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Apagar:

                if (produto.Apagar() == true)
                {
                    MessageBox.Show("Produto removido!", "Susseco!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualizar o dgv:

                    dgvProdutos.DataSource = produto.ListarTudo();

                    //Limpar os Campos de Edição:

                    txbProdutoEditar.Clear();
                    txbPrecoEditar.Clear();
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
            Classes.Produto produto = new Classes.Produto();
            produto.Id = idSelecionado;
            produto.Nome = txbProdutoEditar.Text;
            produto.Preco = double.Parse(txbPrecoEditar.Text);
            produto.IdCategoria = int.Parse(txbCategoriaEditar.Text);

            //Editar

            if (produto.Modificar() == true)
            {

                MessageBox.Show("Produto modificado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualizar o dgv:

               dgvProdutos.DataSource = produto.ListarTudo();

                //Limpar os Campos de Edição:

                txbProdutoEditar.Clear();
                txbPrecoEditar.Clear();
                txbCategoriaEditar.Clear();
                lblApagar.Text = "Selecione um Produto para Apagar.";

                // Desabilitar os grbs:

                grbApagar.Enabled = false;
                grbEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Falha ao Modificar Produto!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
