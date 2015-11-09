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
    public partial class AgregaDieta : Form
    {
        private MateriaPrimaLoader materiaPrimaLoader = new MateriaPrimaLoader();
        private List<materia_prima> materiasPrimas;
        private cliente clientePrincipal;
        public AgregaDieta(cliente clienteAux)
        {
            InitializeComponent();
            this.clientePrincipal = clienteAux;
            materiasPrimas = this.materiaPrimaLoader.GetAll();
            foreach (var materiaPrima in materiasPrimas) {
                this.MateriasComboBox.Items.Add(materiaPrima.Nombre);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            materia_prima materiaPrima = materiasPrimas[this.MateriasComboBox.SelectedIndex];// ElementAt<materia_prima>();
            this.loadTableMateriaPrima(materiaPrima);
        }

        private void loadTableMateriaPrima(materia_prima materia)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            ListViewItem listViewItem;
            ListViewItem listViewItem2;
            string[] row = { materia.Nombre, materia.Fosforo.ToString(), materia.MateriaGrasa.ToString(), materia.CenizaBruta.ToString(), materia.FibraBruta.ToString(), materia.ProteinaBruta.ToString(), materia.MateriaSeca.ToString() };
            string[] row2 = { materia.FND.ToString(), materia.FAD.ToString(), materia.LAD.ToString(), materia.ParedVegetal.ToString(), materia.Azucares.ToString(), materia.CenizasInsolubles.ToString(), materia.Almidon.ToString(), materia.EnergiaBruta.ToString() };
            listViewItem = new ListViewItem(row);
            listViewItem2 = new ListViewItem(row2);
            listView1.Items.Add(listViewItem);
            listView2.Items.Add(listViewItem2);
        }

        private void MateriasComboBox_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void MateriasComboBox_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void MateriasComboBox_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void MateriasComboBox_MouseLeave(object sender, EventArgs e)
        {
            Console.Write("hola3");
        }

        private void MateriasComboBox_MouseHover(object sender, EventArgs e)
        {
            Console.Write("hola3");
        }

        private void MateriasComboBox_MouseEnter(object sender, EventArgs e)
        {
            Console.Write("hola3");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AgregarMateriaButton_Click(object sender, EventArgs e)
        {
            materia_prima materiaPrima = materiasPrimas[this.MateriasComboBox.SelectedIndex];
            this.addIngredientsTable(materiaPrima);

        }

        private void addIngredientsTable(materia_prima materiaPrima) {
            ListViewItem listViewItem;
            long n;
            if (long.TryParse(this.cantidadTextBox.Text, out n))
            {

                string[] row = { this.cantidadTextBox.Text, materiaPrima.Nombre };
                listViewItem = new ListViewItem(row);
                ingredientesListView.Items.Add(listViewItem);
                this.cantidadTextBox.Text = "";
            }
            else {
                this.showAlert("Cantidad no valida", "Error en cantidad");
            }
        }
        private void showAlert(String header, String message)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, header, buttons);
        }

        private void ingredientesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem list in this.ingredientesListView.SelectedItems)
            {
                this.loadTableMateriaPrima(materiasPrimas[list.Index]);
                break;
                // clientePerfil.
            }
        }

        private void ingredientesListView_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem list in this.ingredientesListView.SelectedItems)
            {
                this.loadTableMateriaPrima(materiasPrimas[list.Index]);
                break;
                // clientePerfil.
            }
        }
    }
}
