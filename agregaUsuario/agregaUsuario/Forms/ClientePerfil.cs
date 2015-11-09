using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using agregaUsuario.Model;
using agregaUsuario.DataTransfer;
namespace agregaUsuario.Forms
{
    public partial class ClientePerfil : Form
    {
        private ClienteLoader clienteLoader = new ClienteLoader();
        private DireccionLoader direccionLoader = new DireccionLoader();
        private cliente principalCliente;
        private Principal principalView;
        public ClientePerfil()
        {
            InitializeComponent();
            this.hidePanels(true);
        }

        public void setFatherView(Principal principal) {
            this.principalView = principal;
        }
        public void setDataClient(cliente clienteLocal) {
            this.principalCliente = clienteLocal;
            this.NombreLabel.Text = clienteLocal.Nombre;
            this.telefonoLabel.Text = clienteLocal.Telefono;
            this.celularLabel.Text = clienteLocal.Celular;
            this.DireccionLabel.Text = clienteLocal.direccion.Direccion1;
            this.MunicipioLabel.Text = clienteLocal.direccion.Municipio;
            this.EstadoLabel.Text = clienteLocal.direccion.Estado;
            this.CPLabel.Text = clienteLocal.direccion.CP;
        }

        private void setDataForEdit(cliente clienteLocal) {
            this.nombreTextBox.Text = clienteLocal.Nombre;
            this.telefonoTextBox.Text = clienteLocal.Telefono;
            this.CelularTextBox.Text = clienteLocal.Celular;
            this.direccionTextBox.Text = clienteLocal.direccion.Direccion1;
            this.municipioTextBox.Text = clienteLocal.direccion.Municipio;
            this.estadoTextBox.Text = clienteLocal.direccion.Estado;
            this.CPTextBox.Text = clienteLocal.direccion.CP;
        }

        private void headerDireccionLabel_Click(object sender, EventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.setDataForEdit(principalCliente);
            this.hidePanels(false);
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.hidePanels(true);
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            bool isCorrect = true;
            long n;
            if (long.TryParse(this.CelularTextBox.Text, out n) && this.CelularTextBox.Text.Length == 10)
            {
            }
            else
            {
                isCorrect = false;
                str.Append("El numero de celular es incorrecto\n");
            }
            if (long.TryParse(this.telefonoTextBox.Text, out n) && this.telefonoTextBox.Text.Length == 10)
            {
            }
            else
            {
                isCorrect = false;
                str.Append("El numero de Telefono es incorrecto\n");
            }
            if (isCorrect)
            {
                direccion direcciondb = new direccion
                {
                    Id = this.principalCliente.direccion.Id,
                    Direccion1 = this.direccionTextBox.Text,
                    CP = this.CPTextBox.Text,
                    Estado = this.estadoTextBox.Text,
                    Municipio = this.municipioTextBox.Text
                };
                direccion dirAux = this.direccionLoader.editDirection(direcciondb);
                cliente clientedb = new cliente
                {
                    Id = this.principalCliente.Id,
                    Celular = this.CelularTextBox.Text,
                    Nombre = this.nombreTextBox.Text,
                    Telefono = this.CelularTextBox.Text
                };
                cliente clienAux = clienteLoader.editCliente(clientedb);

                if (clienAux == null || dirAux == null)
                {
                    this.showAlert("", "Error al guardar sus datos");
                }
                else
                {
                    this.showAlert("", "Cliente editado con éxito");
                    clientedb.direccion = direcciondb;
                    this.setDataClient(clientedb);
                    this.hidePanels(true);

                }
            }
            else {
                this.showAlert("", str.ToString());
            }
            
        }
        private void hidePanels(bool band) {
            if (band)
            {
                this.panel1.Hide();
                this.panel2.Hide();
            }
            else {
                this.panel1.Show();
                this.panel2.Show();
            }
        }

        private void showAlert(String header, String message) {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, header, buttons);
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.clienteLoader.removeElementById(this.principalCliente.Id))
            {
                this.showAlert("", "Usuario eliminado con exito");
                this.principalView.Show();
                this.principalView.reloadData();
                this.Hide();
            }
            else {
                this.showAlert("", "Error al guardar sus datos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.principalView.Show();
            this.principalView.reloadData();
            this.Hide();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregaDieta agregaDieta = new AgregaDieta(this.principalCliente);
            this.Hide();
            agregaDieta.Show();
        }
    }
}
