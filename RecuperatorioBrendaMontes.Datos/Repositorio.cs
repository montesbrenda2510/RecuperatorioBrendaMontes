using RecuperatorioBrendaMontes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioBrendaMontes.Datos
{
    public class Repositorio
    {
        private List<Triangulo> listatriangulos;
        private bool haycambios = false;

        public Repositorio()
        {
            listatriangulos = new List<Triangulo>();
            listatriangulos = ManejadordeArchivo.LeerArchivo();
        }

        public void Agregar(Triangulo triangulo)
        {
            haycambios = true;
            listatriangulos.Add(triangulo);

        }
        public void Borrar(Triangulo triangulo)
        {
            haycambios = true;
            listatriangulos.Remove(triangulo);

        }
        public void Editar(Triangulo triangulo)
        {
            haycambios = true;

        }
        public List<Triangulo> GetLista()
        {
            return listatriangulos;
        }

        public int GetCantidad()
        {
            return listatriangulos.Count;
        }
        public void Guardar()
        {
            if (haycambios)
            {
                ManejadordeArchivo.GuardarenArchivo(listatriangulos);
            }
        }



        public List<Triangulo> OrdenarLista(Ordenar ordenar)
        {
            return ordenar == Ordenar.Ascendente ? listatriangulos.OrderBy(A => A.GetPerimetro()).ToList() : listatriangulos.OrderByDescending(A => A.GetPerimetro()).ToList();
        }
    }
}
