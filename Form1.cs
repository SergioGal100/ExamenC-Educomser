using ExamenC_Educomser.Classes;
using System;
using System.Windows.Forms;
namespace ExamenC_Educomser
{
    public partial class Form1 : Form
    {
        private Stack<string> queue = new Stack<string>();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabRectangulo_Click(object sender, EventArgs e)
        {

        }

        private void panelRectangulo_paint(object sender, PaintEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxARec.Text) ||
            string.IsNullOrWhiteSpace(textBoxBRec.Text))
            {
                return;
            }

            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.Blue, 3);


            if (int.TryParse(textBoxARec.Text, out int a) &&
                int.TryParse(textBoxBRec.Text, out int b))
            {
                if (a != b)
                {
                    Brush brocha = new SolidBrush(Color.Red);
                    graphics.FillRectangle(brocha, 50, 10, a, b);
                }
                else
                {
                    MessageBox.Show("Para un rectangulo la altura debe ser mayor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor ingrese solo números eneteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDibRect_Click(object sender, EventArgs e)
        {
            panelRectangulo.Invalidate();
        }

        private void panelParalelo_paint(object sender, PaintEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBase.Text) ||
                string.IsNullOrWhiteSpace(textBoxAltura.Text) ||
                string.IsNullOrWhiteSpace(textBoxDesplazamiento.Text))
            {
                return;
            }

            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.Blue, 3);


            if (int.TryParse(textBoxBase.Text, out int baseP) &&
                int.TryParse(textBoxAltura.Text, out int alturaP) &&
                int.TryParse(textBoxDesplazamiento.Text, out int offset))
            {

                Point p1 = new Point(25, 75);
                Point p2 = new Point(25 + offset, 75 - alturaP);
                Point p3 = new Point(25 + offset + baseP, 75 - alturaP);
                Point p4 = new Point(25 + baseP, 75);

                // Dibujar figura
                graphics.DrawPolygon(pen, new Point[] { p1, p2, p3, p4 });

                // Limpiar TextBox después de dibujar
                textBoxBase.Clear();
                textBoxAltura.Clear();
                textBoxDesplazamiento.Clear();
            }
            else
            {
                MessageBox.Show("Por favor ingrese solo números enteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dibujaParalelogram(object sender, EventArgs e)
        {
            tabParalelogramo.Invalidate();
        }

        private void buttonInsertStack(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxStack.Text))
            {
                MessageBox.Show("Por favor ingrese datos antes de guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string data = textBoxStack.Text;
                this.queue.Push(data);
                textBoxStack.Text = "";
            }

        }

        private void buttonShowStack(object sender, EventArgs e)
        {
            foreach (var item in this.queue)
            {
                listBoxStack.Items.Add(item);
            }
        }
    }
}
