using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using agregaUsuario.Model;

namespace agregaUsuario.DataTransfer
{
    public class ClienteLoader : DataLoader<cliente>
    {
        public ClienteLoader() {
            this.selectByIdExpression = x => (y => y.Id == x);
        }
        public cliente editCliente(cliente clientedb) {
            List<Action<cliente>> exps = new List<Action<cliente>>();
            if (!String.IsNullOrEmpty(clientedb.Celular))
                exps.Add(x => x.Celular = clientedb.Celular);
            if (!String.IsNullOrEmpty(clientedb.Telefono))
                exps.Add(x => x.Telefono = clientedb.Telefono);
            if (!String.IsNullOrEmpty(clientedb.Nombre))
                exps.Add(x => x.Nombre = clientedb.Nombre);
            return this.EditElement(clientedb.Id, exps);
        }

        public void removeClienteById(int id) {
            cliente clienteDb = this.GetElementById(id, new List<string> { "materia_prima" });
            DireccionLoader dirLoader = new DireccionLoader();
            dirLoader.removeElementById(clienteDb.IdDireccion);
            //foreach(var materia)
        }
    }
}
