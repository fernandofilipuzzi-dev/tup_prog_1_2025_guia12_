namespace Ejercicio6
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
            btnSuperanAlPromedio = new Button();
            btnMostrar = new Button();
            groupBox2 = new GroupBox();
            rbQuickSort = new RadioButton();
            rbBurbuja = new RadioButton();
            groupBox1 = new GroupBox();
            rbBiseccional = new RadioButton();
            rbSecuencial = new RadioButton();
            tbValor = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            lsbListado = new ListBox();
            lbCantidad = new Label();
            btnRegistrar = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSuperanAlPromedio
            // 
            btnSuperanAlPromedio.Location = new Point(348, 384);
            btnSuperanAlPromedio.Margin = new Padding(5, 6, 5, 6);
            btnSuperanAlPromedio.Name = "btnSuperanAlPromedio";
            btnSuperanAlPromedio.Size = new Size(143, 60);
            btnSuperanAlPromedio.TabIndex = 34;
            btnSuperanAlPromedio.Text = "Superan al Promedio";
            btnSuperanAlPromedio.UseVisualStyleBackColor = true;
            btnSuperanAlPromedio.Click += btnSuperanAlPromedio_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(348, 218);
            btnMostrar.Margin = new Padding(5, 6, 5, 6);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(143, 45);
            btnMostrar.TabIndex = 33;
            btnMostrar.Text = "Mostrar Listado";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbQuickSort);
            groupBox2.Controls.Add(rbBurbuja);
            groupBox2.Location = new Point(316, 272);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(188, 100);
            groupBox2.TabIndex = 32;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(rbBiseccional);
            groupBox1.Controls.Add(rbSecuencial);
            groupBox1.Controls.Add(tbValor);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Location = new Point(8, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 140);
            groupBox1.TabIndex = 31;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 450);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 30;
            label2.Text = "Cantidad:";
            // 
            // lsbListado
            // 
            lsbListado.FormattingEnabled = true;
            lsbListado.ItemHeight = 21;
            lsbListado.Location = new Point(8, 215);
            lsbListado.Name = "lsbListado";
            lsbListado.Size = new Size(300, 214);
            lsbListado.TabIndex = 29;
            // 
            // lbCantidad
            // 
            lbCantidad.BackColor = SystemColors.ActiveCaption;
            lbCantidad.Location = new Point(316, 450);
            lbCantidad.Margin = new Padding(4, 0, 4, 0);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(123, 21);
            lbCantidad.TabIndex = 28;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(348, 15);
            btnRegistrar.Margin = new Padding(5, 6, 5, 6);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(143, 45);
            btnRegistrar.TabIndex = 27;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 480);
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
            Text = "Ejercicio 6.  Clase servicio";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSuperanAlPromedio;
        private Button btnMostrar;
        private GroupBox groupBox2;
        private RadioButton rbQuickSort;
        private RadioButton rbBurbuja;
        private GroupBox groupBox1;
        private RadioButton rbBiseccional;
        private RadioButton rbSecuencial;
        private TextBox tbValor;
        private Button btnBuscar;
        private Label label2;
        private ListBox lsbListado;
        private Label lbCantidad;
        private Button btnRegistrar;
    }
}
