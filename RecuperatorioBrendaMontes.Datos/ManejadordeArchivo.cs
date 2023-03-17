using RecuperatorioBrendaMontes.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioBrendaMontes.Datos
{
    class ManejadordeArchivo
    {
        private static string archivo = "Triangulo.txt";
        public static void GuardarenArchivo(List<Triangulo> lista)
        {
            using (var escritor = new StreamWriter(archivo))
            {
                foreach (var triangulo in lista)
                {
                    string linea = ConstruirLinea(triangulo);
                    escritor.WriteLine(linea);
                }
            }

        }

        private static string ConstruirLinea(Triangulo triangulo)
        {
            return $"{triangulo.LadoA} | {triangulo.LadoB} | {triangulo.LadoC} | {(int)triangulo.relleno} | {(int)triangulo.trazo} ";
        }
        public static List<Triangulo> LeerArchivo()
        {
            List<Triangulo> lista = new List<Triangulo>();
            if (File.Exists(archivo))
            {
                using (var lector = new StreamReader(archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        string linea = lector.ReadLine();
                        Triangulo triangulo = ConstruirTriangulo(linea);
                        lista.Add(triangulo);
                    }
                }

            }
            return lista;
        }

        private static Triangulo ConstruirTriangulo(string linea)
        {
            var campos = linea.Split('|');
            Triangulo triangulo = new Triangulo()
            {
                LadoA = int.Parse(campos[0]),
                LadoB = int.Parse(campos[1]),
                LadoC = int.Parse(campos[2]),
                relleno = (Relleno)int.Parse(campos[3]),
                trazo = (Trazo)int.Parse(campos[4]),

            };
            return triangulo;


        }
    }
}

