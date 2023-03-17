using RecuperatorioBrendaMontes.Datos;
using RecuperatorioBrendaMontes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepositorioBrendaMontes.Windows
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }
        private Repositorio repositorio = new Repositorio();
        private List<Triangulo> lista;
        private int Cantidad;
private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            TrianguloAE aE = new TrianguloAE();
            DialogResult dialogResult = aE.ShowDialog(this);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            Triangulo triangulo = aE.GetTriangulo();

            repositorio.Agregar(triangulo);
            DataGridViewRow f = ConstruirFila();
            SetearFila(f, triangulo);
            AgregarFila(f);
            Cantidad = repositorio.GetCantidad();
            MostrarTotal();
            repositorio.Guardar();

        }

        private void BorrarButton_Click_1(object sender, EventArgs e)
        {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    return;
                }
                var f = dataGridView1.SelectedRows[0];
                Triangulo trianguloBorrar = f.Tag as Triangulo;
                DialogResult dialogResult = MessageBox.Show($"¿Quiere BORRAR este triangulo ingresado?",
                    "Confirmar Borrado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                repositorio.Borrar(trianguloBorrar);
                dataGridView1.Rows.Remove(f);

                Cantidad = repositorio.GetCantidad();
                MostrarTotal();
                repositorio.Guardar();
 
        }

        private void EditarButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            var f = dataGridView1.SelectedRows[0];
            Triangulo trianguloEditar = f.Tag as Triangulo;
            TrianguloAE aE = new TrianguloAE() { Text = "Editar triangulo" };
            aE.SetTriangulo(trianguloEditar);
            DialogResult dialogResult = aE.ShowDialog(this);

            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            trianguloEditar = aE.GetTriangulo();
            repositorio.Editar(trianguloEditar);
            SetearFila(f, trianguloEditar);
            lista = repositorio.GetLista();
            MostrarLista();
            repositorio.Guardar();
        }

        private void MostrarTotal()
        {
            CantidadtextBox.Text = Cantidad.ToString();
        }

        private void AgregarFila(DataGridViewRow f)
        {
            dataGridView1.Rows.Add(f);
        }

        private void SetearFila(DataGridViewRow f, Triangulo triangulo)
        {

            f.Cells[LadoACol.Index].Value = triangulo.LadoA.ToString();
            f.Cells[LadoBCol.Index].Value = triangulo.LadoB.ToString();
            f.Cells[LadoCol.Index].Value = triangulo.LadoC.ToString();
            f.Cells[RellenoCol.Index].Value = triangulo.relleno.ToString();
            f.Cells[TrazoCol.Index].Value = triangulo.trazo.ToString();
            f.Cells[PerimetroCol.Index].Value = triangulo.GetPerimetro().ToString();
            f.Cells[AreaCol.Index].Value = triangulo.GetArea().ToString();
            f.Cells[TipodetrianguloCol.Index].Value = triangulo.GetTipoDeTriangulo();
            f.Tag = triangulo;
        }

        private DataGridViewRow ConstruirFila()
        {
            var f = new DataGridViewRow();
            f.CreateCells(dataGridView1);
            return f;
        }

        private void MostrarLista()
        {
            dataGridView1.Rows.Clear();
            foreach (var triangulo in lista)
            {
                var r = ConstruirFila();
                SetearFila(r, triangulo);
                AgregarFila(r);
            }
        }

         private void SalirButton_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("¡Desea salir del programa?");
            if (dialogResult==DialogResult.No)
            {
                return;
            }
            repositorio.Guardar();
            Application.Exit();
        }

        private void CantidadtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cantidadlabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            repositorio = new Repositorio();
            lista = repositorio.GetLista();
            Cantidad = repositorio.GetCantidad();
            if (Cantidad>0)
            {
                lista = repositorio.GetLista();
                MostrarLista();
            }
            else
            {
                MessageBox.Show("El repositorio esta vacio");
            }
            MostrarTotal();
        }

        private void FiltrarButton_ButtonClick(object sender, EventArgs e)
        {

        }
       

        private void ascendeteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ordenar = Ordenar.Ascendente;
            lista = repositorio.OrdenarLista(ordenar);
            MostrarLista();
        }

        private void descendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ordenar = Ordenar.Descendente;
            lista = repositorio.OrdenarLista(ordenar);
            MostrarLista();
        }

        private void RefrescarButton_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            lista = repositorio.GetLista();
            MostrarLista();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
