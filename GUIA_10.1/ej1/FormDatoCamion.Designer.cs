namespace ej1
{
    partial class FormDatoCamion
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
            nudCapacidad = new NumericUpDown();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Capacidad del camión";
            // 
            // nudCapacidad
            // 
            nudCapacidad.Location = new Point(165, 28);
            nudCapacidad.Name = "nudCapacidad";
            nudCapacidad.Size = new Size(178, 23);
            nudCapacidad.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(99, 73);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(162, 49);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // FormDatoCamion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 134);
            Controls.Add(btnAceptar);
            Controls.Add(nudCapacidad);
            Controls.Add(label1);
            Name = "FormDatoCamion";
            Text = "FormDatoCamion";
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public NumericUpDown nudCapacidad;
        private Button btnAceptar;
    }
}