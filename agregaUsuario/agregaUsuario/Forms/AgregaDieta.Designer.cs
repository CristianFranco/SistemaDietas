namespace agregaUsuario.Forms
{
    partial class AgregaDieta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MateriasComboBox = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.AgregarMateriaButton = new System.Windows.Forms.Button();
            this.ingredientesListView = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // MateriasComboBox
            // 
            this.MateriasComboBox.FormattingEnabled = true;
            this.MateriasComboBox.IntegralHeight = false;
            this.MateriasComboBox.ItemHeight = 13;
            this.MateriasComboBox.Location = new System.Drawing.Point(258, 58);
            this.MateriasComboBox.MaxDropDownItems = 6;
            this.MateriasComboBox.Name = "MateriasComboBox";
            this.MateriasComboBox.Size = new System.Drawing.Size(383, 21);
            this.MateriasComboBox.TabIndex = 0;
            this.MateriasComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.MateriasComboBox.MouseCaptureChanged += new System.EventHandler(this.MateriasComboBox_MouseCaptureChanged);
            this.MateriasComboBox.MouseEnter += new System.EventHandler(this.MateriasComboBox_MouseEnter);
            this.MateriasComboBox.MouseLeave += new System.EventHandler(this.MateriasComboBox_MouseLeave);
            this.MateriasComboBox.MouseHover += new System.EventHandler(this.MateriasComboBox_MouseHover);
            this.MateriasComboBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MateriasComboBox_MouseMove);
            this.MateriasComboBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MateriasComboBox_MouseUp);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Location = new System.Drawing.Point(134, 127);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(610, 55);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fosforo";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Materia Grasa";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ceniza Bruta";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fribra Bruta";
            this.columnHeader5.Width = 86;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Proteina Bruta";
            this.columnHeader6.Width = 101;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Materia Seca";
            this.columnHeader7.Width = 78;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader14,
            this.columnHeader13,
            this.columnHeader15});
            this.listView2.Location = new System.Drawing.Point(134, 178);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(610, 62);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "FND";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "FAD";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "LAD";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Pared Vegetal";
            this.columnHeader11.Width = 91;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Azucares";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Cenizas insolubles";
            this.columnHeader14.Width = 104;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Almidon";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Energia Bruta";
            this.columnHeader15.Width = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Materias Primas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad (Kg)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(541, 259);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadTextBox.TabIndex = 6;
            // 
            // AgregarMateriaButton
            // 
            this.AgregarMateriaButton.Location = new System.Drawing.Point(669, 256);
            this.AgregarMateriaButton.Name = "AgregarMateriaButton";
            this.AgregarMateriaButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarMateriaButton.TabIndex = 7;
            this.AgregarMateriaButton.Text = "Agregar";
            this.AgregarMateriaButton.UseVisualStyleBackColor = true;
            this.AgregarMateriaButton.Click += new System.EventHandler(this.AgregarMateriaButton_Click);
            // 
            // ingredientesListView
            // 
            this.ingredientesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17});
            this.ingredientesListView.Location = new System.Drawing.Point(145, 328);
            this.ingredientesListView.Name = "ingredientesListView";
            this.ingredientesListView.Size = new System.Drawing.Size(291, 93);
            this.ingredientesListView.TabIndex = 8;
            this.ingredientesListView.UseCompatibleStateImageBehavior = false;
            this.ingredientesListView.View = System.Windows.Forms.View.Details;
            this.ingredientesListView.SelectedIndexChanged += new System.EventHandler(this.ingredientesListView_SelectedIndexChanged);
            this.ingredientesListView.Click += new System.EventHandler(this.ingredientesListView_Click);
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Cantidad";
            this.columnHeader16.Width = 63;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Materia";
            this.columnHeader17.Width = 208;
            // 
            // AgregaDieta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 478);
            this.Controls.Add(this.ingredientesListView);
            this.Controls.Add(this.AgregarMateriaButton);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.MateriasComboBox);
            this.Name = "AgregaDieta";
            this.Text = "AgregaDieta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MateriasComboBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.Button AgregarMateriaButton;
        private System.Windows.Forms.ListView ingredientesListView;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
    }
}