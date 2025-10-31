using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenC_Educomser.Classes
{
    internal class Elipse : FiguraGeometrica, IPoligono
    {
        public double Base { get; set; }
        public double Alturta { get; set; }
        public double area(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public override string ToString()
        {
            base.nombre = "Elipse";
            double resultado = area(Base, Alturta);
            return $"El nombre de la figura es {base.nombre} y el area es {resultado}";
        }
    }
}
