namespace ControleClientes
{
    partial class FormCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabCliente = new TabControl();
            tpClienteConsulta = new TabPage();
            gridCliente = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            pnlPesquisa = new Panel();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            pnlAcao = new Panel();
            btnVisualizar = new Button();
            btnNovo = new Button();
            tpClienteCadastro = new TabPage();
            txtEmail = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            pnlAcaoCadastro = new Panel();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            tabCliente.SuspendLayout();
            tpClienteConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCliente).BeginInit();
            pnlPesquisa.SuspendLayout();
            pnlAcao.SuspendLayout();
            tpClienteCadastro.SuspendLayout();
            pnlAcaoCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabCliente
            // 
            tabCliente.Controls.Add(tpClienteConsulta);
            tabCliente.Controls.Add(tpClienteCadastro);
            tabCliente.Dock = DockStyle.Fill;
            tabCliente.Location = new Point(0, 0);
            tabCliente.Name = "tabCliente";
            tabCliente.SelectedIndex = 0;
            tabCliente.Size = new Size(789, 381);
            tabCliente.TabIndex = 0;
            // 
            // tpClienteConsulta
            // 
            tpClienteConsulta.Controls.Add(gridCliente);
            tpClienteConsulta.Controls.Add(pnlPesquisa);
            tpClienteConsulta.Controls.Add(pnlAcao);
            tpClienteConsulta.Location = new Point(4, 24);
            tpClienteConsulta.Name = "tpClienteConsulta";
            tpClienteConsulta.Padding = new Padding(3);
            tpClienteConsulta.Size = new Size(781, 353);
            tpClienteConsulta.TabIndex = 0;
            tpClienteConsulta.Text = "Consulta";
            tpClienteConsulta.UseVisualStyleBackColor = true;
            // 
            // gridCliente
            // 
            gridCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCliente.Columns.AddRange(new DataGridViewColumn[] { colId, colNome, colEmail });
            gridCliente.Dock = DockStyle.Fill;
            gridCliente.Location = new Point(3, 34);
            gridCliente.Name = "gridCliente";
            gridCliente.RowHeadersWidth = 20;
            gridCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCliente.Size = new Size(775, 285);
            gridCliente.TabIndex = 4;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            // 
            // colEmail
            // 
            colEmail.HeaderText = "E-mail";
            colEmail.Name = "colEmail";
            // 
            // pnlPesquisa
            // 
            pnlPesquisa.Controls.Add(btnPesquisar);
            pnlPesquisa.Controls.Add(txtPesquisa);
            pnlPesquisa.Dock = DockStyle.Top;
            pnlPesquisa.Location = new Point(3, 3);
            pnlPesquisa.Name = "pnlPesquisa";
            pnlPesquisa.Size = new Size(775, 31);
            pnlPesquisa.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(659, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(113, 23);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(0, 3);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar por nome";
            txtPesquisa.Size = new Size(653, 23);
            txtPesquisa.TabIndex = 2;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // pnlAcao
            // 
            pnlAcao.Controls.Add(btnVisualizar);
            pnlAcao.Controls.Add(btnNovo);
            pnlAcao.Dock = DockStyle.Bottom;
            pnlAcao.Location = new Point(3, 319);
            pnlAcao.Name = "pnlAcao";
            pnlAcao.Size = new Size(775, 31);
            pnlAcao.TabIndex = 2;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Location = new Point(614, 5);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(75, 23);
            btnVisualizar.TabIndex = 0;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(695, 5);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // tpClienteCadastro
            // 
            tpClienteCadastro.Controls.Add(txtEmail);
            tpClienteCadastro.Controls.Add(label2);
            tpClienteCadastro.Controls.Add(txtNome);
            tpClienteCadastro.Controls.Add(label1);
            tpClienteCadastro.Controls.Add(pnlAcaoCadastro);
            tpClienteCadastro.Location = new Point(4, 24);
            tpClienteCadastro.Name = "tpClienteCadastro";
            tpClienteCadastro.Padding = new Padding(3);
            tpClienteCadastro.Size = new Size(781, 353);
            tpClienteCadastro.TabIndex = 1;
            tpClienteCadastro.Text = "Cadastro";
            tpClienteCadastro.UseVisualStyleBackColor = true;
            tpClienteCadastro.Click += tpClienteCadastro_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(21, 97);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(337, 23);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 79);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "E-mail";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(21, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(337, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // pnlAcaoCadastro
            // 
            pnlAcaoCadastro.Controls.Add(btnExcluir);
            pnlAcaoCadastro.Controls.Add(btnCancelar);
            pnlAcaoCadastro.Controls.Add(btnSalvar);
            pnlAcaoCadastro.Dock = DockStyle.Bottom;
            pnlAcaoCadastro.Location = new Point(3, 322);
            pnlAcaoCadastro.Name = "pnlAcaoCadastro";
            pnlAcaoCadastro.Size = new Size(775, 28);
            pnlAcaoCadastro.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(695, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(614, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.ForeColor = Color.Red;
            btnExcluir.Location = new Point(3, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 381);
            Controls.Add(tabCliente);
            Name = "FormCliente";
            Text = "Cadastro de Clientes";
            Load += FormCliente_Load;
            tabCliente.ResumeLayout(false);
            tpClienteConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCliente).EndInit();
            pnlPesquisa.ResumeLayout(false);
            pnlPesquisa.PerformLayout();
            pnlAcao.ResumeLayout(false);
            tpClienteCadastro.ResumeLayout(false);
            tpClienteCadastro.PerformLayout();
            pnlAcaoCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabCliente;
        private TabPage tpClienteConsulta;
        private TabPage tpClienteCadastro;
        private Panel pnlAcao;
        private Button btnVisualizar;
        private Button btnNovo;
        private Panel pnlPesquisa;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private DataGridView gridCliente;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colEmail;
        private Panel pnlAcaoCadastro;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private Button btnExcluir;
    }
}
