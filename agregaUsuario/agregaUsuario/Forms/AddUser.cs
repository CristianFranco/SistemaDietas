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
using agregaUsuario.Forms;

namespace agregaUsuario
{
    public partial class Form1 : Form
    {
        private Principal principalView;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void setFatherView(Principal principal) {
            this.principalView = principal;
        }


        private void AgregarButton_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            bool isCorrect = true;
            long n;
            if (long.TryParse(this.CelularTextBox.Text, out n) && this.CelularTextBox.Text.Length == 10) {
            }
            else {
                isCorrect = false;
                str.Append("El numero de celular es incorrecto\n");
            }
            if (long.TryParse(this.TelefonoTextBox.Text, out n) && this.TelefonoTextBox.Text.Length == 10)
            {
            }
            else
            {
                isCorrect = false;
                str.Append("El numero de Telefono es incorrecto\n");
            }
            if (isCorrect) {
                ClienteLoader clienteLoader = new ClienteLoader();
                direccion direccionDb = new direccion
                {
                    Direccion1 = this.DireccionTextBox.Text,
                    CP = this.CPTextBox.Text,
                    Estado = this.EstadoTextBox.Text,
                    Municipio = this.MunicipioTextBox.Text
                };
                cliente clientedb = new cliente
                {
                    Celular = this.CelularTextBox.Text,
                    Nombre = this.NombreTextBox.Text,
                    Telefono = this.TelefonoTextBox.Text,
                    direccion = direccionDb
                };
                clientedb = clienteLoader.CreateNew(clientedb);
                if (clientedb == null)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show("", "Error al guardar sus datos", buttons);
                }
                else {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show("", "Datos guardados con exito", buttons);
                    this.clearAll();
                }
            }
            else { 
                string caption = "Error de captura";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(str.ToString(), caption, buttons);
            }
        }

        private void clearAll() {
            this.CPTextBox.Text = "";
            this.EstadoTextBox.Text = "";
            this.MunicipioTextBox.Text = "";
            this.CelularTextBox.Text = "";
            this.NombreTextBox.Text = "";
            this.TelefonoTextBox.Text = "";
            this.DireccionTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.principalView.Show();
            this.principalView.reloadData();
        }
    }
}
