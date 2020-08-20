using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public bool Add(String nome, String cpf)
        {
            Cliente c = new Cliente();
            c.Nome = nome;
            c.Cpf = cpf;
            ClienteDao dao = new ClienteDao();
            dao.Add(c);
            return true;
        }

        public Cliente Buscar(string nome)
        {
            ClienteDao dao = new ClienteDao();
            return  dao.Buscar(nome);
            
        }

        public List<Cliente> GetClientes()
        {
            return ClienteDao.clientes;
        }
    }
}
