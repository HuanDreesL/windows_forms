using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes
{
    public class ClienteRepository
    {
        private List<Cliente> clientes = new List<Cliente>();
        private int nextId = 1;

        public List<Cliente> ReadAll() => clientes;

        public void Create(Cliente cliente)
        {
            cliente.Id = nextId;
            clientes.Add(cliente);
            nextId++;
        }

        public Cliente GetById(int id) => clientes.FirstOrDefault(c => c.Id == id);

        public void Update(Cliente cliente) 
        {
            Cliente clienteExist = GetById(cliente.Id);
            if (clienteExist != null) 
            {
                clienteExist.Nome = cliente.Nome;
                clienteExist.Email = cliente.Email;

                

            }
        }

        public void ClienteRemove(Cliente cliente) 
        {
            Cliente clienteExist = GetById(cliente.Id);

            if (clienteExist != null) 
            {
                clientes.Remove(clienteExist);
            }
        }
    }
}
