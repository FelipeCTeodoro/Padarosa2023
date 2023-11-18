namespace Padarosa2023
{
    partial class MenuProdutos
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.lblCategoriaCadastro = new System.Windows.Forms.Label();
            this.txbCategoriaCadastro = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbPrecoCadastro = new System.Windows.Forms.TextBox();
            this.txbProdutoCadastro = new System.Windows.Forms.TextBox();
            this.lblPrecoCadastro = new System.Windows.Forms.Label();
            this.lblProdutoCadastro = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbProdutoEditar = new System.Windows.Forms.TextBox();
            this.lblCategoriaEditar = new System.Windows.Forms.Label();
            this.txbCategoriaEditar = new System.Windows.Forms.TextBox();
            this.lblProdutoEditar = new System.Windows.Forms.Label();
            this.txbPrecoEditar = new System.Windows.Forms.TextBox();
            this.lblPrecoEditar = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagar = new System.Windows.Forms.Label();
            this.picProdutos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.lblTitle.Location = new System.Drawing.Point(287, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Menu Produtos";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(29, 70);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(931, 334);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.lblCategoriaCadastro);
            this.grbCadastro.Controls.Add(this.txbCategoriaCadastro);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txbPrecoCadastro);
            this.grbCadastro.Controls.Add(this.txbProdutoCadastro);
            this.grbCadastro.Controls.Add(this.lblPrecoCadastro);
            this.grbCadastro.Controls.Add(this.lblProdutoCadastro);
            this.grbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grbCadastro.Location = new System.Drawing.Point(214, 412);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(370, 201);
            this.grbCadastro.TabIndex = 3;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // lblCategoriaCadastro
            // 
            this.lblCategoriaCadastro.AutoSize = true;
            this.lblCategoriaCadastro.Location = new System.Drawing.Point(164, 109);
            this.lblCategoriaCadastro.Name = "lblCategoriaCadastro";
            this.lblCategoriaCadastro.Size = new System.Drawing.Size(82, 20);
            this.lblCategoriaCadastro.TabIndex = 11;
            this.lblCategoriaCadastro.Text = "Categoria:";
            // 
            // txbCategoriaCadastro
            // 
            this.txbCategoriaCadastro.Location = new System.Drawing.Point(252, 103);
            this.txbCategoriaCadastro.Name = "txbCategoriaCadastro";
            this.txbCategoriaCadastro.Size = new System.Drawing.Size(101, 26);
            this.txbCategoriaCadastro.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Location = new System.Drawing.Point(6, 156);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(96, 39);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbPrecoCadastro
            // 
            this.txbPrecoCadastro.Location = new System.Drawing.Point(252, 71);
            this.txbPrecoCadastro.Name = "txbPrecoCadastro";
            this.txbPrecoCadastro.Size = new System.Drawing.Size(101, 26);
            this.txbPrecoCadastro.TabIndex = 8;
            // 
            // txbProdutoCadastro
            // 
            this.txbProdutoCadastro.Location = new System.Drawing.Point(252, 38);
            this.txbProdutoCadastro.Name = "txbProdutoCadastro";
            this.txbProdutoCadastro.Size = new System.Drawing.Size(101, 26);
            this.txbProdutoCadastro.TabIndex = 7;
            // 
            // lblPrecoCadastro
            // 
            this.lblPrecoCadastro.AutoSize = true;
            this.lblPrecoCadastro.Location = new System.Drawing.Point(192, 80);
            this.lblPrecoCadastro.Name = "lblPrecoCadastro";
            this.lblPrecoCadastro.Size = new System.Drawing.Size(54, 20);
            this.lblPrecoCadastro.TabIndex = 5;
            this.lblPrecoCadastro.Text = "Preço:";
            // 
            // lblProdutoCadastro
            // 
            this.lblProdutoCadastro.AutoSize = true;
            this.lblProdutoCadastro.Location = new System.Drawing.Point(177, 47);
            this.lblProdutoCadastro.Name = "lblProdutoCadastro";
            this.lblProdutoCadastro.Size = new System.Drawing.Size(69, 20);
            this.lblProdutoCadastro.TabIndex = 3;
            this.lblProdutoCadastro.Text = "Produto:";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbProdutoEditar);
            this.grbEditar.Controls.Add(this.lblCategoriaEditar);
            this.grbEditar.Controls.Add(this.txbCategoriaEditar);
            this.grbEditar.Controls.Add(this.lblProdutoEditar);
            this.grbEditar.Controls.Add(this.txbPrecoEditar);
            this.grbEditar.Controls.Add(this.lblPrecoEditar);
            this.grbEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grbEditar.Location = new System.Drawing.Point(590, 412);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(370, 201);
            this.grbEditar.TabIndex = 4;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(6, 156);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 39);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbProdutoEditar
            // 
            this.txbProdutoEditar.Location = new System.Drawing.Point(249, 35);
            this.txbProdutoEditar.Name = "txbProdutoEditar";
            this.txbProdutoEditar.Size = new System.Drawing.Size(101, 26);
            this.txbProdutoEditar.TabIndex = 18;
            // 
            // lblCategoriaEditar
            // 
            this.lblCategoriaEditar.AutoSize = true;
            this.lblCategoriaEditar.Location = new System.Drawing.Point(161, 106);
            this.lblCategoriaEditar.Name = "lblCategoriaEditar";
            this.lblCategoriaEditar.Size = new System.Drawing.Size(82, 20);
            this.lblCategoriaEditar.TabIndex = 21;
            this.lblCategoriaEditar.Text = "Categoria:";
            // 
            // txbCategoriaEditar
            // 
            this.txbCategoriaEditar.Location = new System.Drawing.Point(249, 100);
            this.txbCategoriaEditar.Name = "txbCategoriaEditar";
            this.txbCategoriaEditar.Size = new System.Drawing.Size(101, 26);
            this.txbCategoriaEditar.TabIndex = 20;
            // 
            // lblProdutoEditar
            // 
            this.lblProdutoEditar.AutoSize = true;
            this.lblProdutoEditar.Location = new System.Drawing.Point(174, 44);
            this.lblProdutoEditar.Name = "lblProdutoEditar";
            this.lblProdutoEditar.Size = new System.Drawing.Size(69, 20);
            this.lblProdutoEditar.TabIndex = 15;
            this.lblProdutoEditar.Text = "Produto:";
            // 
            // txbPrecoEditar
            // 
            this.txbPrecoEditar.Location = new System.Drawing.Point(249, 68);
            this.txbPrecoEditar.Name = "txbPrecoEditar";
            this.txbPrecoEditar.Size = new System.Drawing.Size(101, 26);
            this.txbPrecoEditar.TabIndex = 19;
            // 
            // lblPrecoEditar
            // 
            this.lblPrecoEditar.AutoSize = true;
            this.lblPrecoEditar.Location = new System.Drawing.Point(189, 77);
            this.lblPrecoEditar.Name = "lblPrecoEditar";
            this.lblPrecoEditar.Size = new System.Drawing.Size(54, 20);
            this.lblPrecoEditar.TabIndex = 16;
            this.lblPrecoEditar.Text = "Preço:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grbApagar.Location = new System.Drawing.Point(385, 620);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(464, 58);
            this.grbApagar.TabIndex = 5;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(364, 17);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 35);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.Location = new System.Drawing.Point(16, 29);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(219, 16);
            this.lblApagar.TabIndex = 1;
            this.lblApagar.Text = "Selecione um produto para apagar.";
            // 
            // picProdutos
            // 
            this.picProdutos.Image = global::Padarosa2023.Properties.Resources.ImagensProdutos;
            this.picProdutos.Location = new System.Drawing.Point(14, 424);
            this.picProdutos.Margin = new System.Windows.Forms.Padding(5);
            this.picProdutos.Name = "picProdutos";
            this.picProdutos.Size = new System.Drawing.Size(177, 254);
            this.picProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProdutos.TabIndex = 6;
            this.picProdutos.TabStop = false;
            // 
            // MenuProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 693);
            this.Controls.Add(this.picProdutos);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblTitle);
            this.Name = "MenuProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.PictureBox picProdutos;
        private System.Windows.Forms.Label lblProdutoCadastro;
        private System.Windows.Forms.Label lblPrecoCadastro;
        private System.Windows.Forms.TextBox txbProdutoCadastro;
        private System.Windows.Forms.TextBox txbPrecoCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox txbCategoriaCadastro;
        private System.Windows.Forms.Label lblCategoriaCadastro;
        private System.Windows.Forms.TextBox txbProdutoEditar;
        private System.Windows.Forms.Label lblCategoriaEditar;
        private System.Windows.Forms.TextBox txbCategoriaEditar;
        private System.Windows.Forms.Label lblProdutoEditar;
        private System.Windows.Forms.TextBox txbPrecoEditar;
        private System.Windows.Forms.Label lblPrecoEditar;
    }
}