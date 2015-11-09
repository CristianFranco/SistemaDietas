using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using agregaUsuario.Model;

namespace agregaUsuario.DataTransfer
{
    public class NecesidadFisiologicaLoader : DataLoader<necesidad_fisiologica>
    {
        public NecesidadFisiologicaLoader() {
            this.selectByIdExpression = x => (y => y.Id == x);
        }

        public void removeNecesidadById(int id) {
            this.removeElementById(id);
        }
    }
}
