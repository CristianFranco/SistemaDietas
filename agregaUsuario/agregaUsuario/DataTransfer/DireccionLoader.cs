using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using agregaUsuario.Model;
namespace agregaUsuario.DataTransfer
{
    public class DireccionLoader : DataLoader<direccion>
    {
        public DireccionLoader() {
            this.selectByIdExpression = x => (y => y.Id == x);
        }
        public direccion editDirection(direccion direcciondb) {
            List<Action<direccion>> exps = new List<Action<direccion>>();
            if (!String.IsNullOrEmpty(direcciondb.CP)) 
                exps.Add(x => x.CP = direcciondb.CP);

            if (!String.IsNullOrEmpty(direcciondb.Direccion1))
                exps.Add(x => x.Direccion1 = direcciondb.Direccion1);

            if (!String.IsNullOrEmpty(direcciondb.Estado))
                exps.Add(x => x.Estado = direcciondb.Estado);

            if (!String.IsNullOrEmpty(direcciondb.Municipio)) 
                exps.Add(x => x.Municipio = direcciondb.Municipio);
            return this.EditElement(direcciondb.Id, exps);
        }

        
    }
}
