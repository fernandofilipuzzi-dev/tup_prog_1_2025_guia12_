namespace Ejercicio3
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
            lbCantidad = new Label();
            label1 = new Label();
            btnSolicitar = new Button();
            lsbListado = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbCantidad
            // 
            lbCantidad.BackColor = SystemColors.ActiveCaption;
            lbCantidad.Location = new Point(198, 86);
            lbCantidad.Margin = new Padding(4, 0, 4, 0);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(123, 21);
            lbCantidad.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 86);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 6;
            label1.Text = "Listado";
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(115, 15);
            btnSolicitar.Margin = new Padding(5, 6, 5, 6);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(123, 45);
            btnSolicitar.TabIndex = 5;
            btnSolicitar.Text = "Solicitar Valor";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // lsbListado
            // 
            lsbListado.FormattingEnabled = true;
            lsbListado.ItemHeight = 21;
            lsbListado.Location = new Point(12, 121);
            lsbListado.Name = "lsbListado";
            lsbListado.Size = new Size(332, 172);
            lsbListado.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 86);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 9;
            label2.Text = "Cantidad:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 301);
            Controls.Add(label2);
            Controls.Add(lsbListado);
            Controls.Add(lbCantidad);
            Controls.Add(label1);
            Controls.Add(btnSolicitar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 3. Solicitar una cantidad de valores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCantidad;
        private Label label1;
        private Button btnSolicitar;
        private ListBox lsbListado;
        private Label label2;
    }
}
