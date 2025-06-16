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
            btnSolicitar = new Button();
            groupBox1 = new GroupBox();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox2 = new GroupBox();
            button2 = new Button();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 393);
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
            lsbListado.Size = new Size(332, 172);
            lsbListado.TabIndex = 18;
            // 
            // lbCantidad
            // 
            lbCantidad.BackColor = SystemColors.ActiveCaption;
            lbCantidad.Location = new Point(320, 393);
            lbCantidad.Margin = new Padding(4, 0, 4, 0);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(123, 21);
            lbCantidad.TabIndex = 17;
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(352, 6);
            btnSolicitar.Margin = new Padding(5, 6, 5, 6);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(143, 45);
            btnSolicitar.TabIndex = 15;
            btnSolicitar.Text = "Solicitar Valor";
            btnSolicitar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Location = new Point(12, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 140);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de búsqueda";
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
            // textBox1
            // 
            textBox1.Location = new Point(35, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 29);
            textBox1.TabIndex = 22;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(43, 77);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(101, 25);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "Secuencial";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(40, 108);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 25);
            radioButton2.TabIndex = 24;
            radioButton2.TabStop = true;
            radioButton2.Text = "Biseccional";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Location = new Point(352, 263);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(165, 100);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button2
            // 
            button2.Location = new Point(352, 209);
            button2.Margin = new Padding(5, 6, 5, 6);
            button2.Name = "button2";
            button2.Size = new Size(143, 45);
            button2.TabIndex = 25;
            button2.Text = "Mostrar Listado";
            button2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(23, 58);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(95, 25);
            radioButton3.TabIndex = 26;
            radioButton3.TabStop = true;
            radioButton3.Text = "Quicksort";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(23, 28);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(82, 25);
            radioButton4.TabIndex = 25;
            radioButton4.TabStop = true;
            radioButton4.Text = "Burbuja";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 426);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(lsbListado);
            Controls.Add(lbCantidad);
            Controls.Add(btnSolicitar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
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
        private Button btnSolicitar;
        private GroupBox groupBox1;
        private Button button2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private Button btnBuscar;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
    }
}
