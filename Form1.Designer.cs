namespace ExamenC_Educomser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            baseBox = new TextBox();
            alturaBox = new TextBox();
            label2 = new Label();
            resultadoLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tabControl = new TabControl();
            tabTriangulo = new TabPage();
            lblPuntoC = new Label();
            lblPuntoB = new Label();
            lblPuntoA = new Label();
            panelTriangulo = new Panel();
            textBoxC = new TextBox();
            textBoxB = new TextBox();
            textBoxA = new TextBox();
            tabRectangulo = new TabPage();
            tabParalelogramo = new TabPage();
            buttonDibujaTriangulo = new Button();
            tabControl.SuspendLayout();
            tabTriangulo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 55);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Base";
            // 
            // baseBox
            // 
            baseBox.Location = new Point(125, 47);
            baseBox.Name = "baseBox";
            baseBox.Size = new Size(100, 23);
            baseBox.TabIndex = 1;
            // 
            // alturaBox
            // 
            alturaBox.Location = new Point(125, 87);
            alturaBox.Name = "alturaBox";
            alturaBox.Size = new Size(100, 23);
            alturaBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 94);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Altura";
            // 
            // resultadoLabel
            // 
            resultadoLabel.AutoSize = true;
            resultadoLabel.Location = new Point(12, 128);
            resultadoLabel.Name = "resultadoLabel";
            resultadoLabel.Size = new Size(0, 15);
            resultadoLabel.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(82, 150);
            button1.Name = "button1";
            button1.Size = new Size(144, 23);
            button1.TabIndex = 5;
            button1.Text = "CALCULAR TRIANGULO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CalcularTriangulo;
            // 
            // button2
            // 
            button2.Location = new Point(81, 179);
            button2.Name = "button2";
            button2.Size = new Size(165, 23);
            button2.TabIndex = 6;
            button2.Text = "CALCULAR RECTANGULO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += CalcularRectangulo;
            // 
            // button3
            // 
            button3.Location = new Point(82, 208);
            button3.Name = "button3";
            button3.Size = new Size(144, 23);
            button3.TabIndex = 7;
            button3.Text = "CALCULAR ECLIPSE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += CalcularElipse;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabTriangulo);
            tabControl.Controls.Add(tabRectangulo);
            tabControl.Controls.Add(tabParalelogramo);
            tabControl.Location = new Point(344, 38);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(395, 193);
            tabControl.TabIndex = 8;
            // 
            // tabTriangulo
            // 
            tabTriangulo.Controls.Add(buttonDibujaTriangulo);
            tabTriangulo.Controls.Add(lblPuntoC);
            tabTriangulo.Controls.Add(lblPuntoB);
            tabTriangulo.Controls.Add(lblPuntoA);
            tabTriangulo.Controls.Add(panelTriangulo);
            tabTriangulo.Controls.Add(textBoxC);
            tabTriangulo.Controls.Add(textBoxB);
            tabTriangulo.Controls.Add(textBoxA);
            tabTriangulo.Location = new Point(4, 24);
            tabTriangulo.Name = "tabTriangulo";
            tabTriangulo.Padding = new Padding(3);
            tabTriangulo.Size = new Size(387, 165);
            tabTriangulo.TabIndex = 0;
            tabTriangulo.Text = "Triangulo";
            tabTriangulo.UseVisualStyleBackColor = true;
            tabTriangulo.Click += tabTriangulo_Click;
            // 
            // lblPuntoC
            // 
            lblPuntoC.AutoSize = true;
            lblPuntoC.Location = new Point(14, 92);
            lblPuntoC.Name = "lblPuntoC";
            lblPuntoC.Size = new Size(21, 15);
            lblPuntoC.TabIndex = 6;
            lblPuntoC.Text = "C: ";
            // 
            // lblPuntoB
            // 
            lblPuntoB.AutoSize = true;
            lblPuntoB.Location = new Point(15, 61);
            lblPuntoB.Name = "lblPuntoB";
            lblPuntoB.Size = new Size(20, 15);
            lblPuntoB.TabIndex = 5;
            lblPuntoB.Text = "B: ";
            // 
            // lblPuntoA
            // 
            lblPuntoA.AutoSize = true;
            lblPuntoA.Location = new Point(14, 28);
            lblPuntoA.Name = "lblPuntoA";
            lblPuntoA.Size = new Size(21, 15);
            lblPuntoA.TabIndex = 4;
            lblPuntoA.Text = "A: ";
            // 
            // panelTriangulo
            // 
            panelTriangulo.Location = new Point(155, 25);
            panelTriangulo.Name = "panelTriangulo";
            panelTriangulo.Size = new Size(200, 100);
            panelTriangulo.TabIndex = 3;
            panelTriangulo.Paint += panelTriangulo_Paint;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(38, 88);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(35, 23);
            textBoxC.TabIndex = 2;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(38, 58);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(35, 23);
            textBoxB.TabIndex = 1;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(38, 25);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(35, 23);
            textBoxA.TabIndex = 0;
            // 
            // tabRectangulo
            // 
            tabRectangulo.Location = new Point(4, 24);
            tabRectangulo.Name = "tabRectangulo";
            tabRectangulo.Padding = new Padding(3);
            tabRectangulo.Size = new Size(387, 165);
            tabRectangulo.TabIndex = 1;
            tabRectangulo.Text = "Rectángulo";
            tabRectangulo.UseVisualStyleBackColor = true;
            // 
            // tabParalelogramo
            // 
            tabParalelogramo.Location = new Point(4, 24);
            tabParalelogramo.Name = "tabParalelogramo";
            tabParalelogramo.Padding = new Padding(3);
            tabParalelogramo.Size = new Size(387, 165);
            tabParalelogramo.TabIndex = 2;
            tabParalelogramo.Text = "Paralelogramo";
            tabParalelogramo.UseVisualStyleBackColor = true;
            // 
            // buttonDibujaTriangulo
            // 
            buttonDibujaTriangulo.Location = new Point(67, 136);
            buttonDibujaTriangulo.Name = "buttonDibujaTriangulo";
            buttonDibujaTriangulo.Size = new Size(244, 23);
            buttonDibujaTriangulo.TabIndex = 7;
            buttonDibujaTriangulo.Text = "DIBUJA TRIANGULO";
            buttonDibujaTriangulo.UseVisualStyleBackColor = true;
            buttonDibujaTriangulo.Click += dibujaTriangulo;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 266);
            Controls.Add(tabControl);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(resultadoLabel);
            Controls.Add(label2);
            Controls.Add(alturaBox);
            Controls.Add(baseBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabTriangulo.ResumeLayout(false);
            tabTriangulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox baseBox;
        private TextBox alturaBox;
        private Label label2;
        private Label resultadoLabel;
        private Button button1;
        private Button button2;
        private Button button3;
        private TabControl tabControl;
        private TabPage tabTriangulo;
        private TabPage tabRectangulo;
        private TabPage tabParalelogramo;
        private TextBox textBoxC;
        private TextBox textBoxB;
        private TextBox textBoxA;
        private Panel panelTriangulo;
        private Label lblPuntoC;
        private Label lblPuntoB;
        private Label lblPuntoA;
        private Button buttonDibujaTriangulo;
    }
}
