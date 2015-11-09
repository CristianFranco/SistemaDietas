using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using agregaUsuario.DataTransfer;
using agregaUsuario.Model;

namespace agregaUsuario.Forms
{
    public partial class Principal : Form
    {

        private List<cliente> clientes;
        private List<cliente> clienteActual;
        public Principal()
        {
            InitializeComponent();
            this.reloadData();
        }

        public void reloadData()
        {
            ClienteLoader clienteLoader = new ClienteLoader();
            List<String> direc = new List<string>();
            direc.Add("direccion");
            clientes = clienteLoader.GetAll(direc);
            this.loadTable(clientes);
        }

        private void findByName(string name)
        {
            if (String.IsNullOrEmpty(name)) {
                this.loadTable(clientes);
                return;
            }
            IEnumerable<cliente> c = from cliente in clientes where cliente.Nombre.Contains(name) select cliente;            
            List<cliente> clientesLocal = c.ToList<cliente>();
            this.loadTable(clientesLocal);
        }

        private void loadTable(List<cliente> clientesLocales) {
            clienteActual = clientesLocales;
            listView1.Items.Clear();
            ListViewItem listViewItem;
            foreach (cliente cliente in clientesLocales)
            {
                string[] row = { cliente.Nombre, cliente.direccion.Direccion1, cliente.Telefono };
                listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            ListViewItem listViewItem;
            foreach (cliente cliente in clientes) {
                string[] row = { cliente.Nombre, cliente.direccion.Direccion1, cliente.Telefono };
                listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            this.findByName(this.nombreTextBox.Text);
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0) {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show("", "Debe de seleccionar algún cliente", buttons);
                return;
            }
            ClientePerfil clientePerfil;
            foreach (ListViewItem list in this.listView1.SelectedItems) {
                clientePerfil = new ClientePerfil();
                clientePerfil.setDataClient(clienteActual[list.Index]);
                clientePerfil.Show();
                clientePerfil.setFatherView(this);
                this.Hide();
                break;
               // clientePerfil.
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 addUser = new Form1();
            addUser.setFatherView(this);
            this.Hide();
            addUser.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
