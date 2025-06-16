namespace Ejercicio5
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
            label2 = new Label();
            lsbListado = new ListBox();
            lbCantidad = new Label();
            btnRegistrar = new Button();
            groupBox1 = new GroupBox();
            rbBiseccional = new RadioButton();
            rbSecuencial = new RadioButton();
            tbValor = new TextBox();
            btnBuscar = new Button();
            groupBox2 = new GroupBox();
            rbQuickSort = new RadioButton();
            rbBurbuja = new RadioButton();
            btnMostrar = new Button();
            btnSuperanAlPromedio = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 441);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 19;
            label2.Text = "Cantidad:";
            // 
            // lsbListado
            // 
            lsbListado.FormattingEnabled = true;
            lsbListado.ItemHeight = 21;
            lsbListado.Location = new Point(12, 206);
            lsbListado.Name = "lsbListado";
            lsbListado.Size = new Size(300, 214);
            lsbListado.TabIndex = 18;
            // 
            // lbCantidad
            // 
            lbCantidad.BackColor = SystemColors.ActiveCaption;
            lbCantidad.Location = new Point(320, 441);
            lbCantidad.Margin = new Padding(4, 0, 4, 0);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(123, 21);
            lbCantidad.TabIndex = 17;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(352, 6);
            btnRegistrar.Margin = new Padding(5, 6, 5, 6);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(143, 45);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbBiseccional);
            groupBox1.Controls.Add(rbSecuencial);
            groupBox1.Controls.Add(tbValor);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Location = new Point(12, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 140);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de búsqueda";
            // 
            // rbBiseccional
            // 
            rbBiseccional.AutoSize = true;
            rbBiseccional.Location = new Point(40, 108);
            rbBiseccional.Name = "rbBiseccional";
            rbBiseccional.Size = new Size(104, 25);
            rbBiseccional.TabIndex = 24;
            rbBiseccional.TabStop = true;
            rbBiseccional.Text = "Biseccional";
            rbBiseccional.UseVisualStyleBackColor = true;
            // 
            // rbSecuencial
            // 
            rbSecuencial.AutoSize = true;
            rbSecuencial.Location = new Point(40, 77);
            rbSecuencial.Name = "rbSecuencial";
            rbSecuencial.Size = new Size(101, 25);
            rbSecuencial.TabIndex = 23;
            rbSecuencial.TabStop = true;
            rbSecuencial.Text = "Secuencial";
            rbSecuencial.UseVisualStyleBackColor = true;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(35, 42);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(143, 29);
            tbValor.TabIndex = 22;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(340, 33);
            btnBuscar.Margin = new Padding(5, 6, 5, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(143, 45);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbQuickSort);
            groupBox2.Controls.Add(rbBurbuja);
            groupBox2.Location = new Point(320, 263);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(188, 100);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de ordeanmiento";
            // 
            // rbQuickSort
            // 
            rbQuickSort.AutoSize = true;
            rbQuickSort.Location = new Point(23, 58);
            rbQuickSort.Name = "rbQuickSort";
            rbQuickSort.Size = new Size(95, 25);
            rbQuickSort.TabIndex = 26;
            rbQuickSort.TabStop = true;
            rbQuickSort.Text = "Quicksort";
            rbQuickSort.UseVisualStyleBackColor = true;
            // 
            // rbBurbuja
            // 
            rbBurbuja.AutoSize = true;
            rbBurbuja.Location = new Point(23, 28);
            rbBurbuja.Name = "rbBurbuja";
            rbBurbuja.Size = new Size(82, 25);
            rbBurbuja.TabIndex = 25;
            rbBurbuja.TabStop = true;
            rbBurbuja.Text = "Burbuja";
            rbBurbuja.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(352, 209);
            btnMostrar.Margin = new Padding(5, 6, 5, 6);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(143, 45);
            btnMostrar.TabIndex = 25;
            btnMostrar.Text = "Mostrar Listado";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnSuperanAlPromedio
            // 
            btnSuperanAlPromedio.Location = new Point(352, 375);
            btnSuperanAlPromedio.Margin = new Padding(5, 6, 5, 6);
            btnSuperanAlPromedio.Name = "btnSuperanAlPromedio";
            btnSuperanAlPromedio.Size = new Size(143, 60);
            btnSuperanAlPromedio.TabIndex = 26;
            btnSuperanAlPromedio.Text = "Superan al Promedio";
            btnSuperanAlPromedio.UseVisualStyleBackColor = true;
            btnSuperanAlPromedio.Click += btnSuperanAlPromedio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 476);
            Controls.Add(btnSuperanAlPromedio);
            Controls.Add(btnMostrar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(lsbListado);
            Controls.Add(lbCantidad);
            Controls.Add(btnRegistrar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 5. Métodos y vectores";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ListBox lsbListado;
        private Label lbCantidad;
        private Button btnRegistrar;
        private GroupBox groupBox1;
        private Button btnMostrar;
        private RadioButton rbBiseccional;
        private RadioButton rbSecuencial;
        private TextBox tbValor;
        private Button btnBuscar;
        private GroupBox groupBox2;
        private RadioButton rbQuickSort;
        private RadioButton rbBurbuja;
        private Button btnSuperanAlPromedio;
    }
}
