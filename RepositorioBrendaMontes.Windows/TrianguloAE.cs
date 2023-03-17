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

    public partial class TrianguloAE : Form
    {
        public TrianguloAE()
        {
            InitializeComponent();
        }
        private Triangulo triangulo;
        private bool esEdicion = true;
        private Repositorio repositorio = new Repositorio();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LlenarComboBox();
            if (triangulo != null)
            {

                textBox1.Text = triangulo.LadoA.ToString();

                textBox2.Text = triangulo.LadoB.ToString();

                textBox3.Text = triangulo.LadoC.ToString();

                comboBox1.SelectedItem = (Relleno)triangulo.relleno;

                if (triangulo.trazo == Trazo.Continuo)
                {
                    ContinuoButton.Checked = true;
                }
                else if (triangulo.trazo == Trazo.Raya)
                {
                    RayasButton.Checked = true;
                }
                else
                {
                    PuntosButton.Checked = true;
                }

            }
        }

        private void LlenarComboBox()
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Relleno));
            comboBox1.SelectedItem = 1;
        }

        internal Triangulo GetTriangulo()
        {
            return triangulo;
        }

        private void TrianguloAE_Load(object sender, EventArgs e)
        {

        }

        internal void SetTriangulo(Triangulo trianguloEditar)
        {
            triangulo = trianguloEditar;
        }

        private void Cancelarbutton_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void OKbutton_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (triangulo == null)
                {
                    triangulo = new Triangulo();
                }
                triangulo.LadoA = int.Parse(textBox1.Text);
                triangulo.LadoB = int.Parse(textBox2.Text);
                triangulo.LadoC = int.Parse(textBox3.Text);
                triangulo.relleno = (Relleno)comboBox1.SelectedItem;
                triangulo.trazo = ContinuoButton.Checked ? Trazo.Continuo : RayasButton.Checked ? Trazo.Raya : Trazo.Puntos;
                if (!triangulo.Validar())
                {
                    MessageBox.Show("Los datos ingresados no son valido", "Informacion", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }

            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!esEdicion)
            {   //LadoA
                if (!int.TryParse(textBox1.Text, out int LadoA))
                {
                    valido = false;
                    errorProvider1.SetError(textBox1, "Tiene que ingrasar un valor numerico");
                }
                else if (LadoA <= 0)
                {
                    valido = false;
                    errorProvider1.SetError(textBox1, "El numero debe ser positivo");
                }
                //LadoB
                if (!int.TryParse(textBox2.Text, out int LadoB))
                {
                    valido = false;
                    errorProvider1.SetError(textBox2, "Tiene que ingrasar un valor Numerico");
                }
                else if (LadoB <= 0)
                {
                    valido = false;
                    errorProvider1.SetError(textBox2, "El numero debe ser positivo");
                }
                //LadoC
                if (!int.TryParse(textBox3.Text, out int LadoC))
                {
                    valido = false;
                    errorProvider1.SetError(textBox3, "Tiene que ingrasar un valor numerico");
                }
                else if (LadoC <= 0)
                {
                    valido = false;
                    errorProvider1.SetError(textBox3, "El numero debe ser positivo");
                }


            }

            return valido;

        }


    }
}

