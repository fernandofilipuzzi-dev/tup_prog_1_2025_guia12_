namespace Ejercicio2
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
            btnMostrar = new Button();
            tbValor = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(214, 23);
            btnMostrar.Margin = new Padding(5, 6, 5, 6);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(123, 45);
            btnMostrar.TabIndex = 5;
            btnMostrar.Text = "Mostrar Valor";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(84, 32);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 29);
            tbValor.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 9;
            label1.Text = "Valor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 91);
            Controls.Add(label1);
            Controls.Add(tbValor);
            Controls.Add(btnMostrar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio2. Mostrar un valor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnMostrar;
        private TextBox tbValor;
        private Label label1;
    }
}
