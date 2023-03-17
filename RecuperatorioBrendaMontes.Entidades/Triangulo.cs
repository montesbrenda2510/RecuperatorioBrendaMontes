using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioBrendaMontes.Entidades
{
    public class Triangulo
    {
        public int LadoA { get; set; }
        public int LadoB { get; set; }
        public int LadoC { get; set; }
        public Trazo trazo { get; set; }
        public Relleno relleno { get; set; }

        public double GetPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }
        public double GetArea()
        {
            double S;
            S = (LadoA + LadoB + LadoC) / 2;

            return Math.Sqrt(S * (S - LadoA) * (S - LadoB) * (S - LadoC));

        }

        public string GetTipoDeTriangulo()
        {
            string Tipodetriangulo;
            if (LadoA == LadoB && LadoB == LadoC && LadoA == LadoC)
            {
                Tipodetriangulo = "equilatero";
            }
            else if (LadoA != LadoB && LadoB != LadoC && LadoC != LadoA)
            {
                Tipodetriangulo = "escaleno";
            }
            else
            {
                Tipodetriangulo = "isosceles";
            }
            return Tipodetriangulo;
        }
        public bool Validar()
        {
            if (LadoA + LadoB > LadoC && LadoB + LadoC > LadoA && LadoA + LadoC > LadoB)
            {

                return true;

            }
            return false;
        }

}
}
