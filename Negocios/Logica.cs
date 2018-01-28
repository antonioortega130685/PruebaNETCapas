using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocios
{
    public class Logica
    {

        private ClienteManager cmanager;
        private ClienteManager CManager
        {
            get
            {
                return cmanager ?? (cmanager = new ClienteManager());
            }
        }
        

        //listado
        public List<Cliente> GetCliente()
        {
            return CManager.GetCliente();
        }


        //crear
        public void InsertCliente(Cliente cliente)
        {
            CManager.InsertCliente(cliente);
        }


        //Conseguir cliente
        public Cliente ConseguirCliente(int id)
        {
            return CManager.ConseguirCliente(id);
            
            
        }


        //editar
        public void EditCliente(Cliente cliente)
        {
            CManager.EditCliente(cliente);
        }


        //borrar
        public void DeleteCliente(int id)
        {
            CManager.DeleteCliente(id);
        }

        
    }
}
