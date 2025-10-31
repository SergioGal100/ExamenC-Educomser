
namespace ExamenC_Educomser.Classes
{
    internal class Rectangulo : FiguraGeometrica, IPoligono
    {
        public double Base { get; set; }
        public double Alturta { get; set; }
        public double area(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public override string ToString()
        {
            base.nombre = "Rectangulo";
            double resultado = area(Base, Alturta);
            return $"El nombre de la figura es {base.nombre} y el area es {resultado}";
        }
    }
}
