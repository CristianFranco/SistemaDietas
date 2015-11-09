using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using agregaUsuario.Model;

namespace agregaUsuario.DataTransfer
{
    public class MateriaPrimaLoader : DataLoader<materia_prima>
    {
        public MateriaPrimaLoader() {
            this.selectByIdExpression = x => (y => y.Id == x);
        }

        public void removeMateriaById(int id) {
               this.removeElementById(id);
        }
    }
}
