using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
using System.Data.Entity;

namespace Datos
{
    public class ClienteManager
    {

        ClienteDB db = new ClienteDB();

        //para conseguir listado de clientes
        public List<Cliente> GetCliente()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (var db = new Datos.ClienteDB())
            {
                clientes = db.Clientes.ToList();
            }
            return clientes;
        }


        //crear cliente
        public void InsertCliente(Cliente cliente)
        {
            db.Clientes.Add(cliente);
            db.SaveChanges();
        }


        //conseguir cliente para editar
        public Cliente ConseguirCliente(int id)
        {
            Cliente cliente = db.Clientes.Find(id);
            return cliente;
        }

        //editar cliente
        public void EditCliente(Cliente cliente)
        {
            
            db.Entry(cliente).State = EntityState.Modified;
            db.SaveChanges();
        }

        //eliminar cliente
        public void DeleteCliente(int id)
        {
            Cliente ejemplar = db.Clientes.Find(id);
            db.Clientes.Remove(ejemplar);
            db.SaveChanges();
        }
    }
}
