using ExamenC_Educomser.Classes;
using System;
namespace ExamenC_Educomser
{
    public partial class Form1 : Form
    {
        private Point posicionPoligono = new Point(200, 200);
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularTriangulo(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo();
            if (double.TryParse(baseBox.Text, out double baseNum) && double.TryParse(alturaBox.Text, out double alturaNum))
            {
                triangulo.Base = baseNum;
                triangulo.Alturta = alturaNum;

                baseBox.Text = "";
                alturaBox.Text = "";

                resultadoLabel.Text = triangulo.ToString();

            }
            else
            {
                MessageBox.Show("Por favor ingrese solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularRectangulo(object sender, EventArgs e)
        {
            Rectangulo triangulo = new Rectangulo();
            if (double.TryParse(baseBox.Text, out double baseNum) && double.TryParse(alturaBox.Text, out double alturaNum))
            {
                triangulo.Base = baseNum;
                triangulo.Alturta = alturaNum;

                baseBox.Text = "";
                alturaBox.Text = "";

                resultadoLabel.Text = triangulo.ToString();
            }
            else
            {
                MessageBox.Show("Por favor ingrese solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularElipse(object sender, EventArgs e)
        {
            Elipse triangulo = new Elipse();
            if (double.TryParse(baseBox.Text, out double baseNum) && double.TryParse(alturaBox.Text, out double alturaNum))
            {
                triangulo.Base = baseNum;
                triangulo.Alturta = alturaNum;

                baseBox.Text = "";
                alturaBox.Text = "";

                resultadoLabel.Text = triangulo.ToString();
            }
            else
            {
                MessageBox.Show("Por favor ingrese solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabTriangulo_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panelTriangulo_Paint(object sender, PaintEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxA.Text) ||
            string.IsNullOrWhiteSpace(textBoxB.Text) ||
            string.IsNullOrWhiteSpace(textBoxC.Text))
            {
                return;
            }

            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.Blue, 3);

            if (int.TryParse(textBoxA.Text, out int a) && int.TryParse(textBoxB.Text, out int b) && int.TryParse(textBoxC.Text, out int c))
            {
                Point p1 = new Point(a, 75);
                Point p2 = new Point(b, 25);
                Point p3 = new Point(c, 75);

                textBoxA.Text = "";
                textBoxB.Text = "";
                textBoxC.Text = "";

                graphics.DrawPolygon(pen, new Point[] { p1, p2, p3 });
            }
            else
            {
                MessageBox.Show("Por favor ingrese solo números eneteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dibujaTriangulo(object sender, EventArgs e)
        {
            panelTriangulo.Invalidate();
        }
    }
}
