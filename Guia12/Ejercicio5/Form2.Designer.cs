namespace Ejercicio5
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            tbValor = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 15;
            label1.Text = "Valor";
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(184, 70);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(96, 32);
            button2.TabIndex = 14;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(30, 70);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(96, 32);
            button1.TabIndex = 13;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(94, 13);
            tbValor.Margin = new Padding(4);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(127, 29);
            tbValor.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 113);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbValor);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Solicitar valor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button1;
        public TextBox tbValor;
    }
}