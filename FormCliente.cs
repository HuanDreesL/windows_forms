namespace ControleClientes
{
    public partial class FormCliente : Form
    {
        private ClienteRepository repository = new ClienteRepository();
        Cliente clienteSelecionado;
        public FormCliente()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            gridCliente.Rows.Clear();
            foreach (var cliente in repository.ReadAll())
            {
                gridCliente.Rows.Add(cliente.Id, cliente.Nome, cliente.Email);
            }
        }
        private void Limpar()
        {
            txtNome.Clear();
            txtEmail.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            clienteSelecionado = null;
            tabCliente.SelectTab(tpClienteCadastro);
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (clienteSelecionado == null)
            {
                var cliente = new Cliente
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                };
                repository.Create(cliente);
            }
            else
            {
                clienteSelecionado.Nome = txtNome.Text;
                clienteSelecionado.Email = txtEmail.Text;

                repository.Update(clienteSelecionado);
            }

            LoadData();
            tabCliente.SelectTab(tpClienteConsulta);

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (gridCliente.SelectedRows.Count > 0)
            {
                int id = (int)gridCliente.SelectedRows[0].Cells[0].Value;
                clienteSelecionado = repository.GetById(id);
                txtNome.Text = clienteSelecionado.Nome;
                txtEmail.Text = clienteSelecionado.Email;
            }
            tabCliente.SelectTab(tpClienteCadastro);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            tabCliente.SelectTab(tpClienteCadastro);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (clienteSelecionado != null) 
            {
                if (MessageBox.Show("Deseja realmente excluir o cliente ??", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    repository.ClienteRemove(clienteSelecionado);
                    LoadData();
                    tabCliente.SelectTab(tpClienteConsulta);
                }

            }
        }
    }
}
