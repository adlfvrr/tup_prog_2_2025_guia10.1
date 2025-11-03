namespace ej2
{
    partial class FormPrincipal
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
            groupBox1 = new GroupBox();
            btnRegistrar = new Button();
            tbMotivo = new TextBox();
            tbNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnCrearOrden = new Button();
            lbxVerReclamos = new ListBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            btnEjecutarOrden = new Button();
            lbxVerOrdenAEjecutar = new ListBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(tbMotivo);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 303);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recepción de reclamos";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(63, 214);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(101, 75);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar reclamo";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbMotivo
            // 
            tbMotivo.Location = new Point(63, 88);
            tbMotivo.Multiline = true;
            tbMotivo.Name = "tbMotivo";
            tbMotivo.ScrollBars = ScrollBars.Vertical;
            tbMotivo.Size = new Size(173, 111);
            tbMotivo.TabIndex = 3;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(63, 51);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(173, 23);
            tbNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Motivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 29);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos del reclamo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCrearOrden);
            groupBox2.Controls.Add(lbxVerReclamos);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(265, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(261, 297);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Planificar trabajo";
            // 
            // btnCrearOrden
            // 
            btnCrearOrden.Location = new Point(77, 208);
            btnCrearOrden.Name = "btnCrearOrden";
            btnCrearOrden.Size = new Size(101, 75);
            btnCrearOrden.TabIndex = 5;
            btnCrearOrden.Text = "Crear orden de trabajo";
            btnCrearOrden.UseVisualStyleBackColor = true;
            btnCrearOrden.Click += btnCrearOrden_Click;
            // 
            // lbxVerReclamos
            // 
            lbxVerReclamos.FormattingEnabled = true;
            lbxVerReclamos.ItemHeight = 15;
            lbxVerReclamos.Location = new Point(6, 48);
            lbxVerReclamos.Name = "lbxVerReclamos";
            lbxVerReclamos.Size = new Size(249, 154);
            lbxVerReclamos.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 30);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 0;
            label4.Text = "Lista de reclamos";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEjecutarOrden);
            groupBox3.Controls.Add(lbxVerOrdenAEjecutar);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(532, 18);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(283, 297);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Órdenes de trabajo";
            // 
            // btnEjecutarOrden
            // 
            btnEjecutarOrden.Location = new Point(88, 208);
            btnEjecutarOrden.Name = "btnEjecutarOrden";
            btnEjecutarOrden.Size = new Size(101, 75);
            btnEjecutarOrden.TabIndex = 6;
            btnEjecutarOrden.Text = "Ejecutar orden de trabajo";
            btnEjecutarOrden.UseVisualStyleBackColor = true;
            btnEjecutarOrden.Click += btnEjecutarOrden_Click;
            // 
            // lbxVerOrdenAEjecutar
            // 
            lbxVerOrdenAEjecutar.FormattingEnabled = true;
            lbxVerOrdenAEjecutar.ItemHeight = 15;
            lbxVerOrdenAEjecutar.Location = new Point(6, 48);
            lbxVerOrdenAEjecutar.Name = "lbxVerOrdenAEjecutar";
            lbxVerOrdenAEjecutar.Size = new Size(271, 154);
            lbxVerOrdenAEjecutar.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 30);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 0;
            label5.Text = "Trabajos ejecutados";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 323);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbMotivo;
        private TextBox tbNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnRegistrar;
        private GroupBox groupBox2;
        private Button btnCrearOrden;
        private ListBox lbxVerReclamos;
        private Label label4;
        private GroupBox groupBox3;
        private ListBox lbxVerOrdenAEjecutar;
        private Label label5;
        private Button btnEjecutarOrden;
    }
}
