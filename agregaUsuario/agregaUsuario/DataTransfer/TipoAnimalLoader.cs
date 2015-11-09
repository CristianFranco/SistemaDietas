using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using agregaUsuario.Model;

namespace agregaUsuario.DataTransfer
{
    public class TipoAnimalLoader : DataLoader<tipo_animal>
    {
        public TipoAnimalLoader() {
            this.selectByIdExpression = x => (y => y.Id == x);
        }

        public void removeTipoAnimalById(int id) {
        }
    }
}
