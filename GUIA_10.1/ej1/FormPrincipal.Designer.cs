namespace ej1
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
            btnRecibirCorrespondencia = new Button();
            tbDireccion = new TextBox();
            tbNombre = new TextBox();
            tbDNI = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnPrepararCamion = new Button();
            lbxVerSectorCarga = new ListBox();
            groupBox3 = new GroupBox();
            lbxListadoAEntregar = new ListBox();
            label7 = new Label();
            btnEntregarPaquete = new Button();
            btnIniciarReparto = new Button();
            groupBox4 = new GroupBox();
            lbNombre = new Label();
            lbDireccion = new Label();
            lbDNI = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRecibirCorrespondencia);
            groupBox1.Controls.Add(tbDireccion);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(tbDNI);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 356);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sector de atención al cliente";
            // 
            // btnRecibirCorrespondencia
            // 
            btnRecibirCorrespondencia.Location = new Point(78, 290);
            btnRecibirCorrespondencia.Name = "btnRecibirCorrespondencia";
            btnRecibirCorrespondencia.Size = new Size(136, 58);
            btnRecibirCorrespondencia.TabIndex = 5;
            btnRecibirCorrespondencia.Text = "Recibir correspondencia";
            btnRecibirCorrespondencia.UseVisualStyleBackColor = true;
            btnRecibirCorrespondencia.Click += btnRecibirCorrespondencia_Click;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(69, 183);
            tbDireccion.Multiline = true;
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(217, 75);
            tbDireccion.TabIndex = 4;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(69, 103);
            tbNombre.Multiline = true;
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(217, 75);
            tbNombre.TabIndex = 4;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(69, 77);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(217, 23);
            tbDNI.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 186);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Dirección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 80);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPrepararCamion);
            groupBox2.Controls.Add(lbxVerSectorCarga);
            groupBox2.Location = new Point(326, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(427, 356);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Paquetes en el sector de embarque";
            // 
            // btnPrepararCamion
            // 
            btnPrepararCamion.Location = new Point(145, 290);
            btnPrepararCamion.Name = "btnPrepararCamion";
            btnPrepararCamion.Size = new Size(136, 58);
            btnPrepararCamion.TabIndex = 6;
            btnPrepararCamion.Text = "Preparar camión";
            btnPrepararCamion.UseVisualStyleBackColor = true;
            btnPrepararCamion.Click += btnPrepararCamion_Click;
            // 
            // lbxVerSectorCarga
            // 
            lbxVerSectorCarga.FormattingEnabled = true;
            lbxVerSectorCarga.ItemHeight = 15;
            lbxVerSectorCarga.Location = new Point(16, 22);
            lbxVerSectorCarga.Name = "lbxVerSectorCarga";
            lbxVerSectorCarga.Size = new Size(394, 259);
            lbxVerSectorCarga.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbxListadoAEntregar);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(btnEntregarPaquete);
            groupBox3.Controls.Add(btnIniciarReparto);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(759, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(363, 356);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tarea de reparto";
            // 
            // lbxListadoAEntregar
            // 
            lbxListadoAEntregar.FormattingEnabled = true;
            lbxListadoAEntregar.ItemHeight = 15;
            lbxListadoAEntregar.Location = new Point(6, 236);
            lbxListadoAEntregar.Name = "lbxListadoAEntregar";
            lbxListadoAEntregar.Size = new Size(351, 109);
            lbxListadoAEntregar.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 218);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 9;
            label7.Text = "Listado a entregar";
            // 
            // btnEntregarPaquete
            // 
            btnEntregarPaquete.Enabled = false;
            btnEntregarPaquete.Location = new Point(206, 144);
            btnEntregarPaquete.Name = "btnEntregarPaquete";
            btnEntregarPaquete.Size = new Size(136, 58);
            btnEntregarPaquete.TabIndex = 8;
            btnEntregarPaquete.Text = "Entregar paquete";
            btnEntregarPaquete.UseVisualStyleBackColor = true;
            btnEntregarPaquete.Click += btnEntregarPaquete_Click;
            // 
            // btnIniciarReparto
            // 
            btnIniciarReparto.Location = new Point(18, 144);
            btnIniciarReparto.Name = "btnIniciarReparto";
            btnIniciarReparto.Size = new Size(136, 58);
            btnIniciarReparto.TabIndex = 7;
            btnIniciarReparto.Text = "Iniciar reparto";
            btnIniciarReparto.UseVisualStyleBackColor = true;
            btnIniciarReparto.Click += btnIniciarReparto_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbNombre);
            groupBox4.Controls.Add(lbDireccion);
            groupBox4.Controls.Add(lbDNI);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(18, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(324, 116);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Próximo a entregar";
            // 
            // lbNombre
            // 
            lbNombre.BackColor = SystemColors.ControlLight;
            lbNombre.Location = new Point(96, 49);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(187, 20);
            lbNombre.TabIndex = 7;
            // 
            // lbDireccion
            // 
            lbDireccion.BackColor = SystemColors.ControlLight;
            lbDireccion.Location = new Point(96, 79);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(187, 20);
            lbDireccion.TabIndex = 8;
            // 
            // lbDNI
            // 
            lbDNI.BackColor = SystemColors.ControlLight;
            lbDNI.Location = new Point(96, 19);
            lbDNI.Name = "lbDNI";
            lbDNI.Size = new Size(187, 20);
            lbDNI.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 19);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 3;
            label6.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 79);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 49);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Nombre";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 382);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormPrincipal";
            Text = "Ejercicio 1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbDireccion;
        private GroupBox groupBox4;
        private Label lbNombre;
        private Label lbDNI;
        private TextBox tbDNI;
        private Button btnRecibirCorrespondencia;
        private TextBox tbDireccion;
        private TextBox tbNombre;
        private Button btnPrepararCamion;
        private ListBox lbxVerSectorCarga;
        private ListBox lbxListadoAEntregar;
        private Label label7;
        private Button btnEntregarPaquete;
        private Button btnIniciarReparto;
    }
}
