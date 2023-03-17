
namespace RepositorioBrendaMontes.Windows
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.Cantidadlabel = new System.Windows.Forms.Label();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LadoACol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LadoBCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RellenoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrazoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerimetroCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipodetrianguloCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoButton = new System.Windows.Forms.ToolStripButton();
            this.EditarButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FiltrarButton = new System.Windows.Forms.ToolStripSplitButton();
            this.isoscelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equilateroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefrescarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OrdenarDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ascendeteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cantidadlabel
            // 
            this.Cantidadlabel.AutoSize = true;
            this.Cantidadlabel.Location = new System.Drawing.Point(454, 9);
            this.Cantidadlabel.Name = "Cantidadlabel";
            this.Cantidadlabel.Size = new System.Drawing.Size(49, 13);
            this.Cantidadlabel.TabIndex = 7;
            this.Cantidadlabel.Text = "Cantidad";
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(509, 6);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.ReadOnly = true;
            this.CantidadtextBox.Size = new System.Drawing.Size(100, 20);
            this.CantidadtextBox.TabIndex = 6;
            this.CantidadtextBox.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LadoACol,
            this.LadoBCol,
            this.LadoCol,
            this.RellenoCol,
            this.TrazoCol,
            this.PerimetroCol,
            this.AreaCol,
            this.TipodetrianguloCol});
            this.dataGridView1.Location = new System.Drawing.Point(0, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(804, 202);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // LadoACol
            // 
            this.LadoACol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LadoACol.HeaderText = "Lado A";
            this.LadoACol.Name = "LadoACol";
            this.LadoACol.ReadOnly = true;
            // 
            // LadoBCol
            // 
            this.LadoBCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LadoBCol.HeaderText = "Lado B ";
            this.LadoBCol.Name = "LadoBCol";
            this.LadoBCol.ReadOnly = true;
            // 
            // LadoCol
            // 
            this.LadoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LadoCol.HeaderText = "Lado C";
            this.LadoCol.Name = "LadoCol";
            this.LadoCol.ReadOnly = true;
            // 
            // RellenoCol
            // 
            this.RellenoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RellenoCol.HeaderText = "Relleno";
            this.RellenoCol.Name = "RellenoCol";
            this.RellenoCol.ReadOnly = true;
            // 
            // TrazoCol
            // 
            this.TrazoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrazoCol.HeaderText = "Trazo";
            this.TrazoCol.Name = "TrazoCol";
            this.TrazoCol.ReadOnly = true;
            // 
            // PerimetroCol
            // 
            this.PerimetroCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PerimetroCol.HeaderText = "Perimetro";
            this.PerimetroCol.Name = "PerimetroCol";
            this.PerimetroCol.ReadOnly = true;
            // 
            // AreaCol
            // 
            this.AreaCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AreaCol.HeaderText = "Area";
            this.AreaCol.Name = "AreaCol";
            this.AreaCol.ReadOnly = true;
            // 
            // TipodetrianguloCol
            // 
            this.TipodetrianguloCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipodetrianguloCol.HeaderText = "Tipo de Triangulo";
            this.TipodetrianguloCol.Name = "TipodetrianguloCol";
            this.TipodetrianguloCol.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoButton,
            this.EditarButton,
            this.BorrarButton,
            this.toolStripSeparator1,
            this.FiltrarButton,
            this.RefrescarButton,
            this.toolStripSeparator2,
            this.OrdenarDownButton,
            this.SalirButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(804, 38);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(46, 35);
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click_1);
            // 
            // EditarButton
            // 
            this.EditarButton.Image = ((System.Drawing.Image)(resources.GetObject("EditarButton.Image")));
            this.EditarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(41, 35);
            this.EditarButton.Text = "Editar";
            this.EditarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click_1);
            // 
            // BorrarButton
            // 
            this.BorrarButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrarButton.Image")));
            this.BorrarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(43, 35);
            this.BorrarButton.Text = "Borrar";
            this.BorrarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarButton.Click += new System.EventHandler(this.BorrarButton_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // FiltrarButton
            // 
            this.FiltrarButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isoscelesToolStripMenuItem,
            this.equilateroToolStripMenuItem,
            this.escalenoToolStripMenuItem});
            this.FiltrarButton.Image = ((System.Drawing.Image)(resources.GetObject("FiltrarButton.Image")));
            this.FiltrarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(53, 35);
            this.FiltrarButton.Text = "Filtrar";
            this.FiltrarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FiltrarButton.ButtonClick += new System.EventHandler(this.FiltrarButton_ButtonClick);
            // 
            // isoscelesToolStripMenuItem
            // 
            this.isoscelesToolStripMenuItem.Name = "isoscelesToolStripMenuItem";
            this.isoscelesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.isoscelesToolStripMenuItem.Text = "Isosceles";
            // 
            // equilateroToolStripMenuItem
            // 
            this.equilateroToolStripMenuItem.Name = "equilateroToolStripMenuItem";
            this.equilateroToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.equilateroToolStripMenuItem.Text = "Equilatero";
            // 
            // escalenoToolStripMenuItem
            // 
            this.escalenoToolStripMenuItem.Name = "escalenoToolStripMenuItem";
            this.escalenoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.escalenoToolStripMenuItem.Text = "Escaleno";
            // 
            // RefrescarButton
            // 
            this.RefrescarButton.Image = ((System.Drawing.Image)(resources.GetObject("RefrescarButton.Image")));
            this.RefrescarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefrescarButton.Name = "RefrescarButton";
            this.RefrescarButton.Size = new System.Drawing.Size(59, 35);
            this.RefrescarButton.Text = "Refrescar";
            this.RefrescarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // OrdenarDownButton
            // 
            this.OrdenarDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendeteToolStripMenuItem,
            this.descendenteToolStripMenuItem});
            this.OrdenarDownButton.Image = ((System.Drawing.Image)(resources.GetObject("OrdenarDownButton.Image")));
            this.OrdenarDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdenarDownButton.Name = "OrdenarDownButton";
            this.OrdenarDownButton.Size = new System.Drawing.Size(66, 35);
            this.OrdenarDownButton.Text = "Ordenar ";
            this.OrdenarDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ascendeteToolStripMenuItem
            // 
            this.ascendeteToolStripMenuItem.Name = "ascendeteToolStripMenuItem";
            this.ascendeteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.ascendeteToolStripMenuItem.Text = "Ascendente";
            // 
            // descendenteToolStripMenuItem
            // 
            this.descendenteToolStripMenuItem.Name = "descendenteToolStripMenuItem";
            this.descendenteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.descendenteToolStripMenuItem.Text = "Descendente ";
            // 
            // SalirButton
            // 
            this.SalirButton.Image = ((System.Drawing.Image)(resources.GetObject("SalirButton.Image")));
            this.SalirButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(36, 35);
            this.SalirButton.Text = "Salir ";
            this.SalirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 239);
            this.ControlBox = false;
            this.Controls.Add(this.Cantidadlabel);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal ";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cantidadlabel;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LadoACol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LadoBCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LadoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RellenoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrazoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerimetroCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipodetrianguloCol;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoButton;
        private System.Windows.Forms.ToolStripButton EditarButton;
        private System.Windows.Forms.ToolStripButton BorrarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton FiltrarButton;
        private System.Windows.Forms.ToolStripMenuItem isoscelesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equilateroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton RefrescarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton OrdenarDownButton;
        private System.Windows.Forms.ToolStripMenuItem ascendeteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton SalirButton;
    }
}

