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
            buttonDibujaTriangulo = new Button();
            lblPuntoC = new Label();
            lblPuntoB = new Label();
            lblPuntoA = new Label();
            panelTriangulo = new Panel();
            textBoxC = new TextBox();
            textBoxB = new TextBox();
            textBoxA = new TextBox();
            tabRectangulo = new TabPage();
            panelRectangulo = new Panel();
            textBoxBRec = new TextBox();
            textBoxARec = new TextBox();
            label4 = new Label();
            label3 = new Label();
            buttonDibRect = new Button();
            tabParalelogramo = new TabPage();
            textBoxDesplazamiento = new TextBox();
            label7 = new Label();
            textBoxAltura = new TextBox();
            textBoxBase = new TextBox();
            label6 = new Label();
            label5 = new Label();
            button4 = new Button();
            panel1 = new Panel();
            tabPila = new TabPage();
            textBoxStack = new TextBox();
            button6 = new Button();
            InsertarPila = new Button();
            listBoxStack = new ListBox();
            tabControl.SuspendLayout();
            tabTriangulo.SuspendLayout();
            tabRectangulo.SuspendLayout();
            tabParalelogramo.SuspendLayout();
            tabPila.SuspendLayout();
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
            button2.Location = new Point(81, 178);
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
            tabControl.Controls.Add(tabPila);
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
            tabRectangulo.Controls.Add(panelRectangulo);
            tabRectangulo.Controls.Add(textBoxBRec);
            tabRectangulo.Controls.Add(textBoxARec);
            tabRectangulo.Controls.Add(label4);
            tabRectangulo.Controls.Add(label3);
            tabRectangulo.Controls.Add(buttonDibRect);
            tabRectangulo.Location = new Point(4, 24);
            tabRectangulo.Name = "tabRectangulo";
            tabRectangulo.Padding = new Padding(3);
            tabRectangulo.Size = new Size(387, 165);
            tabRectangulo.TabIndex = 1;
            tabRectangulo.Text = "Rectángulo";
            tabRectangulo.UseVisualStyleBackColor = true;
            // 
            // panelRectangulo
            // 
            panelRectangulo.Location = new Point(149, 26);
            panelRectangulo.Margin = new Padding(3, 2, 3, 2);
            panelRectangulo.Name = "panelRectangulo";
            panelRectangulo.Size = new Size(219, 94);
            panelRectangulo.TabIndex = 9;
            panelRectangulo.Paint += panelRectangulo_paint;
            // 
            // textBoxBRec
            // 
            textBoxBRec.Location = new Point(66, 49);
            textBoxBRec.Margin = new Padding(3, 2, 3, 2);
            textBoxBRec.Name = "textBoxBRec";
            textBoxBRec.Size = new Size(28, 23);
            textBoxBRec.TabIndex = 6;
            // 
            // textBoxARec
            // 
            textBoxARec.Location = new Point(66, 22);
            textBoxARec.Margin = new Padding(3, 2, 3, 2);
            textBoxARec.Name = "textBoxARec";
            textBoxARec.Size = new Size(28, 23);
            textBoxARec.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 51);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 2;
            label4.Text = "Largo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 24);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 1;
            label3.Text = "Ancho";
            // 
            // buttonDibRect
            // 
            buttonDibRect.Location = new Point(157, 141);
            buttonDibRect.Margin = new Padding(3, 2, 3, 2);
            buttonDibRect.Name = "buttonDibRect";
            buttonDibRect.Size = new Size(197, 22);
            buttonDibRect.TabIndex = 0;
            buttonDibRect.Text = "DIBUJAR RECTANGULO";
            buttonDibRect.UseVisualStyleBackColor = true;
            buttonDibRect.Click += buttonDibRect_Click;
            // 
            // tabParalelogramo
            // 
            tabParalelogramo.Controls.Add(textBoxDesplazamiento);
            tabParalelogramo.Controls.Add(label7);
            tabParalelogramo.Controls.Add(textBoxAltura);
            tabParalelogramo.Controls.Add(textBoxBase);
            tabParalelogramo.Controls.Add(label6);
            tabParalelogramo.Controls.Add(label5);
            tabParalelogramo.Controls.Add(button4);
            tabParalelogramo.Controls.Add(panel1);
            tabParalelogramo.Location = new Point(4, 24);
            tabParalelogramo.Name = "tabParalelogramo";
            tabParalelogramo.Padding = new Padding(3);
            tabParalelogramo.Size = new Size(387, 165);
            tabParalelogramo.TabIndex = 2;
            tabParalelogramo.Text = "Paralelogramo";
            tabParalelogramo.UseVisualStyleBackColor = true;
            // 
            // textBoxDesplazamiento
            // 
            textBoxDesplazamiento.Location = new Point(65, 89);
            textBoxDesplazamiento.Margin = new Padding(3, 2, 3, 2);
            textBoxDesplazamiento.Name = "textBoxDesplazamiento";
            textBoxDesplazamiento.Size = new Size(45, 23);
            textBoxDesplazamiento.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 92);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 6;
            label7.Text = "Offset";
            // 
            // textBoxAltura
            // 
            textBoxAltura.Location = new Point(65, 61);
            textBoxAltura.Margin = new Padding(3, 2, 3, 2);
            textBoxAltura.Name = "textBoxAltura";
            textBoxAltura.Size = new Size(45, 23);
            textBoxAltura.TabIndex = 5;
            // 
            // textBoxBase
            // 
            textBoxBase.Location = new Point(65, 34);
            textBoxBase.Margin = new Padding(3, 2, 3, 2);
            textBoxBase.Name = "textBoxBase";
            textBoxBase.Size = new Size(45, 23);
            textBoxBase.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 66);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 3;
            label6.Text = "Altura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 37);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 2;
            label5.Text = "Base";
            // 
            // button4
            // 
            button4.Location = new Point(146, 132);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(219, 22);
            button4.TabIndex = 1;
            button4.Text = "DIBUJA PARALELOGRAMO";
            button4.UseVisualStyleBackColor = true;
            button4.Click += dibujaParalelogram;
            // 
            // panel1
            // 
            panel1.Location = new Point(146, 34);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 94);
            panel1.TabIndex = 0;
            panel1.Paint += panelParalelo_paint;
            // 
            // tabPila
            // 
            tabPila.Controls.Add(listBoxStack);
            tabPila.Controls.Add(textBoxStack);
            tabPila.Controls.Add(button6);
            tabPila.Controls.Add(InsertarPila);
            tabPila.Location = new Point(4, 24);
            tabPila.Name = "tabPila";
            tabPila.Padding = new Padding(3);
            tabPila.Size = new Size(387, 165);
            tabPila.TabIndex = 3;
            tabPila.Text = "Pila";
            tabPila.UseVisualStyleBackColor = true;
            // 
            // textBoxStack
            // 
            textBoxStack.Location = new Point(98, 9);
            textBoxStack.Name = "textBoxStack";
            textBoxStack.Size = new Size(283, 23);
            textBoxStack.TabIndex = 2;
            // 
            // button6
            // 
            button6.Location = new Point(17, 48);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 1;
            button6.Text = "Mostar Pila";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonShowStack;
            // 
            // InsertarPila
            // 
            InsertarPila.Location = new Point(17, 9);
            InsertarPila.Name = "InsertarPila";
            InsertarPila.Size = new Size(75, 23);
            InsertarPila.TabIndex = 0;
            InsertarPila.Text = "Insertar";
            InsertarPila.UseVisualStyleBackColor = true;
            InsertarPila.Click += buttonInsertStack;
            // 
            // listBoxStack
            // 
            listBoxStack.FormattingEnabled = true;
            listBoxStack.ItemHeight = 15;
            listBoxStack.Location = new Point(98, 45);
            listBoxStack.Name = "listBoxStack";
            listBoxStack.Size = new Size(273, 94);
            listBoxStack.TabIndex = 3;
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
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabTriangulo.ResumeLayout(false);
            tabTriangulo.PerformLayout();
            tabRectangulo.ResumeLayout(false);
            tabRectangulo.PerformLayout();
            tabParalelogramo.ResumeLayout(false);
            tabParalelogramo.PerformLayout();
            tabPila.ResumeLayout(false);
            tabPila.PerformLayout();
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
        private TextBox textBoxBRec;
        private TextBox textBoxARec;
        private Label label4;
        private Label label3;
        private Button buttonDibRect;
        private Panel panelRectangulo;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Button button4;
        private TextBox textBoxAltura;
        private TextBox textBoxBase;
        private TextBox textBoxDesplazamiento;
        private Label label7;
        private TabPage tabPila;
        private TextBox textBoxStack;
        private Button button6;
        private Button InsertarPila;
        private ListBox listBoxStack;
    }
}
